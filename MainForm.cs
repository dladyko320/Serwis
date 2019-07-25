using Serwis.DatabaseOperations;
using System;
using System.Windows.Forms;
using Serwis.Enums;
using Serwis.Models;
using System.Linq;

namespace Serwis
{
    public partial class MainForm : Form
    {
        private ClientsManagement _client;
        private DevicesManagement _device;
        private RepairsManagement _repair;
        private bool focus = true;


        public MainForm()
        {
            InitializeComponent();

            MessageBoxManager.Yes = Messages.Yes;
            MessageBoxManager.No = Messages.No;
            MessageBoxManager.Register();

            _client = ClientsManagement.GetInstance();
            _device = DevicesManagement.GetInstance();
            _repair = RepairsManagement.GetInstance();

            clientBindingSource.DataSource = SerwisContext.GetContext().Clients.ToList();

            deviceBindingSource.DataSource = SerwisContext.GetContext().Devices.ToList();

            repairBindingSource.DataSource = SerwisContext.GetContext().Repairs.ToList();


        }

        private void MainForm_ClientTab_AddButton_Click(object sender, EventArgs e)
        {
            _client.AddClient(MainForm_ClientsTab_NameTextBox.Text,
                MainForm_ClientsTab_PhoneNumberTextBox.Text,
                MainForm_ClientsTab_EmailTextBox.Text,
                MainForm_ClientsTab_AnnotationTextBox.Text
                );

            MainForm_ClientsTab_NameTextBox.Clear();
            MainForm_ClientsTab_PhoneNumberTextBox.Clear();
            MainForm_ClientsTab_EmailTextBox.Clear();
            MainForm_ClientsTab_AnnotationTextBox.Clear();

            RefreshForm(EDataGridType.Clients);

        }

        private void MainForm_ClientsTab_DeleteButton_Click(object sender, EventArgs e)
        {
            if (MainForm_ClientsTab_DataGrid.SelectedRows.Count != 0)
            {
                int id = (int)MainForm_ClientsTab_DataGrid.SelectedRows[0].Cells[0].Value;

                _client.DeleteClient(id);

                RefreshForm(EDataGridType.Clients);

            }
            else
            {
                MessageBox.Show(Messages.NoPosition);
            }
        }

        private void MainForm_ClientsTab_EditButton_Click(object sender, EventArgs e)
        {
            if (MainForm_ClientsTab_DataGrid.SelectedRows.Count != 0)
            {
                int id = (int)MainForm_ClientsTab_DataGrid.SelectedRows[0].Cells[0].Value;

            string name, phone, email, annotation;

            name = MainForm_ClientsTab_DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            phone = MainForm_ClientsTab_DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            email = MainForm_ClientsTab_DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            annotation = MainForm_ClientsTab_DataGrid.SelectedRows[0].Cells[4].Value.ToString();

            ClientEditForm edit = new ClientEditForm(id,name,phone,email,annotation);

            edit.ShowDialog();

            RefreshForm(EDataGridType.Clients);

            }
            else
            {
                MessageBox.Show(Messages.NoPosition);
            }
        }

        private void MainForm_DevicesTab_AddButton_Click(object sender, EventArgs e)
        {

            if (MainForm_DevicesTab_TypeComboBox.SelectedIndex != -1)
            {
                Enum.TryParse<EDeviceType>(MainForm_DevicesTab_TypeComboBox.SelectedIndex.ToString(), out var deviceType);

                _device.AddDevice(MainForm_DevicesTab_NameTextBox.Text,
                 deviceType,
                 MainForm_DevicesTab_ImeiTextBox.Text,
                 MainForm_DevicesTab_AnnotationTextBox.Text);

                MainForm_DevicesTab_NameTextBox.Clear();
                MainForm_DevicesTab_ImeiTextBox.Clear();
                MainForm_DevicesTab_AnnotationTextBox.Clear();

                RefreshForm(EDataGridType.Devices);

            }
            else
            {
                MessageBox.Show(Messages.MainForm_NoDeviceType);
            }         

        }

        private void RefreshForm(EDataGridType type)
        {
            switch(type)
            {
                case EDataGridType.Clients:
                    {
                        clientBindingSource.DataSource = null;
                        clientBindingSource.DataSource = SerwisContext.GetContext().Clients.ToList();
                        break;
                    }
                case EDataGridType.Devices:
                    {
                        deviceBindingSource.DataSource = null;
                        deviceBindingSource.DataSource = SerwisContext.GetContext().Devices.ToList();
                        break;
                    }
                case EDataGridType.Repairs:
                    {
                        repairBindingSource.DataSource = null;
                        repairBindingSource.DataSource = SerwisContext.GetContext().Repairs.ToList();
                        break;
                    }
            }
        }

        private void MainForm_DevicesTab_DeleteButton_Click(object sender, EventArgs e)
        {
            if (MainForm_DevicesTab_DataGrid.SelectedRows.Count > 0)
            {
                int id = (int)MainForm_DevicesTab_DataGrid.SelectedRows[0].Cells[0].Value;

                _device.DeleteDevice(id);
                RefreshForm(EDataGridType.Devices);
            }
            else
            {
                MessageBox.Show(Messages.NoPosition);
            }
        }

