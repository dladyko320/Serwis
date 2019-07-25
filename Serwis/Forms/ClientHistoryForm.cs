using System.Windows.Forms;
using Serwis.DatabaseOperations;
using System.Linq;
using Serwis.Models;

namespace Serwis
{
    public partial class ClientHistoryForm : Form
    {
        public ClientHistoryForm(int clientId)
        {
            InitializeComponent();

            var repairsHistory = SerwisContext.GetContext().Repairs.Where(x => x.Client.ClientId == clientId).ToList();
            repairBindingSource.DataSource = repairsHistory;
        }

        private void ClientHistoryForm_HistoryDataGrid_SelectionChanged(object sender, System.EventArgs e)
        {
            if (ClientHistoryForm_HistoryDataGrid.SelectedRows.Count > 0)
            {
                int selectedRepairId = (int)ClientHistoryForm_HistoryDataGrid.SelectedRows[0].Cells[0].Value;
                Repair selectedRepair = SerwisContext.GetContext().Repairs.FirstOrDefault(x => x.RepairId == selectedRepairId);
                repairPositionBindingSource.DataSource = selectedRepair.RepairPositions;
                ClientHistoryForm_DeviceIdNameLabel.Text = selectedRepair.Device.DeviceId.ToString() + " | " + selectedRepair.Device.Name;
            }
        }
    }
}
