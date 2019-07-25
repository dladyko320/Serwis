namespace Serwis
{
    partial class InfoForm
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
            this.InfoForm_InfoLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // InfoForm_InfoLabel
            // 
            this.InfoForm_InfoLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.InfoForm_InfoLabel.Location = new System.Drawing.Point(41, 9);
            this.InfoForm_InfoLabel.Name = "InfoForm_InfoLabel";
            this.InfoForm_InfoLabel.Size = new System.Drawing.Size(234, 95);
            this.InfoForm_InfoLabel.TabIndex = 0;
            this.InfoForm_InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoForm_InfoLabel.WrapToLine = true;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 132);
            this.Controls.Add(this.InfoForm_InfoLabel);
            this.MaximizeBox = false;
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacje";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel InfoForm_InfoLabel;
    }
}