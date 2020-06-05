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
using System.Xml;

namespace Carlos
{
    public partial class Form1 : Form
    {
        Logic.PersonListManagement listManagement;
        List<TextBox> textBoxes;
        List<Button> buttons;
        List<Label> labels;
        static int x;
        Font font;

        public Form1()
        {
            InitializeComponent();
            this.textBoxes = new List<TextBox>();
            this.listManagement = new Logic.PersonListManagement();
            this.buttons = new List<Button>();
            this.labels = new List<Label>();

            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;

            font = new Font("Times New Roman", 10);

            this.AcceptButton = this.GenerateBtn;
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
                newTextBox.Location = new Point(30 , 0);
                newTextBox.Name = x + "_txtBox";
                this.panel1.Controls.Add(newTextBox);

                newLabel.Text = x.ToString() + ".";
                newLabel.Location = new Point(newTextBox.Location.X - 15, newTextBox.Location.Y + 6);
                labels.Add(newLabel);
                this.panel1.Controls.Add(newLabel);

                minusBtn.Text = "-";
                minusBtn.Location = new Point(140, newTextBox.Location.Y);
                minusBtn.Size = button1.Size;
                minusBtn.Name = x + "_btn";
                this.buttons.Add(minusBtn);
                this.panel1.Controls.Add(minusBtn);
                minusBtn.FlatStyle = FlatStyle.Flat;
                minusBtn.BackColor = Color.FromArgb(173, 1, 5);
                minusBtn.Font = font;
                minusBtn.MouseClick += MinusBtn_MouseClick;
            }
            else
            {
                Point point = textBoxes[textBoxes.Count - 1].Location;
                newTextBox.Location = new Point(point.X, point.Y + 25);
                newTextBox.Name = x + "_txtBox";
                textBoxes.Add(newTextBox);
                this.panel1.Controls.Add(newTextBox);

                newLabel.Text = x.ToString() + ".";
                newLabel.Location = new Point(newTextBox.Location.X - 15, newTextBox.Location.Y + 6);
                labels.Add(newLabel);
                this.panel1.Controls.Add(newLabel);

                Point btnPoint = buttons[buttons.Count - 1].Location;
                minusBtn.Text = "-";
                minusBtn.Location = new Point(140, btnPoint.Y + 25);
                minusBtn.Size = button1.Size;
                buttons.Add(minusBtn);
                minusBtn.Name = x + "_btn";
                this.panel1.Controls.Add(minusBtn);
                minusBtn.FlatStyle = FlatStyle.Flat;
                minusBtn.BackColor = Color.FromArgb(173, 1, 5);
                minusBtn.Font = font;
                minusBtn.MouseClick += MinusBtn_MouseClick;
            }
        }

        private void MinusBtn_MouseClick(object sender, MouseEventArgs e)
        {
            int counter = 0;
            Point newButtonPoint;
            Point newTextBoxPoint;
            Point newLabelPoint;
            foreach(Button b in buttons)
            {
                if (b.Equals((Button)sender))
                {
                    newButtonPoint = b.Location;
                    counter = (int)Char.GetNumericValue(b.Name[0]);
                    this.panel1.Controls.Remove(buttons[counter-1]);
                    buttons.RemoveAt(counter-1);

                    newTextBoxPoint = textBoxes[counter - 1].Location;
                    this.panel1.Controls.Remove(textBoxes[counter-1]);
                    textBoxes.RemoveAt(counter-1);

                    newLabelPoint = labels[counter - 1].Location;
                    this.panel1.Controls.Remove(labels[counter-1]);
                    labels.RemoveAt(counter-1);
                    x--;

                    for (int i = (buttons.Count-1); i > counter-1; i--)
                    {
                        buttons[i].Name = i + 1 + "_btn";
                        buttons[i].Location = buttons[i-1].Location;

                        textBoxes[i].Name = i + 1 + "_textBox";
                        textBoxes[i].Location = textBoxes[i-1].Location;

                        labels[i].Text = i + 1 + ".";
                        labels[i].Location = labels[i-1].Location;
                    }

                    if(counter <= buttons.Count)
                    {
                        buttons[counter - 1].Name = counter + "_btn";
                        buttons[counter - 1].Location = newButtonPoint;

                        textBoxes[counter - 1].Name = counter + "_textBox";
                        textBoxes[counter - 1].Location = newTextBoxPoint;

                        labels[counter - 1].Text = counter + ".";
                        labels[counter - 1].Location = newLabelPoint;
                    }
                    break;
                }
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            listManagement.REMOVE_ALL();
            TeamsTable.Rows.Clear();
            TeamsTable.Columns.Clear();
            int noOfTeams = 0;

            if (TextBoxNrOfTeams.Text != "")
                noOfTeams = Int32.Parse(TextBoxNrOfTeams.Text);

            if( noOfTeams > 0)
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

        private void deleteAll_Click(object sender, EventArgs e)
        {
            for(int i=0; i<buttons.Count; i++)
            {
                this.panel1.Controls.Remove(buttons[i]);
                this.panel1.Controls.Remove(textBoxes[i]);
                this.panel1.Controls.Remove(labels[i]);
            }
            buttons.Clear();
            textBoxes.Clear();
            labels.Clear();
            x = 0;
        }
    }
}
