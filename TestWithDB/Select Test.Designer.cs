namespace TestWithDB
{
    partial class Select_Test
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
            this.cbListTests = new System.Windows.Forms.ComboBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.pEdit = new System.Windows.Forms.Panel();
            this.bSaveNewName = new System.Windows.Forms.Button();
            this.bRename = new System.Windows.Forms.Button();
            this.tbNameOfTest = new System.Windows.Forms.TextBox();
            this.pNewTest = new System.Windows.Forms.Panel();
            this.bSaveTestName = new System.Windows.Forms.Button();
            this.tbNewNameTest = new System.Windows.Forms.TextBox();
            this.lCreateNewTest = new System.Windows.Forms.Label();
            this.bCreateNewTest = new System.Windows.Forms.Button();
            this.bDeleteTest = new System.Windows.Forms.Button();
            this.bEditQuestion = new System.Windows.Forms.Button();
            this.pAddQuestion = new System.Windows.Forms.Panel();
            this.lQuestion = new System.Windows.Forms.Label();
            this.lInfo = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.rbDD = new System.Windows.Forms.RadioButton();
            this.rbCC = new System.Windows.Forms.RadioButton();
            this.rbBB = new System.Windows.Forms.RadioButton();
            this.rbAA = new System.Windows.Forms.RadioButton();
            this.tbAnsw4 = new System.Windows.Forms.TextBox();
            this.tbAnsw3 = new System.Windows.Forms.TextBox();
            this.tbAnsw2 = new System.Windows.Forms.TextBox();
            this.tbAnsw1 = new System.Windows.Forms.TextBox();
            this.rtbAddQuestion = new System.Windows.Forms.RichTextBox();
            this.bAddQuestion = new System.Windows.Forms.Button();
            this.bDeleteQuestion = new System.Windows.Forms.Button();
            this.bAddQue = new System.Windows.Forms.Button();
            this.bEditThisQuestion = new System.Windows.Forms.Button();
            this.bSaveEdit = new System.Windows.Forms.Button();
            this.pEdit.SuspendLayout();
            this.pNewTest.SuspendLayout();
            this.pAddQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbListTests
            // 
            this.cbListTests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListTests.FormattingEnabled = true;
            this.cbListTests.Location = new System.Drawing.Point(12, 12);
            this.cbListTests.Name = "cbListTests";
            this.cbListTests.Size = new System.Drawing.Size(444, 21);
            this.cbListTests.TabIndex = 0;
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.PaleGreen;
            this.bClose.Location = new System.Drawing.Point(462, 412);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(105, 23);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Back";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bGo_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bEdit.Location = new System.Drawing.Point(12, 39);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(80, 28);
            this.bEdit.TabIndex = 2;
            this.bEdit.Text = "Rename test";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // pEdit
            // 
            this.pEdit.Controls.Add(this.bSaveNewName);
            this.pEdit.Controls.Add(this.bRename);
            this.pEdit.Controls.Add(this.tbNameOfTest);
            this.pEdit.Location = new System.Drawing.Point(98, 39);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(462, 28);
            this.pEdit.TabIndex = 3;
            this.pEdit.Visible = false;
            // 
            // bSaveNewName
            // 
            this.bSaveNewName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bSaveNewName.Location = new System.Drawing.Point(364, 5);
            this.bSaveNewName.Name = "bSaveNewName";
            this.bSaveNewName.Size = new System.Drawing.Size(95, 20);
            this.bSaveNewName.TabIndex = 2;
            this.bSaveNewName.Text = "Save";
            this.bSaveNewName.UseVisualStyleBackColor = false;
            this.bSaveNewName.Visible = false;
            this.bSaveNewName.Click += new System.EventHandler(this.bSaveNewName_Click);
            // 
            // bRename
            // 
            this.bRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bRename.Location = new System.Drawing.Point(260, 5);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(98, 20);
            this.bRename.TabIndex = 1;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = false;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // tbNameOfTest
            // 
            this.tbNameOfTest.Enabled = false;
            this.tbNameOfTest.Location = new System.Drawing.Point(3, 4);
            this.tbNameOfTest.Name = "tbNameOfTest";
            this.tbNameOfTest.Size = new System.Drawing.Size(251, 20);
            this.tbNameOfTest.TabIndex = 0;
            // 
            // pNewTest
            // 
            this.pNewTest.Controls.Add(this.bSaveTestName);
            this.pNewTest.Controls.Add(this.tbNewNameTest);
            this.pNewTest.Controls.Add(this.lCreateNewTest);
            this.pNewTest.Location = new System.Drawing.Point(98, 69);
            this.pNewTest.Name = "pNewTest";
            this.pNewTest.Size = new System.Drawing.Size(462, 28);
            this.pNewTest.TabIndex = 4;
            this.pNewTest.Visible = false;
            // 
            // bSaveTestName
            // 
            this.bSaveTestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bSaveTestName.Location = new System.Drawing.Point(364, 3);
            this.bSaveTestName.Name = "bSaveTestName";
            this.bSaveTestName.Size = new System.Drawing.Size(95, 21);
            this.bSaveTestName.TabIndex = 2;
            this.bSaveTestName.Text = "Save Test";
            this.bSaveTestName.UseVisualStyleBackColor = false;
            this.bSaveTestName.Click += new System.EventHandler(this.bSaveTestName_Click);
            // 
            // tbNewNameTest
            // 
            this.tbNewNameTest.Location = new System.Drawing.Point(108, 3);
            this.tbNewNameTest.Name = "tbNewNameTest";
            this.tbNewNameTest.Size = new System.Drawing.Size(250, 20);
            this.tbNewNameTest.TabIndex = 1;
            // 
            // lCreateNewTest
            // 
            this.lCreateNewTest.AutoSize = true;
            this.lCreateNewTest.Location = new System.Drawing.Point(3, 6);
            this.lCreateNewTest.Name = "lCreateNewTest";
            this.lCreateNewTest.Size = new System.Drawing.Size(110, 13);
            this.lCreateNewTest.TabIndex = 0;
            this.lCreateNewTest.Text = "Enter new test name: ";
            // 
            // bCreateNewTest
            // 
            this.bCreateNewTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bCreateNewTest.Location = new System.Drawing.Point(12, 72);
            this.bCreateNewTest.Name = "bCreateNewTest";
            this.bCreateNewTest.Size = new System.Drawing.Size(80, 23);
            this.bCreateNewTest.TabIndex = 5;
            this.bCreateNewTest.Text = "New Test";
            this.bCreateNewTest.UseVisualStyleBackColor = false;
            this.bCreateNewTest.Click += new System.EventHandler(this.bCreateNewTest_Click);
            // 
            // bDeleteTest
            // 
            this.bDeleteTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bDeleteTest.Location = new System.Drawing.Point(462, 11);
            this.bDeleteTest.Name = "bDeleteTest";
            this.bDeleteTest.Size = new System.Drawing.Size(98, 22);
            this.bDeleteTest.TabIndex = 6;
            this.bDeleteTest.Text = "Delete Test";
            this.bDeleteTest.UseVisualStyleBackColor = false;
            this.bDeleteTest.Click += new System.EventHandler(this.bDeleteTest_Click);
            // 
            // bEditQuestion
            // 
            this.bEditQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bEditQuestion.Location = new System.Drawing.Point(12, 149);
            this.bEditQuestion.Name = "bEditQuestion";
            this.bEditQuestion.Size = new System.Drawing.Size(89, 40);
            this.bEditQuestion.TabIndex = 7;
            this.bEditQuestion.Text = "Show Question";
            this.bEditQuestion.UseVisualStyleBackColor = false;
            this.bEditQuestion.Click += new System.EventHandler(this.bEditQuestion_Click);
            // 
            // pAddQuestion
            // 
            this.pAddQuestion.Controls.Add(this.lQuestion);
            this.pAddQuestion.Controls.Add(this.lInfo);
            this.pAddQuestion.Controls.Add(this.bBack);
            this.pAddQuestion.Controls.Add(this.bNext);
            this.pAddQuestion.Controls.Add(this.rbDD);
            this.pAddQuestion.Controls.Add(this.rbCC);
            this.pAddQuestion.Controls.Add(this.rbBB);
            this.pAddQuestion.Controls.Add(this.rbAA);
            this.pAddQuestion.Controls.Add(this.tbAnsw4);
            this.pAddQuestion.Controls.Add(this.tbAnsw3);
            this.pAddQuestion.Controls.Add(this.tbAnsw2);
            this.pAddQuestion.Controls.Add(this.tbAnsw1);
            this.pAddQuestion.Controls.Add(this.rtbAddQuestion);
            this.pAddQuestion.Location = new System.Drawing.Point(101, 149);
            this.pAddQuestion.Name = "pAddQuestion";
            this.pAddQuestion.Size = new System.Drawing.Size(459, 233);
            this.pAddQuestion.TabIndex = 8;
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(340, 220);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(49, 13);
            this.lQuestion.TabIndex = 13;
            this.lQuestion.Text = "Question";
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(3, 220);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(25, 13);
            this.lInfo.TabIndex = 12;
            this.lInfo.Text = "Info";
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bBack.Location = new System.Drawing.Point(105, 192);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(110, 23);
            this.bBack.TabIndex = 11;
            this.bBack.Text = "<";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bNext
            // 
            this.bNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bNext.Location = new System.Drawing.Point(221, 192);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(110, 23);
            this.bNext.TabIndex = 10;
            this.bNext.Text = ">";
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // rbDD
            // 
            this.rbDD.AutoSize = true;
            this.rbDD.Location = new System.Drawing.Point(424, 167);
            this.rbDD.Name = "rbDD";
            this.rbDD.Size = new System.Drawing.Size(33, 17);
            this.rbDD.TabIndex = 9;
            this.rbDD.TabStop = true;
            this.rbDD.Text = "D";
            this.rbDD.UseVisualStyleBackColor = true;
            // 
            // rbCC
            // 
            this.rbCC.AutoSize = true;
            this.rbCC.Location = new System.Drawing.Point(424, 141);
            this.rbCC.Name = "rbCC";
            this.rbCC.Size = new System.Drawing.Size(32, 17);
            this.rbCC.TabIndex = 8;
            this.rbCC.TabStop = true;
            this.rbCC.Text = "C";
            this.rbCC.UseVisualStyleBackColor = true;
            // 
            // rbBB
            // 
            this.rbBB.AutoSize = true;
            this.rbBB.Location = new System.Drawing.Point(424, 115);
            this.rbBB.Name = "rbBB";
            this.rbBB.Size = new System.Drawing.Size(32, 17);
            this.rbBB.TabIndex = 7;
            this.rbBB.TabStop = true;
            this.rbBB.Text = "B";
            this.rbBB.UseVisualStyleBackColor = true;
            // 
            // rbAA
            // 
            this.rbAA.AutoSize = true;
            this.rbAA.Location = new System.Drawing.Point(424, 89);
            this.rbAA.Name = "rbAA";
            this.rbAA.Size = new System.Drawing.Size(32, 17);
            this.rbAA.TabIndex = 6;
            this.rbAA.TabStop = true;
            this.rbAA.Text = "A";
            this.rbAA.UseVisualStyleBackColor = true;
            // 
            // tbAnsw4
            // 
            this.tbAnsw4.Location = new System.Drawing.Point(6, 166);
            this.tbAnsw4.Name = "tbAnsw4";
            this.tbAnsw4.Size = new System.Drawing.Size(412, 20);
            this.tbAnsw4.TabIndex = 4;
            // 
            // tbAnsw3
            // 
            this.tbAnsw3.Location = new System.Drawing.Point(6, 140);
            this.tbAnsw3.Name = "tbAnsw3";
            this.tbAnsw3.Size = new System.Drawing.Size(412, 20);
            this.tbAnsw3.TabIndex = 3;
            // 
            // tbAnsw2
            // 
            this.tbAnsw2.Location = new System.Drawing.Point(6, 114);
            this.tbAnsw2.Name = "tbAnsw2";
            this.tbAnsw2.Size = new System.Drawing.Size(412, 20);
            this.tbAnsw2.TabIndex = 2;
            // 
            // tbAnsw1
            // 
            this.tbAnsw1.Location = new System.Drawing.Point(6, 88);
            this.tbAnsw1.Name = "tbAnsw1";
            this.tbAnsw1.Size = new System.Drawing.Size(412, 20);
            this.tbAnsw1.TabIndex = 1;
            // 
            // rtbAddQuestion
            // 
            this.rtbAddQuestion.Location = new System.Drawing.Point(3, 2);
            this.rtbAddQuestion.Name = "rtbAddQuestion";
            this.rtbAddQuestion.Size = new System.Drawing.Size(453, 80);
            this.rtbAddQuestion.TabIndex = 0;
            this.rtbAddQuestion.Text = "";
            // 
            // bAddQuestion
            // 
            this.bAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bAddQuestion.Location = new System.Drawing.Point(12, 191);
            this.bAddQuestion.Name = "bAddQuestion";
            this.bAddQuestion.Size = new System.Drawing.Size(89, 40);
            this.bAddQuestion.TabIndex = 5;
            this.bAddQuestion.Text = "Save";
            this.bAddQuestion.UseVisualStyleBackColor = false;
            this.bAddQuestion.Visible = false;
            this.bAddQuestion.Click += new System.EventHandler(this.bAddQuestion_Click);
            // 
            // bDeleteQuestion
            // 
            this.bDeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bDeleteQuestion.Location = new System.Drawing.Point(12, 283);
            this.bDeleteQuestion.Name = "bDeleteQuestion";
            this.bDeleteQuestion.Size = new System.Drawing.Size(89, 43);
            this.bDeleteQuestion.TabIndex = 9;
            this.bDeleteQuestion.Text = "Delete Question";
            this.bDeleteQuestion.UseVisualStyleBackColor = false;
            this.bDeleteQuestion.Visible = false;
            this.bDeleteQuestion.Click += new System.EventHandler(this.bDeleteQuestion_Click);
            // 
            // bAddQue
            // 
            this.bAddQue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bAddQue.Location = new System.Drawing.Point(12, 237);
            this.bAddQue.Name = "bAddQue";
            this.bAddQue.Size = new System.Drawing.Size(89, 40);
            this.bAddQue.TabIndex = 10;
            this.bAddQue.Text = "Add Question";
            this.bAddQue.UseVisualStyleBackColor = false;
            this.bAddQue.Visible = false;
            this.bAddQue.Click += new System.EventHandler(this.bAddQue_Click);
            // 
            // bEditThisQuestion
            // 
            this.bEditThisQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bEditThisQuestion.Location = new System.Drawing.Point(12, 327);
            this.bEditThisQuestion.Name = "bEditThisQuestion";
            this.bEditThisQuestion.Size = new System.Drawing.Size(89, 37);
            this.bEditThisQuestion.TabIndex = 11;
            this.bEditThisQuestion.Text = "Edit Question";
            this.bEditThisQuestion.UseVisualStyleBackColor = false;
            this.bEditThisQuestion.Visible = false;
            this.bEditThisQuestion.Click += new System.EventHandler(this.bEditThisQuestion_Click);
            // 
            // bSaveEdit
            // 
            this.bSaveEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bSaveEdit.Location = new System.Drawing.Point(12, 359);
            this.bSaveEdit.Name = "bSaveEdit";
            this.bSaveEdit.Size = new System.Drawing.Size(89, 23);
            this.bSaveEdit.TabIndex = 12;
            this.bSaveEdit.Text = "Save";
            this.bSaveEdit.UseVisualStyleBackColor = false;
            this.bSaveEdit.Visible = false;
            this.bSaveEdit.Click += new System.EventHandler(this.bSaveEdit_Click);
            // 
            // Select_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(572, 437);
            this.Controls.Add(this.bSaveEdit);
            this.Controls.Add(this.bEditThisQuestion);
            this.Controls.Add(this.bAddQue);
            this.Controls.Add(this.bDeleteQuestion);
            this.Controls.Add(this.pAddQuestion);
            this.Controls.Add(this.bEditQuestion);
            this.Controls.Add(this.bDeleteTest);
            this.Controls.Add(this.bCreateNewTest);
            this.Controls.Add(this.bAddQuestion);
            this.Controls.Add(this.pNewTest);
            this.Controls.Add(this.pEdit);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.cbListTests);
            this.Name = "Select_Test";
            this.Text = "Select_Test";
            this.Load += new System.EventHandler(this.Select_Test_Load);
            this.pEdit.ResumeLayout(false);
            this.pEdit.PerformLayout();
            this.pNewTest.ResumeLayout(false);
            this.pNewTest.PerformLayout();
            this.pAddQuestion.ResumeLayout(false);
            this.pAddQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Panel pEdit;
        private System.Windows.Forms.Button bRename;
        private System.Windows.Forms.TextBox tbNameOfTest;
        private System.Windows.Forms.Button bSaveNewName;
        private System.Windows.Forms.Panel pNewTest;
        private System.Windows.Forms.Label lCreateNewTest;
        private System.Windows.Forms.Button bCreateNewTest;
        private System.Windows.Forms.Button bSaveTestName;
        private System.Windows.Forms.TextBox tbNewNameTest;
        private System.Windows.Forms.Button bDeleteTest;
        private System.Windows.Forms.Button bEditQuestion;
        private System.Windows.Forms.Panel pAddQuestion;
        private System.Windows.Forms.TextBox tbAnsw4;
        private System.Windows.Forms.TextBox tbAnsw3;
        private System.Windows.Forms.TextBox tbAnsw2;
        private System.Windows.Forms.TextBox tbAnsw1;
        private System.Windows.Forms.RichTextBox rtbAddQuestion;
        private System.Windows.Forms.RadioButton rbDD;
        private System.Windows.Forms.RadioButton rbCC;
        private System.Windows.Forms.RadioButton rbBB;
        private System.Windows.Forms.RadioButton rbAA;
        private System.Windows.Forms.Button bAddQuestion;
        private System.Windows.Forms.Button bDeleteQuestion;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bNext;
        public System.Windows.Forms.ComboBox cbListTests;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Button bAddQue;
        private System.Windows.Forms.Button bEditThisQuestion;
        private System.Windows.Forms.Button bSaveEdit;
    }
}