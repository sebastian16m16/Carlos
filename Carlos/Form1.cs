using Carlos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Carlos
{
    public partial class Form1 : Form
    {
        Logic.PersonListManagement listManagement;
        List<TextBox> textBoxes;
        List<Button> buttons;
        static int x;

        public Form1()
        {
            InitializeComponent();
            this.textBoxes = new List<TextBox>();
            this.listManagement = new Logic.PersonListManagement();
            this.buttons = new List<Button>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox newTextBox = new TextBox();
            Label newLabel = new Label();
            Button minusBtn = new Button();
            x++;
            if(textBoxes.Count() == 0)
            {
                textBoxes.Add(newTextBox);
                newTextBox.Location = new Point(30 , 50);
                this.Controls.Add(newTextBox);

                newLabel.Text = x.ToString() + ".";
                newLabel.Location = new Point(newTextBox.Location.X - 15, newTextBox.Location.Y + 6);
                this.Controls.Add(newLabel);

                minusBtn.Text = "-";
                minusBtn.Location = new Point(140, button1.Location.Y + 25);
                minusBtn.Size = button1.Size;
                this.buttons.Add(minusBtn);
                this.Controls.Add(minusBtn);
            }
            else
            {
                Point point = textBoxes[textBoxes.Count - 1].Location;
                newTextBox.Location = new Point(point.X, point.Y + 25);
                textBoxes.Add(newTextBox);
                this.Controls.Add(newTextBox);

                newLabel.Text = x.ToString() + ".";
                newLabel.Location = new Point(newTextBox.Location.X - 15, newTextBox.Location.Y + 6);
                this.Controls.Add(newLabel);

                Point btnPoint = buttons[buttons.Count - 1].Location;
                minusBtn.Text = "-";
                minusBtn.Location = new Point(140, btnPoint.Y + 25);
                minusBtn.Size = button1.Size;
                buttons.Add(minusBtn);
                this.Controls.Add(minusBtn);
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            listManagement.REMOVE_ALL();
            TeamsTable.Rows.Clear();
            TeamsTable.Columns.Clear();

            if(TextBoxNrOfTeams.Text != "")
            {
                if(Int32.Parse(TextBoxNrOfTeams.Text) <= textBoxes.Count)
                {
                    foreach (TextBox box in textBoxes)
                    {
                        Person p = new Person(box.Text);
                        listManagement.AddPerson(p);
                    }

                    listManagement.GenerateTeams(Int32.Parse(TextBoxNrOfTeams.Text));

                    listManagement.LoadTable(TeamsTable);
                }
                else
                {
                    MessageBox.Show("Please Enter a valid number of TEAMS!");
                }
                
            }
            else
            {
                MessageBox.Show("Please Enter the number of TEAMS!");
            }
            
        }

        private void RESETbtn_Click(object sender, EventArgs e)
        {
            foreach(TextBox t in textBoxes)
            {
                t.Text = "";
            }

            TextBoxNrOfTeams.Text = "";
            listManagement.REMOVE_ALL();

            TeamsTable.Rows.Clear();
            TeamsTable.Columns.Clear();
            TeamsTable.Update();
            TeamsTable.Refresh();
        }


    }
}
