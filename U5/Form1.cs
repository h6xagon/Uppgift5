using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                label1.Text = "Namn eller efternamn inte ifyllt";
            }
            else
            {
                listBox1.Items.Add($"{textBox1.Text} {textBox2.Text}");
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch
            {
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("inget namn valt, välj ett namn", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
