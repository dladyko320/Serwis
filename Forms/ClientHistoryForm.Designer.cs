namespace Serwis
{
    partial class ClientHistoryForm
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
            this.ClientHistoryForm_SelectedRepairPanel = new MetroFramework.Controls.MetroPanel();
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid = new MetroFramework.Controls.MetroGrid();
            this.ClientHistoryForm_DeviceIdNameLabel = new MetroFramework.Controls.MetroLabel();
            this.ClientHistoryForm_DeviceIdNameStaticLabel = new MetroFramework.Controls.MetroLabel();
            this.ClientHistoryForm_HistoryDataGrid = new MetroFramework.Controls.MetroGrid();
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientHistoryForm_SelectedRepairPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientHistoryForm_SelectedRepairPositionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientHistoryForm_HistoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairPositionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientHistoryForm_SelectedRepairPanel
            // 
            this.ClientHistoryForm_SelectedRepairPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientHistoryForm_SelectedRepairPanel.Controls.Add(this.ClientHistoryForm_SelectedRepairPositionsDataGrid);
            this.ClientHistoryForm_SelectedRepairPanel.Controls.Add(this.ClientHistoryForm_DeviceIdNameLabel);
            this.ClientHistoryForm_SelectedRepairPanel.Controls.Add(this.ClientHistoryForm_DeviceIdNameStaticLabel);
            this.ClientHistoryForm_SelectedRepairPanel.HorizontalScrollbarBarColor = true;
            this.ClientHistoryForm_SelectedRepairPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ClientHistoryForm_SelectedRepairPanel.HorizontalScrollbarSize = 10;
            this.ClientHistoryForm_SelectedRepairPanel.Location = new System.Drawing.Point(12, 275);
            this.ClientHistoryForm_SelectedRepairPanel.Name = "ClientHistoryForm_SelectedRepairPanel";
            this.ClientHistoryForm_SelectedRepairPanel.Size = new System.Drawing.Size(776, 200);
            this.ClientHistoryForm_SelectedRepairPanel.TabIndex = 13;
            this.ClientHistoryForm_SelectedRepairPanel.VerticalScrollbarBarColor = true;
            this.ClientHistoryForm_SelectedRepairPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ClientHistoryForm_SelectedRepairPanel.VerticalScrollbarSize = 10;
            // 
            // ClientHistoryForm_SelectedRepairPositionsDataGrid
            // 
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.AllowUserToAddRows = false;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.AllowUserToDeleteRows = false;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.AllowUserToOrderColumns = true;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.AllowUserToResizeRows = false;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.AutoGenerateColumns = false;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn1});
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.DataSource = this.repairPositionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.EnableHeadersVisualStyles = false;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.Location = new System.Drawing.Point(3, 81);
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.Name = "ClientHistoryForm_SelectedRepairPositionsDataGrid";
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.ReadOnly = true;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.RowTemplate.Height = 24;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.Size = new System.Drawing.Size(768, 114);
            this.ClientHistoryForm_SelectedRepairPositionsDataGrid.TabIndex = 8;
            // 
            // ClientHistoryForm_DeviceIdNameLabel
            // 
            this.ClientHistoryForm_DeviceIdNameLabel.Location = new System.Drawing.Point(14, 33);
            this.ClientHistoryForm_DeviceIdNameLabel.Name = "ClientHistoryForm_DeviceIdNameLabel";
            this.ClientHistoryForm_DeviceIdNameLabel.Size = new System.Drawing.Size(170, 45);
            this.ClientHistoryForm_DeviceIdNameLabel.TabIndex = 5;
            this.ClientHistoryForm_DeviceIdNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClientHistoryForm_DeviceIdNameLabel.WrapToLine = true;
            // 
            // ClientHistoryForm_DeviceIdNameStaticLabel
            // 
            this.ClientHistoryForm_DeviceIdNameStaticLabel.AutoSize = true;
            this.ClientHistoryForm_DeviceIdNameStaticLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ClientHistoryForm_DeviceIdNameStaticLabel.Location = new System.Drawing.Point(14, 13);
            this.ClientHistoryForm_DeviceIdNameStaticLabel.Name = "ClientHistoryForm_DeviceIdNameStaticLabel";
            this.ClientHistoryForm_DeviceIdNameStaticLabel.Size = new System.Drawing.Size(157, 20);
            this.ClientHistoryForm_DeviceIdNameStaticLabel.TabIndex = 2;
            this.ClientHistoryForm_DeviceIdNameStaticLabel.Text = "ID | Nazwa urządzenia";
            // 
            // ClientHistoryForm_HistoryDataGrid
            // 
            this.ClientHistoryForm_HistoryDataGrid.AllowUserToAddRows = false;
            this.ClientHistoryForm_HistoryDataGrid.AllowUserToDeleteRows = false;
            this.ClientHistoryForm_HistoryDataGrid.AllowUserToOrderColumns = true;
            this.ClientHistoryForm_HistoryDataGrid.AllowUserToResizeRows = false;
            this.ClientHistoryForm_HistoryDataGrid.AutoGenerateColumns = false;
            this.ClientHistoryForm_HistoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientHistoryForm_HistoryDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientHistoryForm_HistoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientHistoryForm_HistoryDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientHistoryForm_HistoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientHistoryForm_HistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClientHistoryForm_HistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientHistoryForm_HistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairIdDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.deviceDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn});
            this.ClientHistoryForm_HistoryDataGrid.DataSource = this.repairBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientHistoryForm_HistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClientHistoryForm_HistoryDataGrid.EnableHeadersVisualStyles = false;
            this.ClientHistoryForm_HistoryDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientHistoryForm_HistoryDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientHistoryForm_HistoryDataGrid.Location = new System.Drawing.Point(12, 12);
            this.ClientHistoryForm_HistoryDataGrid.Name = "ClientHistoryForm_HistoryDataGrid";
            this.ClientHistoryForm_HistoryDataGrid.ReadOnly = true;
            this.ClientHistoryForm_HistoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientHistoryForm_HistoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ClientHistoryForm_HistoryDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClientHistoryForm_HistoryDataGrid.RowTemplate.Height = 24;
            this.ClientHistoryForm_HistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientHistoryForm_HistoryDataGrid.Size = new System.Drawing.Size(776, 257);
            this.ClientHistoryForm_HistoryDataGrid.TabIndex = 12;
            this.ClientHistoryForm_HistoryDataGrid.SelectionChanged += new System.EventHandler(this.ClientHistoryForm_HistoryDataGrid_SelectionChanged);
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataSource = typeof(Serwis.Models.Repair);
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
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Data zakończenia";
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
            // repairPositionBindingSource
            // 
            this.repairPositionBindingSource.DataSource = typeof(Serwis.Models.RepairPosition);
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
            // ClientHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 488);
            this.Controls.Add(this.ClientHistoryForm_SelectedRepairPanel);
            this.Controls.Add(this.ClientHistoryForm_HistoryDataGrid);
            this.MaximizeBox = false;
            this.Name = "ClientHistoryForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia klienta";
            this.ClientHistoryForm_SelectedRepairPanel.ResumeLayout(false);
            this.ClientHistoryForm_SelectedRepairPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientHistoryForm_SelectedRepairPositionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientHistoryForm_HistoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairPositionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel ClientHistoryForm_SelectedRepairPanel;
        private MetroFramework.Controls.MetroGrid ClientHistoryForm_SelectedRepairPositionsDataGrid;
        private MetroFramework.Controls.MetroLabel ClientHistoryForm_DeviceIdNameLabel;
        private MetroFramework.Controls.MetroLabel ClientHistoryForm_DeviceIdNameStaticLabel;
        private MetroFramework.Controls.MetroGrid ClientHistoryForm_HistoryDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource repairPositionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource repairBindingSource;
    }
}