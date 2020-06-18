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
    public partial class Form2 : Form
    {
        ReliefCenter rC;
        public Form2()  {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            rC =  new ReliefCenter(Form1.rcName); 
            rcLabel.Text = Form1.rcName.ToUpper();
            outputWindow.Text += "Welcome to " + Form1.rcName + " Relief Center!\n--------------------------------------------------------------------------------------------------------------------- \n";
        }

        private void rcLabelN(object sender, EventArgs e){
        }

        private void outputWindow_TextChanged(object sender, EventArgs e) {
            outputWindow.Focus(); outputWindow.Select(outputWindow.Text.Length, 0); //autoscroll
        }

        private void goodNameBox_TextChanged(object sender, EventArgs e) {
        }

        private void goodDonateClick(object sender, EventArgs e) {
            int dc; //int for parse checking
            if (goodDropBox.Text == string.Empty || goodQuantityBox.Text == string.Empty || !int.TryParse(goodQuantityBox.Text, out dc)) {
                //precautionary measures to prevent crashing if one of the boxes is empty/wrong input
                MessageBox.Show("Invalid values. Please try again.");
                return;
            }
            else { 
            outputWindow.Text += rC.ReceiveGoods(goodDropBox.Text, int.Parse(goodQuantityBox.Text));
            }
        }

        private void dropBoxClick(object sender, EventArgs e){
        }

        private void addGoodClick(object sender, EventArgs e) {
            int c; //int for parse checking
            if (goodNameBox.Text == string.Empty || goodRateBox.Text == string.Empty || !int.TryParse(goodRateBox.Text, out c) || goodUnitBox.Text == string.Empty) {
                //precautionary measures to prevent crashing if one of the boxes is empty/wrong input
                MessageBox.Show("Invalid values. Please try again.");
                return;
            }
            else { 
                DialogResult dialogResult = MessageBox.Show("Proceed with the selected function?", "Confirmation", MessageBoxButtons.YesNo); //prompt
            if (dialogResult == DialogResult.Yes) {

                outputWindow.Text += rC.AddNewGood(goodNameBox.Text.ToLower(), int.Parse(goodRateBox.Text), goodUnitBox.Text);
                    // transfer of data to drop down choices
                    bool match = false;
                    foreach (string goomby in goodDropBox.Items)  { //this code (66-73) took me 4 hours to make it work IDK W HY
                        if (goomby == goodNameBox.Text.ToLower()) {
                            match = true;
                        }
                    }
                    if (match == false) {
                        goodDropBox.Items.Add(goodNameBox.Text);
                    }
                }
            }
        }
        

        private void clearOutputClick(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the output window?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                outputWindow.Text = "";
            }
        }

        private void printInventoryClick(object sender, EventArgs e) {
            inventoryWindow.Text += rC.PrintInventory();
        }

        private void inventoryWindow_TextChanged(object sender, EventArgs e) {
            inventoryWindow.Focus(); inventoryWindow.Select(inventoryWindow.Text.Length, 0);
        }

        private void label4_Click(object sender, EventArgs e) {
        }

        private void label5_Click(object sender, EventArgs e) {
        }

        private void goodQuantityBox_TextChanged(object sender, EventArgs e) {
        }

        private void packReleaseButton_Click(object sender, EventArgs e) {
            int pr; //parse checking
            if (goodPackBox.Text == string.Empty || !int.TryParse(goodRateBox.Text, out pr)) { 
                MessageBox.Show("Invalid values. Please try again.");
                return;
            }
            else { 
                outputWindow.Text += rC.ReleasePacks(int.Parse(goodPackBox.Text));
            }
        }

        private void goodPackBox_TextChanged(object sender, EventArgs e){
        }

        private void label6_Click(object sender, EventArgs e){
        }

        private void groupBox4_Enter(object sender, EventArgs e) {
        }

        private void goodDonateBox_TextChanged(object sender, EventArgs e) {
        }
    }
}
