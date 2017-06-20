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
        public List<Partij> partijen = new List<Partij>();
        private IDatabaseConnector connector;
        public BindingList<Uitslag> blUitslag;
        public BindingList<Coalitie> blCoalitie;
        public LivePerformance()
        {
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
            partijen = _partijRepo.GetAll();
            blUitslag = new BindingList<Uitslag>(_uitslagRepo.GetAll());
            blCoalitie = new BindingList<Coalitie>(_coalitieRepo.GetAll());
            foreach (Partij partij in partijen)
            {
                LBAllePartijen.Items.Add(partij);
            }
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
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
       
       
        }

        private void LBAllePartijen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGVUitslagen_DoubleClick(object sender, EventArgs e)
        {
            if (DGVUitslagen.SelectedRows.Count == 1)
            {

            }
            else
            {
                MessageBox.Show("Selecteer een verkiezingsuitslag. Doe daarna een double click. Zo open je een uitslag.");
            }
            tcHoofd.SelectTab(2);
        }
    }
}
