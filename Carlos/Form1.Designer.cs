﻿namespace Carlos
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
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
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
            this.GenerateBtn.Location = new System.Drawing.Point(665, 415);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 3;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // TextBoxNrOfTeams
            // 
            this.TextBoxNrOfTeams.Location = new System.Drawing.Point(665, 45);
            this.TextBoxNrOfTeams.Name = "TextBoxNrOfTeams";
            this.TextBoxNrOfTeams.Size = new System.Drawing.Size(100, 20);
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
            this.TeamsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamsTable.Location = new System.Drawing.Point(245, 95);
            this.TeamsTable.Name = "TeamsTable";
            this.TeamsTable.Size = new System.Drawing.Size(520, 263);
            this.TeamsTable.TabIndex = 6;
            // 
            // RESETbtn
            // 
            this.RESETbtn.Location = new System.Drawing.Point(13, 415);
            this.RESETbtn.Name = "RESETbtn";
            this.RESETbtn.Size = new System.Drawing.Size(75, 23);
            this.RESETbtn.TabIndex = 7;
            this.RESETbtn.Text = "RESET";
            this.RESETbtn.UseVisualStyleBackColor = true;
            this.RESETbtn.Click += new System.EventHandler(this.RESETbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "DELETE ALL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
    }
}

