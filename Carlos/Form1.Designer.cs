namespace Carlos
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
            this.button1 = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.TextBoxNrOfTeams = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamsTable = new System.Windows.Forms.DataGridView();
            this.RESETbtn = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GenerateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateBtn.Location = new System.Drawing.Point(665, 415);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 3;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = false;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // TextBoxNrOfTeams
            // 
            this.TextBoxNrOfTeams.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TextBoxNrOfTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNrOfTeams.Location = new System.Drawing.Point(665, 45);
            this.TextBoxNrOfTeams.Name = "TextBoxNrOfTeams";
            this.TextBoxNrOfTeams.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxNrOfTeams.Size = new System.Drawing.Size(100, 21);
            this.TextBoxNrOfTeams.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Teams";
            // 
            // TeamsTable
            // 
            this.TeamsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TeamsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamsTable.Location = new System.Drawing.Point(245, 95);
            this.TeamsTable.Name = "TeamsTable";
            this.TeamsTable.Size = new System.Drawing.Size(520, 263);
            this.TeamsTable.TabIndex = 6;
            // 
            // RESETbtn
            // 
            this.RESETbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RESETbtn.Location = new System.Drawing.Point(13, 415);
            this.RESETbtn.Name = "RESETbtn";
            this.RESETbtn.Size = new System.Drawing.Size(75, 23);
            this.RESETbtn.TabIndex = 7;
            this.RESETbtn.Text = "RESET";
            this.RESETbtn.UseVisualStyleBackColor = true;
            this.RESETbtn.Click += new System.EventHandler(this.RESETbtn_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAll.Location = new System.Drawing.Point(112, 415);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(96, 23);
            this.deleteAll.TabIndex = 8;
            this.deleteAll.Text = "DELETE ALL";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 263);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "CARLOS Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.RESETbtn);
            this.Controls.Add(this.TeamsTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxNrOfTeams);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TeamsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.TextBox TextBoxNrOfTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TeamsTable;
        private System.Windows.Forms.Button RESETbtn;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

