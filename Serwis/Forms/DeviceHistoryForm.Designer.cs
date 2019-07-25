namespace Serwis
{
    partial class DeviceHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeviceHistoryForm_HistoryDataGrid = new MetroFramework.Controls.MetroGrid();
            this.DeviceHistoryForm_SelectedRepairPanel = new MetroFramework.Controls.MetroPanel();
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid = new MetroFramework.Controls.MetroGrid();
            this.DeviceHistoryForm_ClientIdNameLabel = new MetroFramework.Controls.MetroLabel();
            this.DeviceHistoryForm_ClientIdNameStaticLabel = new MetroFramework.Controls.MetroLabel();
            this.positionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceHistoryForm_HistoryDataGrid)).BeginInit();
            this.DeviceHistoryForm_SelectedRepairPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceHistoryForm_SelectedRepairPositionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairPositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceHistoryForm_HistoryDataGrid
            // 
            this.DeviceHistoryForm_HistoryDataGrid.AllowUserToAddRows = false;
            this.DeviceHistoryForm_HistoryDataGrid.AllowUserToDeleteRows = false;
            this.DeviceHistoryForm_HistoryDataGrid.AllowUserToOrderColumns = true;
            this.DeviceHistoryForm_HistoryDataGrid.AllowUserToResizeRows = false;
            this.DeviceHistoryForm_HistoryDataGrid.AutoGenerateColumns = false;
            this.DeviceHistoryForm_HistoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeviceHistoryForm_HistoryDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeviceHistoryForm_HistoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeviceHistoryForm_HistoryDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DeviceHistoryForm_HistoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceHistoryForm_HistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DeviceHistoryForm_HistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviceHistoryForm_HistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairIdDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.deviceDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn});
            this.DeviceHistoryForm_HistoryDataGrid.DataSource = this.repairBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeviceHistoryForm_HistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeviceHistoryForm_HistoryDataGrid.EnableHeadersVisualStyles = false;
            this.DeviceHistoryForm_HistoryDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DeviceHistoryForm_HistoryDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeviceHistoryForm_HistoryDataGrid.Location = new System.Drawing.Point(12, 12);
            this.DeviceHistoryForm_HistoryDataGrid.Name = "DeviceHistoryForm_HistoryDataGrid";
            this.DeviceHistoryForm_HistoryDataGrid.ReadOnly = true;
            this.DeviceHistoryForm_HistoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceHistoryForm_HistoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DeviceHistoryForm_HistoryDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DeviceHistoryForm_HistoryDataGrid.RowTemplate.Height = 24;
            this.DeviceHistoryForm_HistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeviceHistoryForm_HistoryDataGrid.Size = new System.Drawing.Size(776, 257);
            this.DeviceHistoryForm_HistoryDataGrid.TabIndex = 0;
            this.DeviceHistoryForm_HistoryDataGrid.SelectionChanged += new System.EventHandler(this.DeviceHistoryForm_HistoryDataGrid_SelectionChanged);
            // 
            // DeviceHistoryForm_SelectedRepairPanel
            // 
            this.DeviceHistoryForm_SelectedRepairPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeviceHistoryForm_SelectedRepairPanel.Controls.Add(this.DeviceHistoryForm_SelectedRepairPositionsDataGrid);
            this.DeviceHistoryForm_SelectedRepairPanel.Controls.Add(this.DeviceHistoryForm_ClientIdNameLabel);
            this.DeviceHistoryForm_SelectedRepairPanel.Controls.Add(this.DeviceHistoryForm_ClientIdNameStaticLabel);
            this.DeviceHistoryForm_SelectedRepairPanel.HorizontalScrollbarBarColor = true;
            this.DeviceHistoryForm_SelectedRepairPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.DeviceHistoryForm_SelectedRepairPanel.HorizontalScrollbarSize = 10;
            this.DeviceHistoryForm_SelectedRepairPanel.Location = new System.Drawing.Point(12, 275);
            this.DeviceHistoryForm_SelectedRepairPanel.Name = "DeviceHistoryForm_SelectedRepairPanel";
            this.DeviceHistoryForm_SelectedRepairPanel.Size = new System.Drawing.Size(776, 200);
            this.DeviceHistoryForm_SelectedRepairPanel.TabIndex = 11;
            this.DeviceHistoryForm_SelectedRepairPanel.VerticalScrollbarBarColor = true;
            this.DeviceHistoryForm_SelectedRepairPanel.VerticalScrollbarHighlightOnWheel = false;
            this.DeviceHistoryForm_SelectedRepairPanel.VerticalScrollbarSize = 10;
            // 
            // DeviceHistoryForm_SelectedRepairPositionsDataGrid
            // 
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.AllowUserToAddRows = false;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.AllowUserToDeleteRows = false;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.AllowUserToOrderColumns = true;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.AllowUserToResizeRows = false;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.AutoGenerateColumns = false;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn1});
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.DataSource = this.repairPositionBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.EnableHeadersVisualStyles = false;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.Location = new System.Drawing.Point(3, 81);
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.Name = "DeviceHistoryForm_SelectedRepairPositionsDataGrid";
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.ReadOnly = true;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.RowTemplate.Height = 24;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.Size = new System.Drawing.Size(768, 114);
            this.DeviceHistoryForm_SelectedRepairPositionsDataGrid.TabIndex = 8;
            // 
            // DeviceHistoryForm_ClientIdNameLabel
            // 
            this.DeviceHistoryForm_ClientIdNameLabel.Location = new System.Drawing.Point(14, 33);
            this.DeviceHistoryForm_ClientIdNameLabel.Name = "DeviceHistoryForm_ClientIdNameLabel";
            this.DeviceHistoryForm_ClientIdNameLabel.Size = new System.Drawing.Size(170, 45);
            this.DeviceHistoryForm_ClientIdNameLabel.TabIndex = 5;
            this.DeviceHistoryForm_ClientIdNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeviceHistoryForm_ClientIdNameLabel.WrapToLine = true;
            // 
            // DeviceHistoryForm_ClientIdNameStaticLabel
            // 
            this.DeviceHistoryForm_ClientIdNameStaticLabel.AutoSize = true;
            this.DeviceHistoryForm_ClientIdNameStaticLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DeviceHistoryForm_ClientIdNameStaticLabel.Location = new System.Drawing.Point(14, 13);
            this.DeviceHistoryForm_ClientIdNameStaticLabel.Name = "DeviceHistoryForm_ClientIdNameStaticLabel";
            this.DeviceHistoryForm_ClientIdNameStaticLabel.Size = new System.Drawing.Size(185, 20);
            this.DeviceHistoryForm_ClientIdNameStaticLabel.TabIndex = 2;
            this.DeviceHistoryForm_ClientIdNameStaticLabel.Text = "ID | Imię i nazwisko klienta";
            // 
            // positionIdDataGridViewTextBoxColumn
            // 
            this.positionIdDataGridViewTextBoxColumn.DataPropertyName = "PositionId";
            this.positionIdDataGridViewTextBoxColumn.HeaderText = "PositionId";
            this.positionIdDataGridViewTextBoxColumn.Name = "positionIdDataGridViewTextBoxColumn";
            this.positionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Koszt";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDataGridViewTextBoxColumn1
            // 
            this.incomeDataGridViewTextBoxColumn1.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn1.HeaderText = "Przychód";
            this.incomeDataGridViewTextBoxColumn1.Name = "incomeDataGridViewTextBoxColumn1";
            this.incomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // repairPositionBindingSource
            // 
            this.repairPositionBindingSource.DataSource = typeof(Serwis.Models.RepairPosition);
            // 
            // repairIdDataGridViewTextBoxColumn
            // 
            this.repairIdDataGridViewTextBoxColumn.DataPropertyName = "RepairId";
            this.repairIdDataGridViewTextBoxColumn.HeaderText = "ID zlecenia";
            this.repairIdDataGridViewTextBoxColumn.Name = "repairIdDataGridViewTextBoxColumn";
            this.repairIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Data rozpoczęcia";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Data rozpoczęcia";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceDataGridViewTextBoxColumn
            // 
            this.deviceDataGridViewTextBoxColumn.DataPropertyName = "Device";
            this.deviceDataGridViewTextBoxColumn.HeaderText = "Device";
            this.deviceDataGridViewTextBoxColumn.Name = "deviceDataGridViewTextBoxColumn";
            this.deviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientDataGridViewTextBoxColumn.Visible = false;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Przychód";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataSource = typeof(Serwis.Models.Repair);
            // 
            // DeviceHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 489);
            this.Controls.Add(this.DeviceHistoryForm_SelectedRepairPanel);
            this.Controls.Add(this.DeviceHistoryForm_HistoryDataGrid);
            this.MaximizeBox = false;
            this.Name = "DeviceHistoryForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia urządzenia";
            ((System.ComponentModel.ISupportInitialize)(this.DeviceHistoryForm_HistoryDataGrid)).EndInit();
            this.DeviceHistoryForm_SelectedRepairPanel.ResumeLayout(false);
            this.DeviceHistoryForm_SelectedRepairPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceHistoryForm_SelectedRepairPositionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairPositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid DeviceHistoryForm_HistoryDataGrid;
        private MetroFramework.Controls.MetroPanel DeviceHistoryForm_SelectedRepairPanel;
        private MetroFramework.Controls.MetroGrid DeviceHistoryForm_SelectedRepairPositionsDataGrid;
        private MetroFramework.Controls.MetroLabel DeviceHistoryForm_ClientIdNameLabel;
        private MetroFramework.Controls.MetroLabel DeviceHistoryForm_ClientIdNameStaticLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource repairBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource repairPositionBindingSource;
    }
}