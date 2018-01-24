using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_ssouthwick_PC13__SlotMachine
//
//  Sheryl Southwick
//           Slot Machine
//                  PC 13
{
    public partial class SlotMachine : Form
    {
        public SlotMachine()
        {
            InitializeComponent();
        }

        // Load the right labels and images to start the game.
        private void SlotMachine_Load(object sender, EventArgs e)
        {
            // Select the slot images. Show amount textbox and label, and spin button.
            GetPics();
            ReadyToSpin();
        }

        // Put three random images onto display and into an array.
        private int[] GetPics()
        {
            // Create random object.
            Random rand = new Random();

            // Assign three random images.
            int pic1 = rand.Next(imlSlots.Images.Count);
            int pic2 = rand.Next(imlSlots.Images.Count);
            int pic3 = rand.Next(imlSlots.Images.Count);

            // Assign the three images to three pictureboxes.
            pictureBox1.Image = imlSlots.Images[pic1];
            pictureBox2.Image = imlSlots.Images[pic2];
            pictureBox3.Image = imlSlots.Images[pic3];

            // Assign images to array.
            int[] images = {pic1, pic2, pic3};

            // Return images array.
            return images;
        }
        // Update cumulative deposit total.
        private decimal AllDeposits(decimal deposit)
        {
            // Add current deposit from textbox user entry to total deposits.
            decimal total_deposits = deposit + decimal.Parse(tbxTotalDeposits.Text);

            // Return updated total deposits.
            return total_deposits;
        }
        // Spin button. If user deposit input is valid, execute SpinAndWin method. 
        // (continue to calculate winnings).
        // If invalid, execute ReadyToSpin method (back to start).
        private void btnSpin_Click(object sender, EventArgs e)
        {
            // Assign user deposit amount to money variable.
            decimal money;

            // If money is a valid number and less than or equal to 250, execute SpinAndWin method.
            if (decimal.TryParse(tbxDeposit.Text, out money))
            {
                if(money <= 250)
                {
                    SpinAndWin();
                }

                // If money is greater than 250, display message and execute ReadyToSpin method.
                else
                {
                    MessageBox.Show("Please enter a lower amount."+
                        "\nMaximum bet is $250.\n($25 per line at ten lines).");
                    ReadyToSpin();
                }

            }
            // If money is not a valid number, display message and execute ReadyToSpin method.
            else
            {
                MessageBox.Show("Enter valid amount.");
                ReadyToSpin();
            }

        }

        // Get user input deposit amount, add to total deposits, 
        // add current winnings to total and display.
        private void SpinAndWin()
        {
            // Assign user input deposit amount to deposit variable.
            decimal deposit = decimal.Parse(tbxDeposit.Text);

            // Assign "100.00" to Deposit textBox.
            tbxDeposit.Text = "100.00";

            // Assign total deposits to AllDeposits method-returned amount.
            tbxTotalDeposits.Text = AllDeposits(deposit).ToString("n");

            // Assign total winnings to Winnings method-returned amount.
            tbxTotalWon.Text = Winnings(deposit).ToString("n");

            // Change display to show winnings from current spin.
            ShowWinnings();
        }

        // Change display boxes, buttons, and labels to show winnings from current spin.
        private void ShowWinnings()
        {
            tbxDeposit.Visible = false;
            btnSpin.Visible = false;
            lblAmount.Visible = false;
            btnOK.Visible = true;
            
        }

        // Get spin images and compare, and display and return winnings results.
        private decimal Winnings(decimal spinwinnings)
        {

            // Return focus to user entry deposit textbox.
            tbxDeposit.Focus();

            // assign pics to new array of three picture values and display 
            // corresponding images.
            int[] pics = GetPics(); string spinwinmsg = "YOU WON ";

            // If all three images are the same, winnings are tripled, add to string spinwinmsg.
            if (pics[0] == pics[1] && pics[0] == pics[2])
            {
                spinwinnings *= 3; spinwinmsg += (spinwinnings.ToString("c")) + " !";
            }
            // If two of three images are the same, winnings are doubled, add to string spinwinmsg.
            else if (pics[0] == pics[1] || pics[0] == pics[2] || pics[1] == pics[2])
            {
                spinwinnings *= 2; spinwinmsg += (spinwinnings.ToString("c")) + " !";
            }
            // If all three images are different, no winnings, add to string spinwinmsg.
            else
            {
                spinwinnings = 0; spinwinmsg = "   YOU LOSE    ";
            }

            // Display string spinwinmsg.
            btnOK.Text = spinwinmsg + " [Click to continue]";

            // Return current winnings added to cumulative winnings.
            return spinwinnings + decimal.Parse(tbxTotalWon.Text);
        }

        // Change display boxes, buttons, and labels to spin again.
        private void ReadyToSpin()
        {
            tbxDeposit.Visible = true;
            lblAmount.Visible = true;
            btnOK.Visible = false;
            btnSpin.Visible = true;
            tbxDeposit.Focus();
        }

        // Close the form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // OK button pressed. Execute ReadyToSpin method, which
        // changes display boxes, buttons, and labels to spin again.
        private void btnOK_Click(object sender, EventArgs e)
        {
            ReadyToSpin(); 
        }

        // CashOut button pressed. Change display boxes, buttons, and labels 
        // to display total amount entered and total amount won and show 
        // PlayAgain and Exit buttons.
        private void buttonCashOut_Click(object sender, EventArgs e)
        {
            // Display total amount entered and total amount won.
            labelCashOut.Text = "\nYou spent  $"+ tbxTotalDeposits.Text + 
                "\n\n You won  $"+ tbxTotalWon.Text +"\n\nThank you for your investment!";

            // Show cash out label displaying totals entered and won, and show 
            // PlayAgain and Exit buttons, and hide other boxex, buttons, and labels.
            labelCashOut.Visible = true; btnExit.Visible = true;
            buttonCashOut.Visible = false; btnOK.Visible = false;
            pictureBox1.Visible = false; tbxDeposit.Visible = false;
            pictureBox2.Visible = false; lblAmount.Visible = false;
            pictureBox3.Visible = false; btnSpin.Visible = false;
            btnExit.Focus(); buttonPlayAgain.Visible = true;
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            // Change display boxes, buttons, and labels to start over again.
            labelCashOut.Visible = false; btnExit.Visible = false;
            buttonCashOut.Visible = true; btnOK.Visible = false;
            pictureBox1.Visible = true; tbxDeposit.Visible = true;
            pictureBox2.Visible = true; lblAmount.Visible = true;
            pictureBox3.Visible = true; btnSpin.Visible = true;
            btnExit.Focus(); buttonPlayAgain.Visible = false;
            tbxTotalDeposits.Text = "0.00"; tbxTotalWon.Text = "0.00";
            tbxDeposit.Text = "0.00"; tbxDeposit.Focus(); GetPics();
        }
    }

}

