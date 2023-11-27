namespace Note
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titles = new System.Windows.Forms.TextBox();
            this.messages = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thetitles = new System.Windows.Forms.TextBox();
            this.btnfont = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "The note";
            // 
            // titles
            // 
            this.titles.Location = new System.Drawing.Point(109, 100);
            this.titles.Name = "titles";
            this.titles.Size = new System.Drawing.Size(107, 24);
            this.titles.TabIndex = 2;
            // 
            // messages
            // 
            this.messages.Location = new System.Drawing.Point(109, 157);
            this.messages.Multiline = true;
            this.messages.Name = "messages";
            this.messages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messages.Size = new System.Drawing.Size(156, 153);
            this.messages.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(109, 327);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(156, 31);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(343, 449);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(109, 449);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(107, 31);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "The titles";
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(109, 419);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(335, 24);
            this.txtRead.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "enter the title of the note to read or delete or edit\r\n\r\n";
            // 
            // thetitles
            // 
            this.thetitles.AcceptsTab = true;
            this.thetitles.Location = new System.Drawing.Point(291, 103);
            this.thetitles.Multiline = true;
            this.thetitles.Name = "thetitles";
            this.thetitles.ReadOnly = true;
            this.thetitles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.thetitles.Size = new System.Drawing.Size(153, 207);
            this.thetitles.TabIndex = 12;
            this.thetitles.TextChanged += new System.EventHandler(this.thetitles_TextChanged);
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(222, 100);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(46, 24);
            this.btnfont.TabIndex = 13;
            this.btnfont.Text = "Font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(227, 449);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(101, 31);
            this.btnedit.TabIndex = 14;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 543);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.thetitles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.titles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titles;
        private System.Windows.Forms.TextBox messages;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox thetitles;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btnedit;
    }
}