        private void MainForm_DevicesTab_EditButton_Click(object sender, EventArgs e)
        {
            if (MainForm_DevicesTab_DataGrid.SelectedRows.Count > 0)
            {
                int id = (int)MainForm_DevicesTab_DataGrid.SelectedRows[0].Cells[0].Value;

                string name, imei, annotation;

                int type = (int)MainForm_DevicesTab_DataGrid.SelectedRows[0].Cells[2].Value;

                name = MainForm_DevicesTab_DataGrid.SelectedRows[0].Cells[1].Value.ToString();
                imei = MainForm_DevicesTab_DataGrid.SelectedRows[0].Cells[3].Value.ToString();
                annotation = MainForm_DevicesTab_DataGrid.SelectedRows[0].Cells[4].Value.ToString();

                DeviceEditForm edit = new DeviceEditForm(id, name, type, imei, annotation);

                edit.ShowDialog();

                RefreshForm(EDataGridType.Devices);
            }
            else
            {
                MessageBox.Show(Messages.NoPosition);
            }

        }

        private void MainForm_RepairsTab_AddButton_Click(object sender, EventArgs e)
        {
            focus = false;
            RepairAddEditForm addRepair = new RepairAddEditForm(null);
            addRepair.ShowDialog();
            focus = true;
            RefreshForm(EDataGridType.Repairs);
            }

        private void MainForm_RepairsTab_DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (focus == true)
            {
                if (MainForm_RepairsTab_DataGrid.SelectedRows.Count > 0)
                {
                    if (MainForm_RepairsTab_DataGrid.SelectedRows[0] != null)
                    {
                        int selectedRepairId = (int)MainForm_RepairsTab_DataGrid.SelectedRows[0].Cells[0].Value;

                        Repair selectedRepair = SerwisContext.GetContext().Repairs.FirstOrDefault(x => x.RepairId == selectedRepairId);
                        repairPositionBindingSource.DataSource = selectedRepair.RepairPositions;
                        MainForm_RepairsTab_DeviceIdNameLabel.Text = selectedRepair.Device.DeviceId.ToString() + " | " + selectedRepair.Device.Name;
                        MainForm_RepairsTab_ClientIdNameLabel.Text = selectedRepair.Client.ClientId.ToString() + " | " + selectedRepair.Client.Name;
                    }
                }
            }
        }

        private void MainForm_RepairsTab_DeleteButton_Click(object sender, EventArgs e)
        {
            if(MainForm_RepairsTab_DataGrid.SelectedRows.Count > 0)
            {
                repairPositionBindingSource.DataSource = null;
                MainForm_RepairsTab_DeviceIdNameLabel.Text = null;
                MainForm_RepairsTab_ClientIdNameLabel.Text = null;

                _repair.DeleteRepair((int)MainForm_RepairsTab_DataGrid.SelectedRows[0].Cells[0].Value);

                RefreshForm(EDataGridType.Repairs);             
            }
            else
            {
                MessageBox.Show(Messages.NoPosition);
            }
        }

        private void MainForm_DevicesTab_HistoryButton_Click(object sender, EventArgs e)
        {
            if (MainForm_DevicesTab_DataGrid.SelectedRows.Count > 0)
            {
                DeviceHistoryForm deviceHistory = new DeviceHistoryForm((int)MainForm_DevicesTab_DataGrid.SelectedRows[0].Cells[0].Value);
                deviceHistory.ShowDialog();
            }
        }

        private void MainForm_RepairsTab_EndButton_Click(object sender, EventArgs e)
        {
            if (MainForm_RepairsTab_DataGrid.SelectedRows.Count > 0)
            {
                _repair.EndRepair((int)MainForm_RepairsTab_DataGrid.SelectedRows[0].Cells[0].Value);
                RefreshForm(EDataGridType.Repairs);
            }
            else
            {
                MessageBox.Show(Messages.NoPosition);
            }
        }

        private void MainForm_ClientsTab_HistoryButton_Click(object sender, EventArgs e)
        {
            if (MainForm_ClientsTab_DataGrid.SelectedRows.Count > 0)
            {
                ClientHistoryForm clientHistory = new ClientHistoryForm((int)MainForm_ClientsTab_DataGrid.SelectedRows[0].Cells[0].Value);
                clientHistory.ShowDialog();
            }
        }

        private void MainForm_RepairsTab_EditButton_Click(object sender, EventArgs e)
        {
            if (MainForm_RepairsTab_DataGrid.SelectedRows.Count > 0)
            {
                focus = false;
                var repair = MainForm_RepairsTab_DataGrid.CurrentRow.DataBoundItem as Repair;
                RepairAddEditForm addRepair = new RepairAddEditForm(repair);
                addRepair.ShowDialog();
                focus = true;
                RefreshForm(EDataGridType.Repairs);
                MainForm_RepairsTab_DataGrid.ClearSelection();
                repairPositionBindingSource.DataSource = null;
                MainForm_RepairsTab_DeviceIdNameLabel.Text = null;
                MainForm_RepairsTab_ClientIdNameLabel.Text = null;

            }
            else
            {
                MessageBox.Show(Messages.NoPosition);
            }
        }

        private void MainForm_InfoButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }
    }
}
