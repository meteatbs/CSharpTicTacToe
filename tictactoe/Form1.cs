using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true;//true=X turn, false=Y turn
        int turn_sum= 0;
        static string player1, player2;
        public Form1()
        {
            InitializeComponent();
        }
        public static void setPlayerName(string no1,string no2)
        {
            player1 = no1;
            player2 = no2;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Mete", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_sum++;
            checkWinner();
        }
        private void checkWinner()
        {
            //horizontal checks
            bool hereiswinner = false;
            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text)&&(!btnA1.Enabled))
                hereiswinner = true;
            else if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text)&&(!btnB1.Enabled))
                hereiswinner = true;
            else if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text)&&(!btnC1.Enabled))
                hereiswinner = true;
            //vertical checks
            else if ((btnA1.Text == btnB1.Text) && (btnB1.Text == btnC1.Text) && (!btnA1.Enabled))
                hereiswinner = true;
            else if ((btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text) && (!btnA2.Enabled))
                hereiswinner = true;
            else if ((btnA3.Text == btnB3.Text) && (btnB3.Text == btnC3.Text) && (!btnA3.Enabled))
                hereiswinner = true;
            //diagonal checks
            else if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (!btnA1.Enabled))
                hereiswinner = true;
            else if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && (!btnC1.Enabled))
                hereiswinner = true;


            if (hereiswinner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = player2;
                    MessageBox.Show(winner + " Wins !!");
                    lbloSum.Text = (Int32.Parse(lbloSum.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    MessageBox.Show(winner + " Wins !!");
                    lblxSum.Text = (Int32.Parse(lblxSum.Text) + 1).ToString();
                }
            }//end if
            else {
                if (turn_sum == 9)
                    MessageBox.Show("It's a draw");
                lblDrawSum.Text = (Int32.Parse(lblDrawSum.Text) ).ToString();
            }
                
        }//end checkwinner
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {

                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_sum = 0;

            
                foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch
                {

                }
                }
           
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)

                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;//create eference to button
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resetWinSumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbloSum.Text = "0";
            lblxSum.Text = "0";
            lblDrawSum.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
        }
    }
    }

