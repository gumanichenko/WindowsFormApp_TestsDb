namespace TestWithDB
{
    partial class AdminTable
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
            this.dgvAdminGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminGrid
            // 
            this.dgvAdminGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminGrid.GridColor = System.Drawing.Color.White;
            this.dgvAdminGrid.Location = new System.Drawing.Point(12, 12);
            this.dgvAdminGrid.Name = "dgvAdminGrid";
            this.dgvAdminGrid.Size = new System.Drawing.Size(698, 425);
            this.dgvAdminGrid.TabIndex = 0;
            // 
            // AdminTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 449);
            this.Controls.Add(this.dgvAdminGrid);
            this.Name = "AdminTable";
            this.Text = "AdminTable";
            this.Load += new System.EventHandler(this.AdminTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvAdminGrid;
    }
}