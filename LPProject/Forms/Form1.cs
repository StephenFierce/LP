using LPProject.Core.Connection;
using LPProject.Core.Enumerations;
using LPProject.Core.Repositories;
using LPProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPProject
{
    public partial class LivePerformance : Form
    {
        private UitslagRepository _uitslagRepo;
        private PartijRepository _partijRepo;
        private CoalitieRepository _coalitieRepo;
        private StemmenRepository _stemmenRepo;
        public List<Partij> partijen = new List<Partij>();
        private IDatabaseConnector connector;
        public BindingList<Uitslag> blUitslag;
        public BindingList<Coalitie> blCoalitie;
        public BindingList<Partij> blPartij;
        public BindingList<Stemmen> blStemmen;
        public Partij geselecteerdePartij = new Partij();
        public LivePerformance()
        {
            _stemmenRepo = new StemmenRepository(connector);
            _uitslagRepo = new UitslagRepository(connector);
            _partijRepo = new PartijRepository(connector);
            _coalitieRepo = new CoalitieRepository(connector);
            InitializeComponent();
        }

        private void fetchDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OphalenAlleData();
        }

        public void OphalenAlleData()
        {
            VerversListbox();
            blPartij = new BindingList<Partij>(partijen);
            blCoalitie = new BindingList<Coalitie>(_coalitieRepo.GetAll());
            VerversUitslagen();
            DGVPartijen.DataSource = blPartij;
            DGVCoalities.DataSource = blCoalitie;
            foreach (Verkiezingssoort soort in Enum.GetValues(typeof(Verkiezingssoort)))
            {
                cbSoortUitslag.Items.Add(soort);
            }
        }

        public void VerversListbox()
        {
            partijen = _partijRepo.GetAll();
            LBAllePartijen.Items.Clear();
            foreach (Partij partij in partijen)
            {
                LBAllePartijen.Items.Add(partij);
            }
        }

        public void VerversUitslagen()
        {
            blUitslag = new BindingList<Uitslag>(_uitslagRepo.GetAll());
            DGVUitslagen.DataSource = blUitslag;
        }

        private void DGVUitslagen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex <= DGVUitslagen.RowCount && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DGVUitslagen.Rows[e.RowIndex];
                Uitslag uitslag = selectedRow.DataBoundItem as Uitslag;
                _uitslagRepo.Update(uitslag);
            }

            DGVUitslagen.Refresh();
        }

        private void DGVUitslagen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }


        }

        private void LBAllePartijen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            geselecteerdePartij = (Partij)LBAllePartijen.SelectedItem;
            tbPartijNaamAanpassen.Text = geselecteerdePartij.Naam;
            tbPartijLijsttrekkerAanpassen.Text = geselecteerdePartij.Lijsttrekker;
        }

        private void DGVUitslagen_DoubleClick(object sender, EventArgs e)
        {
            if (DGVUitslagen.SelectedRows.Count == 1)
            {
                tcHoofd.SelectTab(2);
            }
            else
            {
                MessageBox.Show("Selecteer een verkiezingsuitslag. Doe daarna een double click. Zo open je een uitslag.");
            }

        }

        private void btnPartijToevoegen_Click(object sender, EventArgs e)
        {
            Partij nieuwePartij = new Partij()
            {
                Naam = tbNaam.Text,
                Lijsttrekker = tbLijsttrekker.Text
            };
            _partijRepo.Add(nieuwePartij);
            VerversListbox();
        }

        private void btnToevoegenAanUitslag_Click(object sender, EventArgs e)
        {
            Stemmen stem = new Stemmen()
            {
                Partij = (Partij)LBAllePartijen.SelectedItem,
                AantalStemmen = Convert.ToInt32(tbAantalStemmen.Text)
            };
            lbPartijenInUitslag.Items.Add(stem);
        }

        private void btnUitslagAfronden_Click(object sender, EventArgs e)
        {
            List<Stemmen> stemmenNieuweUitslag = new List<Stemmen>();
            foreach (Stemmen stem in lbPartijenInUitslag.Items)
            {
                stemmenNieuweUitslag.Add(stem);
            }

            Uitslag nieuweUitslag = new Uitslag()
            {
                Datum = dtpDatumUitslag.Value,
                Naam = tbNaamUitslag.Text,
                Stemmen = stemmenNieuweUitslag,
                Soort = (Verkiezingssoort)cbSoortUitslag.SelectedItem
            };
            _uitslagRepo.Add(nieuweUitslag);
        }

        private void btnVerwijderUitslag_Click(object sender, EventArgs e)
        {
            if (DGVUitslagen.SelectedCells.Count > 0)
            {
                int geselecteerdeRij = DGVUitslagen.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DGVUitslagen.Rows[geselecteerdeRij];
                int uitslagID = Convert.ToInt32(selectedRow.Cells[0].Value);
                Uitslag verwijderUitslag = new Uitslag()
                {
                    ID = uitslagID
                };
                _uitslagRepo.Delete(verwijderUitslag);
            }
            VerversUitslagen();
        }

        private void btnSelecteerUitslag_Click(object sender, EventArgs e)
        {
            if (DGVUitslagen.SelectedCells.Count > 0)
            {
                List<Stemmen> uitslagStemmen = new List<Stemmen>();
                int geselecteerdeRij = DGVUitslagen.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DGVUitslagen.Rows[geselecteerdeRij];
                int uitslagID = Convert.ToInt32(selectedRow.Cells[0].Value);
                //get stemmen where uitslagID = @ID STEMMEN REPOSITORY/Context
                uitslagStemmen = _stemmenRepo.GetAll(true, uitslagID);
                Uitslag geselecteerdeUitslag = new Uitslag()
                {
                    ID = Convert.ToInt32(selectedRow.Cells[0].Value),
                    Naam = Convert.ToString(selectedRow.Cells[1].Value),
                    Datum = Convert.ToDateTime(selectedRow.Cells[2].Value),
                    Soort = (Verkiezingssoort)selectedRow.Cells[3].Value,
                    Stemmen = uitslagStemmen
                };
                blStemmen = new BindingList<Stemmen>(uitslagStemmen);
                lblDatum.Text = "Datum: " + geselecteerdeUitslag.Datum.ToShortDateString();
                lblSoort.Text = "Soort: " + geselecteerdeUitslag.Soort.ToString();
                lblNaam.Text = "Naam: " + geselecteerdeUitslag.Naam;
                DGVGeselecteerdeUitslag.DataSource = blStemmen;
                tcHoofd.SelectTab(3);
            }
        }

        private void btnPartijAanpassen_Click(object sender, EventArgs e)
        {
            Partij aangepastePartij = new Partij()
            {
                ID = geselecteerdePartij.ID,
                Naam = tbPartijNaamAanpassen.Text,
                Lijsttrekker = tbPartijLijsttrekkerAanpassen.Text
            };
            _partijRepo.Update(aangepastePartij);
            VerversListbox();
        }
    }
}
