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
        private IDatabaseConnector connector;
        public BindingList<Uitslag> blUitslag;
        public LivePerformance()
        {
            _uitslagRepo = new UitslagRepository(connector);
            InitializeComponent();
        }

        private void fetchDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OphalenAlleData();
        }

        public void OphalenAlleData()
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
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
       
       
        }
    }
}
