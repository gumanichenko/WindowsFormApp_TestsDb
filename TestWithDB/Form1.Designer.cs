namespace TestWithDB
{
    partial class Form1
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
            this.bSaveName = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pLogin = new System.Windows.Forms.Panel();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pAdmin = new System.Windows.Forms.Panel();
            this.bScoreTable = new System.Windows.Forms.Button();
            this.bAdminOff = new System.Windows.Forms.Button();
            this.bEditTest = new System.Windows.Forms.Button();
            this.bCheckAdmin = new System.Windows.Forms.Button();
            this.bReloadList = new System.Windows.Forms.Button();
            this.tbAdmin = new System.Windows.Forms.TextBox();
            this.bAdmin = new System.Windows.Forms.Button();
            this.lUserName = new System.Windows.Forms.Label();
            this.bEditName = new System.Windows.Forms.Button();
            this.bTest1 = new System.Windows.Forms.Button();
            this.pCenter = new System.Windows.Forms.Panel();
            this.lScore = new System.Windows.Forms.Label();
            this.lNameTest = new System.Windows.Forms.Label();
            this.lQuestion = new System.Windows.Forms.Label();
            this.bFinish = new System.Windows.Forms.Button();
            this.pTriggers = new System.Windows.Forms.Panel();
            this.rA = new System.Windows.Forms.RadioButton();
            this.rD = new System.Windows.Forms.RadioButton();
            this.rB = new System.Windows.Forms.RadioButton();
            this.rC = new System.Windows.Forms.RadioButton();
            this.bBack = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.tbQ4 = new System.Windows.Forms.TextBox();
            this.tbQ3 = new System.Windows.Forms.TextBox();
            this.tbQ2 = new System.Windows.Forms.TextBox();
            this.tbQ1 = new System.Windows.Forms.TextBox();
            this.rtbQuestionField = new System.Windows.Forms.RichTextBox();
            this.cbListTests = new System.Windows.Forms.ComboBox();
            this.pTestsMain = new System.Windows.Forms.Panel();
            this.pLogin.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.pAdmin.SuspendLayout();
            this.pCenter.SuspendLayout();
            this.pTriggers.SuspendLayout();
            this.pTestsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSaveName
            // 
            this.bSaveName.BackColor = System.Drawing.Color.PapayaWhip;
            this.bSaveName.Location = new System.Drawing.Point(298, 12);
            this.bSaveName.Name = "bSaveName";
            this.bSaveName.Size = new System.Drawing.Size(75, 23);
            this.bSaveName.TabIndex = 0;
            this.bSaveName.Text = "Save";
            this.bSaveName.UseVisualStyleBackColor = false;
            this.bSaveName.Click += new System.EventHandler(this.bSaveName_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(96, 14);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(196, 22);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your name:";
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.label1);
            this.pLogin.Controls.Add(this.bSaveName);
            this.pLogin.Controls.Add(this.tbUserName);
            this.pLogin.Location = new System.Drawing.Point(97, 2);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(471, 38);
            this.pLogin.TabIndex = 3;
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.pAdmin);
            this.pLeft.Controls.Add(this.bAdmin);
            this.pLeft.Controls.Add(this.lUserName);
            this.pLeft.Controls.Add(this.bEditName);
            this.pLeft.Location = new System.Drawing.Point(2, 2);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(92, 383);
            this.pLeft.TabIndex = 4;
            // 
            // pAdmin
            // 
            this.pAdmin.Controls.Add(this.bScoreTable);
            this.pAdmin.Controls.Add(this.bAdminOff);
            this.pAdmin.Controls.Add(this.bEditTest);
            this.pAdmin.Controls.Add(this.bCheckAdmin);
            this.pAdmin.Controls.Add(this.bReloadList);
            this.pAdmin.Controls.Add(this.tbAdmin);
            this.pAdmin.Location = new System.Drawing.Point(3, 130);
            this.pAdmin.Name = "pAdmin";
            this.pAdmin.Size = new System.Drawing.Size(86, 247);
            this.pAdmin.TabIndex = 6;
            this.pAdmin.Visible = false;
            // 
            // bScoreTable
            // 
            this.bScoreTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bScoreTable.Location = new System.Drawing.Point(8, 72);
            this.bScoreTable.Name = "bScoreTable";
            this.bScoreTable.Size = new System.Drawing.Size(75, 42);
            this.bScoreTable.TabIndex = 6;
            this.bScoreTable.Text = "Score Table";
            this.bScoreTable.UseVisualStyleBackColor = false;
            this.bScoreTable.Visible = false;
            this.bScoreTable.Click += new System.EventHandler(this.bScoreTable_Click);
            // 
            // bAdminOff
            // 
            this.bAdminOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bAdminOff.Location = new System.Drawing.Point(8, 219);
            this.bAdminOff.Name = "bAdminOff";
            this.bAdminOff.Size = new System.Drawing.Size(75, 23);
            this.bAdminOff.TabIndex = 5;
            this.bAdminOff.Text = "Admin Off";
            this.bAdminOff.UseVisualStyleBackColor = false;
            this.bAdminOff.Visible = false;
            this.bAdminOff.Click += new System.EventHandler(this.bAdminOff_Click);
            // 
            // bEditTest
            // 
            this.bEditTest.BackColor = System.Drawing.Color.LightPink;
            this.bEditTest.Location = new System.Drawing.Point(8, 120);
            this.bEditTest.Name = "bEditTest";
            this.bEditTest.Size = new System.Drawing.Size(75, 48);
            this.bEditTest.TabIndex = 2;
            this.bEditTest.Text = "Edit Test";
            this.bEditTest.UseVisualStyleBackColor = false;
            this.bEditTest.Visible = false;
            this.bEditTest.Click += new System.EventHandler(this.bSelectTest_Click);
            // 
            // bCheckAdmin
            // 
            this.bCheckAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bCheckAdmin.Location = new System.Drawing.Point(8, 43);
            this.bCheckAdmin.Name = "bCheckAdmin";
            this.bCheckAdmin.Size = new System.Drawing.Size(75, 23);
            this.bCheckAdmin.TabIndex = 1;
            this.bCheckAdmin.Text = "Go";
            this.bCheckAdmin.UseVisualStyleBackColor = false;
            this.bCheckAdmin.Click += new System.EventHandler(this.bCheckAdmin_Click);
            // 
            // bReloadList
            // 
            this.bReloadList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bReloadList.Location = new System.Drawing.Point(10, 172);
            this.bReloadList.Name = "bReloadList";
            this.bReloadList.Size = new System.Drawing.Size(72, 46);
            this.bReloadList.TabIndex = 4;
            this.bReloadList.Text = "Reload List";
            this.bReloadList.UseVisualStyleBackColor = false;
            this.bReloadList.Visible = false;
            this.bReloadList.Click += new System.EventHandler(this.bReloadList_Click);
            // 
            // tbAdmin
            // 
            this.tbAdmin.Location = new System.Drawing.Point(7, 17);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.Size = new System.Drawing.Size(75, 20);
            this.tbAdmin.TabIndex = 0;
            // 
            // bAdmin
            // 
            this.bAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bAdmin.Location = new System.Drawing.Point(10, 88);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(75, 41);
            this.bAdmin.TabIndex = 5;
            this.bAdmin.Text = "Admin Panel";
            this.bAdmin.UseVisualStyleBackColor = false;
            this.bAdmin.Click += new System.EventHandler(this.bAdmin_Click);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(10, 12);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(35, 13);
            this.lUserName.TabIndex = 3;
            this.lUserName.Text = "Name";
            // 
            // bEditName
            // 
            this.bEditName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bEditName.Location = new System.Drawing.Point(10, 40);
            this.bEditName.Name = "bEditName";
            this.bEditName.Size = new System.Drawing.Size(75, 42);
            this.bEditName.TabIndex = 1;
            this.bEditName.Text = "Edit Name";
            this.bEditName.UseVisualStyleBackColor = false;
            this.bEditName.Click += new System.EventHandler(this.bEditName_Click);
            // 
            // bTest1
            // 
            this.bTest1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bTest1.Location = new System.Drawing.Point(364, 3);
            this.bTest1.Name = "bTest1";
            this.bTest1.Size = new System.Drawing.Size(94, 21);
            this.bTest1.TabIndex = 0;
            this.bTest1.Text = "Start Test";
            this.bTest1.UseVisualStyleBackColor = false;
            this.bTest1.Click += new System.EventHandler(this.bTest1_Click);
            // 
            // pCenter
            // 
            this.pCenter.Controls.Add(this.lScore);
            this.pCenter.Controls.Add(this.lNameTest);
            this.pCenter.Controls.Add(this.lQuestion);
            this.pCenter.Controls.Add(this.bFinish);
            this.pCenter.Controls.Add(this.pTriggers);
            this.pCenter.Controls.Add(this.bBack);
            this.pCenter.Controls.Add(this.bNext);
            this.pCenter.Controls.Add(this.tbQ4);
            this.pCenter.Controls.Add(this.tbQ3);
            this.pCenter.Controls.Add(this.tbQ2);
            this.pCenter.Controls.Add(this.tbQ1);
            this.pCenter.Controls.Add(this.rtbQuestionField);
            this.pCenter.Location = new System.Drawing.Point(97, 42);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(471, 343);
            this.pCenter.TabIndex = 5;
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Location = new System.Drawing.Point(6, 320);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(38, 13);
            this.lScore.TabIndex = 15;
            this.lScore.Text = "Score:";
            // 
            // lNameTest
            // 
            this.lNameTest.AutoSize = true;
            this.lNameTest.Location = new System.Drawing.Point(6, 294);
            this.lNameTest.Name = "lNameTest";
            this.lNameTest.Size = new System.Drawing.Size(34, 13);
            this.lNameTest.TabIndex = 16;
            this.lNameTest.Text = "Test: ";
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(6, 307);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(52, 13);
            this.lQuestion.TabIndex = 14;
            this.lQuestion.Text = "Question:";
            // 
            // bFinish
            // 
            this.bFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bFinish.Location = new System.Drawing.Point(415, 274);
            this.bFinish.Name = "bFinish";
            this.bFinish.Size = new System.Drawing.Size(49, 23);
            this.bFinish.TabIndex = 12;
            this.bFinish.Text = "Finish";
            this.bFinish.UseVisualStyleBackColor = false;
            this.bFinish.Visible = false;
            this.bFinish.Click += new System.EventHandler(this.bFinish_Click);
            // 
            // pTriggers
            // 
            this.pTriggers.Controls.Add(this.rA);
            this.pTriggers.Controls.Add(this.rD);
            this.pTriggers.Controls.Add(this.rB);
            this.pTriggers.Controls.Add(this.rC);
            this.pTriggers.Location = new System.Drawing.Point(415, 120);
            this.pTriggers.Name = "pTriggers";
            this.pTriggers.Size = new System.Drawing.Size(49, 108);
            this.pTriggers.TabIndex = 11;
            // 
            // rA
            // 
            this.rA.AutoSize = true;
            this.rA.Location = new System.Drawing.Point(3, 11);
            this.rA.Name = "rA";
            this.rA.Size = new System.Drawing.Size(32, 17);
            this.rA.TabIndex = 7;
            this.rA.TabStop = true;
            this.rA.Text = "A";
            this.rA.UseVisualStyleBackColor = true;
            // 
            // rD
            // 
            this.rD.AutoSize = true;
            this.rD.Location = new System.Drawing.Point(3, 89);
            this.rD.Name = "rD";
            this.rD.Size = new System.Drawing.Size(33, 17);
            this.rD.TabIndex = 10;
            this.rD.TabStop = true;
            this.rD.Text = "D";
            this.rD.UseVisualStyleBackColor = true;
            // 
            // rB
            // 
            this.rB.AutoSize = true;
            this.rB.Location = new System.Drawing.Point(3, 37);
            this.rB.Name = "rB";
            this.rB.Size = new System.Drawing.Size(32, 17);
            this.rB.TabIndex = 8;
            this.rB.TabStop = true;
            this.rB.Text = "B";
            this.rB.UseVisualStyleBackColor = true;
            // 
            // rC
            // 
            this.rC.AutoSize = true;
            this.rC.Location = new System.Drawing.Point(3, 63);
            this.rC.Name = "rC";
            this.rC.Size = new System.Drawing.Size(32, 17);
            this.rC.TabIndex = 9;
            this.rC.TabStop = true;
            this.rC.Text = "C";
            this.rC.UseVisualStyleBackColor = true;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.Khaki;
            this.bBack.Location = new System.Drawing.Point(6, 234);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(198, 35);
            this.bBack.TabIndex = 6;
            this.bBack.Text = "BACK";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Visible = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bNext
            // 
            this.bNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bNext.Location = new System.Drawing.Point(266, 232);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(198, 36);
            this.bNext.TabIndex = 5;
            this.bNext.Text = "NEXT";
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // tbQ4
            // 
            this.tbQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQ4.Location = new System.Drawing.Point(6, 208);
            this.tbQ4.Name = "tbQ4";
            this.tbQ4.Size = new System.Drawing.Size(390, 22);
            this.tbQ4.TabIndex = 4;
            // 
            // tbQ3
            // 
            this.tbQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQ3.Location = new System.Drawing.Point(6, 182);
            this.tbQ3.Name = "tbQ3";
            this.tbQ3.Size = new System.Drawing.Size(390, 22);
            this.tbQ3.TabIndex = 3;
            // 
            // tbQ2
            // 
            this.tbQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQ2.Location = new System.Drawing.Point(6, 156);
            this.tbQ2.Name = "tbQ2";
            this.tbQ2.Size = new System.Drawing.Size(390, 22);
            this.tbQ2.TabIndex = 2;
            // 
            // tbQ1
            // 
            this.tbQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQ1.Location = new System.Drawing.Point(6, 130);
            this.tbQ1.Name = "tbQ1";
            this.tbQ1.Size = new System.Drawing.Size(390, 22);
            this.tbQ1.TabIndex = 1;
            // 
            // rtbQuestionField
            // 
            this.rtbQuestionField.Enabled = false;
            this.rtbQuestionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQuestionField.Location = new System.Drawing.Point(6, 4);
            this.rtbQuestionField.Name = "rtbQuestionField";
            this.rtbQuestionField.Size = new System.Drawing.Size(458, 119);
            this.rtbQuestionField.TabIndex = 0;
            this.rtbQuestionField.Text = "";
            // 
            // cbListTests
            // 
            this.cbListTests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListTests.FormattingEnabled = true;
            this.cbListTests.Location = new System.Drawing.Point(3, 3);
            this.cbListTests.Name = "cbListTests";
            this.cbListTests.Size = new System.Drawing.Size(355, 21);
            this.cbListTests.TabIndex = 17;
            // 
            // pTestsMain
            // 
            this.pTestsMain.Controls.Add(this.cbListTests);
            this.pTestsMain.Controls.Add(this.bTest1);
            this.pTestsMain.Location = new System.Drawing.Point(103, 9);
            this.pTestsMain.Name = "pTestsMain";
            this.pTestsMain.Size = new System.Drawing.Size(465, 27);
            this.pTestsMain.TabIndex = 18;
            this.pTestsMain.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(574, 391);
            this.Controls.Add(this.pTestsMain);
            this.Controls.Add(this.pCenter);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.pLeft);
            this.Name = "Form1";
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            this.pAdmin.ResumeLayout(false);
            this.pAdmin.PerformLayout();
            this.pCenter.ResumeLayout(false);
            this.pCenter.PerformLayout();
            this.pTriggers.ResumeLayout(false);
            this.pTriggers.PerformLayout();
            this.pTestsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSaveName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pCenter;
        private System.Windows.Forms.Button bTest1;
        private System.Windows.Forms.RichTextBox rtbQuestionField;
        private System.Windows.Forms.TextBox tbQ4;
        private System.Windows.Forms.TextBox tbQ3;
        private System.Windows.Forms.TextBox tbQ2;
        private System.Windows.Forms.TextBox tbQ1;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Panel pTriggers;
        private System.Windows.Forms.RadioButton rA;
        private System.Windows.Forms.RadioButton rD;
        private System.Windows.Forms.RadioButton rB;
        private System.Windows.Forms.RadioButton rC;
        private System.Windows.Forms.Button bFinish;
       
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Button bEditName;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lNameTest;
        private System.Windows.Forms.Panel pTestsMain;
        private System.Windows.Forms.Label lUserName;
        public System.Windows.Forms.ComboBox cbListTests;
        private System.Windows.Forms.Button bReloadList;
        private System.Windows.Forms.Button bAdmin;
        private System.Windows.Forms.Panel pAdmin;
        private System.Windows.Forms.TextBox tbAdmin;
        private System.Windows.Forms.Button bCheckAdmin;
        private System.Windows.Forms.Button bEditTest;
        private System.Windows.Forms.Button bAdminOff;
        private System.Windows.Forms.Button bScoreTable;
    }
}

