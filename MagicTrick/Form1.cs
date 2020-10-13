using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Will take your birthmonth and form it into a different number that will be predicted 
/// </summary>
namespace MagicTrick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Closes the Application
        private void bttnClosesApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bttnStart.Text = "You are now ready to start!!";
            lstBxMonths.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            label1.Visible = false;
            bttnYes.Visible = false;
            bttnNo.Visible = false;
            label2.Visible = false;
            if (bttnStart.Text.ToString() == "You are now ready to start!!")
            {
                lstBxMonths.Visible = true;
                label1.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // Makes both labels, AnswerPrediction & Failure, go invisible and changes label Success' text
        private void bttnYes_Click(object sender, EventArgs e)
        {
            lblSuccess.Text = "I hope now you believe in magic too.";
            lblAnswerPrediction.Visible = false;
            lblFailure.Visible = false;
        }
        // Makes both labels, AnswerPrediction & Success, go invisible and changes label Failure's text
        private void bttnNo_Click(object sender, EventArgs e)
        {
            lblFailure.Text = "I will make sure to do better next time.";
            lblAnswerPrediction.Visible = false;
            lblSuccess.Visible = false;
        }
        // Makes almost everything invisible after clicking the button and changes button Start's text
        private void button1_Click(object sender, EventArgs e)
        {
            bttnStart.Text = "You are now ready to start!!";
            lstBxMonths.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            label1.Visible = false;
            bttnYes.Visible = false;
            bttnNo.Visible = false;
            label2.Visible = false;
            if (bttnStart.Text.ToString() == "You are now ready to start!!")
            {
                lstBxMonths.Visible = true;
                label1.Visible = true;
            }
        }
        // If anything in selcted in ListBox Months then groupbox one will be visible
        private void lstBxMonths_DoubleClick(object sender, EventArgs e)
        {
            if (lstBxMonths.SelectedItem.ToString() == "1 = January")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "2 = February")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "3 = March")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "4 = April")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "5 = May")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "6 = June")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "7 = July")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "8 = August")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "9 = September")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "10 = October")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "11 = November")
            {
                groupBox1.Visible = true;
            }
            else if (lstBxMonths.SelectedItem.ToString() == "12 = December")
            {
                groupBox1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        // When clicked changes labels AnswerPrediction, Success, and Failure texts and makes GroupBox 2 visilble as well as making the start button invisible 
        private void rdoBttnMultiplyBy2_CheckedChanged(object sender, EventArgs e)
        {
            lblAnswerPrediction.Text = "Prediction: Your number will be 5.";
            groupBox2.Visible = true;
            lblSuccess.Text = "Now add 10 to your number and divide by 2.";
            bttnStart.Visible = false;
            lblFailure.Text = "Finally subtract your initial birth month number.";
        }
        // When clicked changes labels AnswerPrediction, Success, and Failure texts and makes GroupBox 2 visilble as well as making the start button invisible
        private void rdoBttnMultiplyBy5_CheckedChanged(object sender, EventArgs e)
        {
            lblAnswerPrediction.Text = "Prediction: Your number will be 2.";
            groupBox2.Visible = true;
            lblSuccess.Text = "Now add 10 to your number and divide by 5.";
            bttnStart.Visible = false;
            lblFailure.Text = "Finally subtract your initial birthmonth number.";
        }
        // When clicked changes labels AnswerPrediction, Success, and Failure texts and makes GroupBox 2 visilble as well as making the start button invisible
        private void rdoBttnMultiplyBy10_CheckedChanged(object sender, EventArgs e)
        {
            lblAnswerPrediction.Text = "Prediction: Your number will be 1.";
            groupBox2.Visible = true;
            lblSuccess.Text = "Now add 10 to your number and divide by 10.";
            bttnStart.Visible = false;
            lblFailure.Text = "Finally subtract your initial birth month number.";
        }
        // If checked then label 2 will be visible as well as the yes and no buttons 
        private void cBProtective_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBNice_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBMean_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBHumorless_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBConsiderate_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBBoring_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBListless_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBEcstatic_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBPessimistic_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBNormal_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBPushover_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
        // If checked then label 2 will be visible as well as the yes and no buttons
        private void cBScheming_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            bttnYes.Visible = true;
            bttnNo.Visible = true;
        }
    }
}
