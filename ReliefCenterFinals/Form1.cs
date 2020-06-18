using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS21A_2018_Midterm_Project;

namespace ReliefCenterFinals
{
    public partial class Form1 : Form
    {
        public static string rcName;
        
       
        Form2 frm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void enterRCName_Click (object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) {
                MessageBox.Show("Please enter a name for the Relief Center");
                return;
            }
            else { 
            rcName = textBox1.Text;
            frm2.ShowDialog();
            this.Close();
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
