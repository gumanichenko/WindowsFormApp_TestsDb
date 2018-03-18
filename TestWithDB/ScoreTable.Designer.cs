namespace TestWithDB
{
    partial class ScoreTable
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
            this.dgvScoreTable = new System.Windows.Forms.DataGridView();
            this.bShowCorrect = new System.Windows.Forms.Button();
            this.bAll = new System.Windows.Forms.Button();
            this.bUncorrect = new System.Windows.Forms.Button();
            this.lInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScoreTable
            // 
            this.dgvScoreTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScoreTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvScoreTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvScoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoreTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvScoreTable.GridColor = System.Drawing.Color.White;
            this.dgvScoreTable.Location = new System.Drawing.Point(12, 92);
            this.dgvScoreTable.Name = "dgvScoreTable";
            this.dgvScoreTable.Size = new System.Drawing.Size(760, 457);
            this.dgvScoreTable.TabIndex = 0;
            // 
            // bShowCorrect
            // 
            this.bShowCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bShowCorrect.Location = new System.Drawing.Point(16, 12);
            this.bShowCorrect.Name = "bShowCorrect";
            this.bShowCorrect.Size = new System.Drawing.Size(216, 49);
            this.bShowCorrect.TabIndex = 1;
            this.bShowCorrect.Text = "Show Correct";
            this.bShowCorrect.UseVisualStyleBackColor = false;
            this.bShowCorrect.Click += new System.EventHandler(this.bShowCorrect_Click);
            // 
            // bAll
            // 
            this.bAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bAll.Location = new System.Drawing.Point(283, 12);
            this.bAll.Name = "bAll";
            this.bAll.Size = new System.Drawing.Size(216, 49);
            this.bAll.TabIndex = 2;
            this.bAll.Text = "Show All";
            this.bAll.UseVisualStyleBackColor = false;
            this.bAll.Click += new System.EventHandler(this.bAll_Click);
            // 
            // bUncorrect
            // 
            this.bUncorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bUncorrect.Location = new System.Drawing.Point(556, 12);
            this.bUncorrect.Name = "bUncorrect";
            this.bUncorrect.Size = new System.Drawing.Size(216, 49);
            this.bUncorrect.TabIndex = 3;
            this.bUncorrect.Text = "Show Uncorrect";
            this.bUncorrect.UseVisualStyleBackColor = false;
            this.bUncorrect.Click += new System.EventHandler(this.bUncorrect_Click);
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInfo.Location = new System.Drawing.Point(12, 64);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(37, 20);
            this.lInfo.TabIndex = 4;
            this.lInfo.Text = "Info";
            // 
            // ScoreTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.bUncorrect);
            this.Controls.Add(this.bAll);
            this.Controls.Add(this.bShowCorrect);
            this.Controls.Add(this.dgvScoreTable);
            this.Name = "ScoreTable";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.ScoreTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScoreTable;
        private System.Windows.Forms.Button bShowCorrect;
        private System.Windows.Forms.Button bAll;
        private System.Windows.Forms.Button bUncorrect;
        private System.Windows.Forms.Label lInfo;
    }
}