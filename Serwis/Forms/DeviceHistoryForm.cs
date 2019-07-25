using System.Windows.Forms;
using Serwis.DatabaseOperations;
using Serwis.Models;
using System.Linq;


namespace Serwis
{
    public partial class DeviceHistoryForm : Form
    {

        public DeviceHistoryForm(int deviceId)
        {
            InitializeComponent();
         
            var repairsHistory = SerwisContext.GetContext().Repairs.Where(x => x.Device.DeviceId == deviceId).ToList();
            repairBindingSource.DataSource = repairsHistory;

        }

        private void DeviceHistoryForm_HistoryDataGrid_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DeviceHistoryForm_HistoryDataGrid.SelectedRows.Count > 0)
            {
                int selectedRepairId = (int)DeviceHistoryForm_HistoryDataGrid.SelectedRows[0].Cells[0].Value;
                Repair selectedRepair = SerwisContext.GetContext().Repairs.FirstOrDefault(x => x.RepairId == selectedRepairId);
                repairPositionBindingSource.DataSource = selectedRepair.RepairPositions;
                DeviceHistoryForm_ClientIdNameLabel.Text = selectedRepair.Client.ClientId.ToString() + " | " + selectedRepair.Client.Name;
            }
        }
    }
}
