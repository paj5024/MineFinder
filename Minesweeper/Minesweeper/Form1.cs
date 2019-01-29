using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int mine;
        int mine2;
        int score = 0;
        

    private void Form1_Load(object sender, EventArgs e)
        {
            //create a random number 1-9
            Random rnd = new Random();
            mine = rnd.Next(1, 10);
            mine2 = rnd.Next(1, 10);

            while (mine == mine2)
            {
                mine2 = rnd.Next(1, 10);
            }

            //Button[] array = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            //Button[] buttons = Controls.OfType<Button>().ToArray();
        }

        private void ButtonPress(int btnNumber, Button button)
            // method parameters are an int for the random number, and button for the button

        {

            //check if the number is equal to random number
            //set background to mine
            //display game over
            //if it is not equal to random number, display pressed button, increment score by 1


            if (mine == btnNumber)
            {
                button.BackgroundImageLayout = ImageLayout.Stretch; //resizes the image file to fit button
                button.BackgroundImage = Properties.Resources.bomb; //sets image for button to bomb
                lblEOG.Text = "YOU DIED...";
                lblEOG.ForeColor = Color.Red;
                btn1.Enabled = false; //disables all buttons when game ends
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
            else if (mine2 == btnNumber)
            {
                button.BackgroundImageLayout = ImageLayout.Stretch; //resizes the image file to fit button
                button.BackgroundImage = Properties.Resources.bomb; //sets image for button to bomb
                lblEOG.Text = "YOU DIED...";
                lblEOG.ForeColor = Color.Red;
                btn1.Enabled = false; //disables all buttons when game ends
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
            else
            {
                button.BackColor = Color.Gray; //sets background color to slightly darker when bomb isn't there
                button.Text = "Nothing here!";
                score++; 
                txtScore.Text = "" + score;
                button.Enabled = false; //disables button so you can't keep pressing it
            }

            if (score == 7)
            {
                lblEOG.Text = "YOU WIN!";
                lblEOG.ForeColor = Color.Green;
                btn1.Enabled = false; //disables all buttons when win
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }

            //foreach (Button x page.controls)
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ButtonPress(1, btn1); //method arguments call the button number int, and the button name
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ButtonPress(2, btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ButtonPress(3, btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ButtonPress(4, btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ButtonPress(5, btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ButtonPress(6, btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ButtonPress(7, btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ButtonPress(8, btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ButtonPress(9, btn9);
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            mine = rnd.Next(1, 10);

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.BackColor = Color.Gainsboro;
            btn2.BackColor = Color.Gainsboro;
            btn3.BackColor = Color.Gainsboro;
            btn4.BackColor = Color.Gainsboro;
            btn5.BackColor = Color.Gainsboro;
            btn6.BackColor = Color.Gainsboro;
            btn7.BackColor = Color.Gainsboro;
            btn8.BackColor = Color.Gainsboro;
            btn9.BackColor = Color.Gainsboro;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.BackgroundImage = null;
            btn2.BackgroundImage = null;
            btn3.BackgroundImage = null;
            btn4.BackgroundImage = null;
            btn5.BackgroundImage = null;
            btn6.BackgroundImage = null;
            btn7.BackgroundImage = null;
            btn8.BackgroundImage = null;
            btn9.BackgroundImage = null;

            score = 0;
            txtScore.Text = "";
            lblEOG.Text = "";
        }
    }
}
