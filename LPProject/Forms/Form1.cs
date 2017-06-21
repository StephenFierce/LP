using LPProject.Core.Connection;
using LPProject.Core.Enumerations;
using LPProject.Core.Repositories;
using LPProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public Partij regeringsPartij = new Partij();
        public List<Partij> coalitiePartijen = new List<Partij>();
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
            try
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
            catch (Exception)
            {
                MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
            }
        }

        public void VerversListbox()
        {
            try
            {
                partijen = _partijRepo.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
            }
            LBAllePartijen.Items.Clear();
            foreach (Partij partij in partijen)
            {
                LBAllePartijen.Items.Add(partij);
            }
        }

        public void VerversUitslagen()
        {
            try
            {
                blUitslag = new BindingList<Uitslag>(_uitslagRepo.GetAll());
                DGVUitslagen.DataSource = blUitslag;
            }
            catch (Exception)
            {
                MessageBox.Show("Er is geen database connectie! Verbindt eerst met de database.");
            }

        }

        private void DGVUitslagen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= DGVUitslagen.RowCount && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DGVUitslagen.Rows[e.RowIndex];
                Uitslag uitslag = selectedRow.DataBoundItem as Uitslag;
                try
                {
                    _uitslagRepo.Update(uitslag);
                }
                catch (Exception)
                {
                    MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
                }
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

        private void btnPartijToevoegen_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text.Length > 10 || tbNaam.Text == null || tbLijsttrekker == null)
            {
                MessageBox.Show("Vul een partijnaam en lijsttrekkernaam in, een partij naam mag maximaal 10 karakters lang zijn.");
            }
            else
            {
                Partij nieuwePartij = new Partij()
                {
                    Naam = tbNaam.Text,
                    Lijsttrekker = tbLijsttrekker.Text
                };
                try
                {
                    _partijRepo.Add(nieuwePartij);
                    VerversListbox();
                }
                catch (Exception)
                {
                    MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
                }
            }
            FormSchoonmaak();
        }

        private void btnToevoegenAanUitslag_Click(object sender, EventArgs e)
        {
            int aantalstemmen = 0;
            if (!int.TryParse(tbAantalStemmen.Text, out aantalstemmen) || tbAantalStemmen.Text == null)
            {
                MessageBox.Show("Vul eerst het aantal stemmen in! Alleen cijfers graag.");
            }
            else
            {
                Stemmen stem = new Stemmen()
                {
                    Partij = (Partij)LBAllePartijen.SelectedItem,
                    AantalStemmen = Convert.ToInt32(tbAantalStemmen.Text)
                };
                lbPartijenInUitslag.Items.Add(stem);
            }
            FormSchoonmaak();
        }

        private void btnUitslagAfronden_Click(object sender, EventArgs e)
        {
            if (cbSoortUitslag.SelectedItem == null || tbNaamUitslag.Text == null || lbPartijenInUitslag.Items == null)
            {
                MessageBox.Show("Selecteer eerst partijen met hun stemmen, vul vervolgens een naam in, hierna kiest u de soort verkiezing en tot slot klikt u op afronden.");
            }
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
            try
            {
                _uitslagRepo.Add(nieuweUitslag);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
            }
            FormSchoonmaak();
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
                try
                {
                    _uitslagRepo.Delete(verwijderUitslag);
                }
                catch (Exception)
                {
                    MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een item!");
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
                //DGVGeselecteerdeUitslag.DataSource = blStemmen;
                List<int> zetels = new List<int>();
                int totaalStemmen = uitslagStemmen.Sum(x => x.AantalStemmen);
                int counter = 0;
                decimal aantalZetels = 0;
                int totaalZetels = 150;
                foreach (Stemmen stem in uitslagStemmen)
                {
                    aantalZetels = ((Convert.ToDecimal(stem.AantalStemmen) / Convert.ToDecimal(totaalStemmen)) * totaalZetels);
                    decimal percentage = (100 / Convert.ToDecimal(totaalStemmen)) * Convert.ToDecimal(stem.AantalStemmen);
                    DGVGeselecteerdeUitslag.Rows.Add(stem.ID.ToString());
                    DGVGeselecteerdeUitslag.Rows[counter].Cells[2].Value = stem.AantalStemmen;
                    decimal finalZetels = CustomRound(aantalZetels);
                    DGVGeselecteerdeUitslag.Rows[counter].Cells[3].Value = Convert.ToInt32(finalZetels);
                    DGVGeselecteerdeUitslag.Rows[counter].Cells[4].Value = Math.Round(percentage, 1);
                    DGVGeselecteerdeUitslag.Rows[counter].Cells[1].Value = stem.Partij.Naam;
                    counter++;
                }
                tcHoofd.SelectTab(3);
            }
            else
            {
                MessageBox.Show("Selecteer eerst een item!");
            }
        }

        private static decimal CustomRound(decimal x)
        {
            if (x > 8)
            {
                return decimal.Round(x + 0.2m, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                return decimal.Round(x - 0.3m, 2, MidpointRounding.AwayFromZero);
            }

        }

        private void btnPartijAanpassen_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text.Length > 10 || tbNaam.Text == null || tbLijsttrekker == null)
            {
                MessageBox.Show("Vul een partijnaam en lijsttrekkernaam in, een partij naam mag maximaal 10 karakters lang zijn.");
            }
            else
            {
                Partij aangepastePartij = new Partij()
                {
                    ID = geselecteerdePartij.ID,
                    Naam = tbPartijNaamAanpassen.Text,
                    Lijsttrekker = tbPartijLijsttrekkerAanpassen.Text
                };

                try
                {
                    _partijRepo.Update(aangepastePartij);
                    VerversListbox();
                }
                catch (Exception)
                {
                    MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
                }
            }
            FormSchoonmaak();
        }

        private void DGVGeselecteerdeUitslag_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= DGVGeselecteerdeUitslag.RowCount && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DGVGeselecteerdeUitslag.Rows[e.RowIndex];
                Stemmen stem = new Stemmen()
                {
                    AantalStemmen = Convert.ToInt32(selectedRow.Cells[2].Value),
                    ID = Convert.ToInt32(selectedRow.Cells[0].Value)
                };
                if (stem != null)
                {
                    try
                    {
                        _stemmenRepo.Update(stem);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
                    }
                }

            }

            DGVGeselecteerdeUitslag.Refresh();
        }

        private void DGVGeselecteerdeUitslag_SelectionChanged(object sender, EventArgs e)
        {
            coalitiePartijen.Clear();
            int totaalZetelAantal = 0;
            int vorigAantalZetels = 0;
            int huidigZetelAantal = 0;
            string premierPartij = "";
            string huidigePartij = "";
            int counter = 0;
            try
            {
                foreach (DataGridViewRow regel in DGVGeselecteerdeUitslag.SelectedRows)
                {
                    huidigZetelAantal = Convert.ToInt32(regel.Cells[3].Value);
                    huidigePartij = regel.Cells[1].Value.ToString();
                    coalitiePartijen.Add(_partijRepo.GetItem(huidigePartij));
                    coalitiePartijen[counter].Zetels = huidigZetelAantal;
                    if (huidigZetelAantal > vorigAantalZetels)
                    {
                        premierPartij = regel.Cells[1].Value.ToString();
                    }
                    totaalZetelAantal = totaalZetelAantal + huidigZetelAantal;
                    vorigAantalZetels = huidigZetelAantal;
                    counter++;
                }
                int kamermeerderheid = 76;
                if (totaalZetelAantal >= kamermeerderheid)
                    lblAantalZetels.Text = "Huidig aantal zetels: " + totaalZetelAantal + "  Deze selectie geeft een kamermeerderheid.";
                else
                    lblAantalZetels.Text = "Huidig aantal zetels: " + totaalZetelAantal;


                regeringsPartij = _partijRepo.GetItem(premierPartij);
                lblPremier.Text = "Premier: " + regeringsPartij.Lijsttrekker;
            }
            catch (Exception)
            {
                MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
            }
        }

        private void btnVormCoalitie_Click(object sender, EventArgs e)
        {
            if (DGVGeselecteerdeUitslag.SelectedRows == null)
            {
                MessageBox.Show("Selecteer eerst partijen voordat je een coalitie probeert te vormen!");
            }
            else
            {
                string path = @"C:\Users\steph\Source\Repos\LP\LPProject\CoalitieVoorstel.txt";
                //if (!File.Exists(path))
                //    File.Create(path);

                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.WriteLine("Coalitie voorstel Tweede Kamer");
                    sw.WriteLine("==============================");
                    sw.WriteLine(Environment.NewLine);
                    sw.WriteLine("Van: Tjeenk Willink");
                    sw.WriteLine("Aan: Z.M. Koning Willem-Alexander: Majesteit;");
                    sw.WriteLine(Environment.NewLine);
                    sw.WriteLine("Partij\t\tZetels\t\tLijsttrekker");
                    sw.WriteLine(Environment.NewLine);
                    int zetelTeller = 0;
                    foreach (Partij regeringsPartij in coalitiePartijen)
                    {
                        zetelTeller = zetelTeller + regeringsPartij.Zetels;
                        sw.WriteLine(regeringsPartij.Naam + "\t\t" + regeringsPartij.Zetels + "\t\t" + regeringsPartij.Lijsttrekker);
                    }
                    sw.WriteLine("===================");
                    sw.WriteLine("Totaal:\t\t" + zetelTeller + "\t\tPremier: " + regeringsPartij.Lijsttrekker);
                }
            }
        }

        private void btnPartijVerwijderen_Click(object sender, EventArgs e)
        {
            if (LBAllePartijen.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst een partij uit de linkse lijst.");
            }
            else
            {
                Partij partij = LBAllePartijen.SelectedItem as Partij;
                try
                {
                    _partijRepo.Delete(partij);
                    VerversListbox();
                }
                catch (Exception)
                {
                    MessageBox.Show("Er is geen database verbinding. Maak verbinding met de VPN!");
                }
            }
            FormSchoonmaak();
        }

        private void FormSchoonmaak()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
    }
}

