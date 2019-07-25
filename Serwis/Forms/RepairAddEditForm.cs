using Serwis.DatabaseOperations;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using Serwis.Models;
using System.Collections.Generic;
using Serwis.Enums;
using System.Linq;

namespace Serwis
{
    public partial class RepairAddEditForm : Form
    {
        private EFormMode _formMode = EFormMode.Add;
        private RepairPositionsManagement _repairPosition;
        private RepairsManagement _repairsManagement;
        private bool saved = false;

        private Repair _repair;

        int id = 0;
        List<RepairPosition> positionsList = new List<RepairPosition>();
        DateTime startDate;
        DateTime? endDate;

        public RepairAddEditForm(Repair repair)
        {
            InitializeComponent();
            _repair = repair ?? new Repair();
            
            _repairPosition = RepairPositionsManagement.GetInstance();
            _repairsManagement = RepairsManagement.GetInstance();

            SerwisContext.GetContext().Clients.Load();
            clientBindingSource.DataSource = SerwisContext.GetContext().Clients.ToList();

            SerwisContext.GetContext().Devices.Load();
            deviceBindingSource.DataSource = SerwisContext.GetContext().Devices.ToList();


            if (repair != null)
            {
                _formMode = EFormMode.Edit;
                Text = Messages.RepairAddEditForm_EditFormText;
                RefreshPositionsGridData();
            }
        }


        private void AddRepairForm_PositionsPanel_AddButton_Click(object sender, EventArgs e)
        {
            if (RepairAddEditForm_PositionsPanel_TypeComboBox.SelectedIndex != -1)
            {
                if (!string.IsNullOrWhiteSpace(RepairAddEditForm_PositionsPanel_DescriptionTextBox.Text))
                {
                    Enum.TryParse<EPositionType>(RepairAddEditForm_PositionsPanel_TypeComboBox.SelectedIndex.ToString(), out var positionType);

                    int positionCost = (int)RepairAddEditForm_PositionsPanel_CostNumericUpDown.Value;
                    int positionIncome = (int)RepairAddEditForm_PositionsPanel_IncomeNumericUpDown.Value;

                    _repair.RepairPositions.Add(new RepairPosition { PositionId = id,
                        Description = RepairAddEditForm_PositionsPanel_DescriptionTextBox.Text,
                        Type = positionType,
                        Cost = positionCost,
                        Income = positionIncome });

                    RepairAddEditForm_PositionsPanel_CostNumericUpDown.Value = 0;
                    RepairAddEditForm_PositionsPanel_IncomeNumericUpDown.Value = 0;
                    RepairAddEditForm_PositionsPanel_DescriptionTextBox.Clear();

                    RefreshPositionsGridData();


                    id++;
                }
                else
                {
                    MessageBox.Show(Messages.RepairAddEditForm_EmptyPositionFields);
                }
            }
            else
            {
                MessageBox.Show(Messages.RepairAddEditForm_NoPositionType);
            }
        }

        private void AddRepairForm_PositionsPanel_CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AddRepairForm_PositionsPanel_IncomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void RefreshPositionsGridData()
        {
            RepairAddEditForm_PositionsDataGrid.DataSource = null;
            RepairAddEditForm_PositionsDataGrid.DataSource = _repair.RepairPositions;
        }

        private void AddRepairForm_PositionsPanel_DeleteButton_Click(object sender, EventArgs e)
        {
            if(RepairAddEditForm_PositionsDataGrid.SelectedRows.Count > 0)
            {
                var position = RepairAddEditForm_PositionsDataGrid.SelectedRows[0].DataBoundItem as RepairPosition;
                SerwisContext.GetContext().RepairPosition.Remove(position);
                RefreshPositionsGridData();
                SerwisContext.GetContext().SaveChanges();
            }
            else
            {
                MessageBox.Show(Messages.RepairAddEditForm_NoPosition);
            }
        }

        private void AddRepairForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved == false)
            {
                DialogResult dialogResult = MessageBox.Show(Messages.SaveChanges, Messages.Attention, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    saved = true;
                    SaveChanges();
                }
                else if (dialogResult == DialogResult.No)
                {}
            }
        }

        private void AddRepairForm_SaveButton_Click(object sender, EventArgs e)
        {
            saved = true;
            SaveChanges();
        }

        private void SaveChanges()
        {
            if (RepairAddEditForm_ClientDataGrid.Rows.Count > 0)
            {
                if (RepairAddEditForm_DevicesDataGrid.Rows.Count > 0)
                {

                    int income = 0;

                    foreach(DataGridViewRow row in RepairAddEditForm_PositionsDataGrid.Rows)
                    {
                        income = income + (int)row.Cells[4].Value;
                    }

                    int clientId = (int)RepairAddEditForm_ClientDataGrid.SelectedRows[0].Cells[0].Value;
                    Client client = SerwisContext.GetContext().Clients.FirstOrDefault(x => x.ClientId == clientId);

                    int deviceId = (int)RepairAddEditForm_DevicesDataGrid.SelectedRows[0].Cells[0].Value;
                    Device device = SerwisContext.GetContext().Devices.FirstOrDefault(x => x.DeviceId == deviceId);

                    if (_formMode == EFormMode.Add)
                    {
                        _repair.Device = device;
                        _repair.Client = client;
                        _repair.Income = income;
                        _repair.StartDate = DateTime.Now;

                        _repairsManagement.AddRepair(_repair);
                    }
                    else
                    {
                        _repair.Device = device;
                        _repair.Client = client;
                        SerwisContext.GetContext().SaveChanges();
                    }

                    Close();

                }
                else
                {
                    MessageBox.Show(Messages.RepairAddEditForm_NoDevice);
                }
            }
            else
            {
                MessageBox.Show(Messages.RepairAddEditForm_NoClient);
            }
        }
    }
}
