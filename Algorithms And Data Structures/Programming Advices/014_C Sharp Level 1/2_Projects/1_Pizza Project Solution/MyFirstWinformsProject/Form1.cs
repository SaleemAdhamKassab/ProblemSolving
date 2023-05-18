using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinformsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void disableForm(bool status = true)
        {
            grpSize.Enabled = !status;
            grpCrustType.Enabled = !status;
            grpToppings.Enabled = !status;
            grpWhereToEat.Enabled = !status;
            btnOrderPizza.Enabled = !status;
        }
        private void resetForm()
        {
            disableForm(false);

            rbMeduim.Checked = true;

            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            rbThin.Checked = true;
            btnOrderPizza.Enabled = true;

        }
        private void updateToppings()
        {
            string sToppings = "";

            if (chkExtraChees.Checked)
                sToppings += " Extra Chees, ";

            if (chkMushrooms.Checked)
                sToppings += " Mushrroms, ";

            if (chkTomatoes.Checked)
                sToppings += " Tomatoes, ";

            if (chkOnion.Checked)
                sToppings += " Onion, ";

            if (chkOlives.Checked)
                sToppings += " Olives, ";

            if (chkGreenPeppers.Checked)
                sToppings += " Green Peppers, ";

            if (sToppings == "")
                sToppings = "No Toppings";
            else
                sToppings = sToppings.Remove(sToppings.Length - 2);

            updateTotalAmount();
            lblToppings.Text = sToppings;
        }

        private int calcPizzaSizeAmount()
        {
            int pizzaSizeAmount = 0;

            if (rbSmall.Checked)
                return int.Parse(rbSmall.Tag.ToString());

            else if (rbMeduim.Checked)
                return int.Parse(rbMeduim.Tag.ToString());

            else if (rbLarg.Checked)
                return int.Parse(rbLarg.Tag.ToString());

            return pizzaSizeAmount;
        }
        private int calcPizzaCrustTypeAmount() => rbThink.Checked ? int.Parse(rbThink.Tag.ToString()) : 0;
        private int calcPizzaToppingsAmount()
        {
            int pizzaToppingsAmount = 0;

            if (chkExtraChees.Checked)
                pizzaToppingsAmount += int.Parse(chkExtraChees.Tag.ToString());

            if (chkMushrooms.Checked)
                pizzaToppingsAmount += int.Parse(chkMushrooms.Tag.ToString());


            if (chkTomatoes.Checked)
                pizzaToppingsAmount += int.Parse(chkTomatoes.Tag.ToString());


            if (chkOnion.Checked)
                pizzaToppingsAmount += int.Parse(chkOnion.Tag.ToString());


            if (chkOlives.Checked)
                pizzaToppingsAmount += int.Parse(chkOlives.Tag.ToString());


            if (chkGreenPeppers.Checked)
                pizzaToppingsAmount += int.Parse(chkGreenPeppers.Tag.ToString());


            return pizzaToppingsAmount;
        }
        private int calcTotalOrderAmount() => calcPizzaSizeAmount() + calcPizzaCrustTypeAmount() + calcPizzaToppingsAmount();
        private void updateTotalAmount() => lblTotalPriceAmount.Text = "$ " + calcTotalOrderAmount();

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = rbSmall.Text;
            updateTotalAmount();
        }
        private void rdMeduim_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = rbMeduim.Text;
            updateTotalAmount();
        }
        private void rdLarg_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = rbLarg.Text;
            updateTotalAmount();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e) => updateToppings();
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e) => updateToppings();
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e) => updateToppings();
        private void chkOnion_CheckedChanged(object sender, EventArgs e) => updateToppings();
        private void chkOlives_CheckedChanged(object sender, EventArgs e) => updateToppings();
        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e) => updateToppings();

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustTypeValue.Text = rbThin.Text;
            updateTotalAmount();
        }
        private void rdThink_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustTypeValue.Text = rbThink.Text;
            updateTotalAmount();
        }


        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEatValue.Text = rbEatIn.Text;
            updateTotalAmount();
        }
        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEatValue.Text = rbTakeOut.Text;
            updateTotalAmount();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order?",
                            "Confirm",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully",
                                "Success",
                                MessageBoxButtons.OK);

                disableForm();
            }
        }
        private void btnResetForm_Click(object sender, EventArgs e) => resetForm();

    }
}
