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
        Logic.PersonListManagement list;
        List<TextBox> textBoxes;

        public Form1()
        {
            InitializeComponent();
            this.textBoxes = new List<TextBox>();
            this.list = new Logic.PersonListManagement();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox newTextBox = new TextBox();

            if(textBoxes.Count() == 0)
            {
                textBoxes.Add(newTextBox);
                newTextBox.Location = new Point(30 , 50);
                this.Controls.Add(newTextBox);
            }
            else
            {
                Point point = textBoxes[textBoxes.Count - 1].Location;
                newTextBox.Location = new Point(point.X, point.Y + 25);
                textBoxes.Add(newTextBox);
                this.Controls.Add(newTextBox);
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            foreach(TextBox box in textBoxes)
            {
                Person p = new Person(box.Text);
                list.AddPerson(p);
            }
        }
    }
}
