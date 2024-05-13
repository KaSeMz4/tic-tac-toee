using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int count_o = 0;
        int count_x = 0;
        int count_d = 0;
        int Turn_count = 0;
        bool Turn = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Buttons(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Turn)
                button.Text = "X";
            else
                button.Text = "O";
            Turn = !Turn;
            button.Enabled = false;
            Turn_count++;
            Check_Winner();
        }
        private void Check_Winner()
        {
            bool winner = false;
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                winner = true;
                b1.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                b3.BackColor = Color.Red;
            }
            else if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && (!b1.Enabled))
            { 
                winner = true;
                b1.BackColor = Color.Red;
                b4.BackColor = Color.Red;
                b7.BackColor = Color.Red;
            }
            else if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b1.Enabled))
            { 
                winner = true;
                b1.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b9.BackColor = Color.Red;
            }
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && (!b4.Enabled))
            { 
                winner = true;
                b4.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b6.BackColor = Color.Red;
            }
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && (!b7.Enabled))
            { 
                winner = true;
                b7.BackColor = Color.Red;
                b8.BackColor = Color.Red;
                b9.BackColor = Color.Red;
            }
            else if ((b7.Text == b5.Text) && (b5.Text == b3.Text) && (!b7.Enabled))
            { 
                winner = true;
                b7.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b3.BackColor = Color.Red;
            }
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && (!b2.Enabled))
            { 
                winner = true;
                b2.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b8.BackColor = Color.Red;
            }
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && (!b3.Enabled))
            { 
                winner = true;
                b3.BackColor = Color.Red;
                b6.BackColor = Color.Red;
                b9.BackColor = Color.Red;
            }
            if (winner)
            {
                Disable();
                string win = "";
                if (Turn)
                {
                    win = "O";
                    count_o++;
                    Player2_Count.Text = count_o.ToString();
                }
                else
                {
                    win = "X";
                    count_x++;
                    Player1_Count.Text = count_x.ToString();
                }
                MessageBox.Show("the winner is the player " + win);
            }
            else
            {
                if (Turn_count == 9)
                {
                    count_d++;
                    Draw_Count.Text = count_d.ToString();
                    MessageBox.Show("Draw");
                    Turn_count = 0;
                    Turn = true;
                    foreach (Control b in Controls)
                    {
                        try
                        {
                            Button button = (Button)b;
                            button.Enabled = true;
                            button.BackColor = Color.White;
                            button.Text = "";
                        }
                        catch { }
                    }
                }
            }
        }
        private void Disable()
        {
            foreach (Control b in Controls)
            {
                try
                {
                    Button button = (Button)b;
                    button.Enabled = false;
                }
                catch { }
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Turn_count = 0;
            Turn = true;
            Player1_Count.Text = 0.ToString();
            Player2_Count.Text = 0.ToString();
            Draw_Count.Text = 0.ToString(); 
            count_o = 0;
            count_x = 0;
            count_d = 0;
            foreach (Control b in Controls)
            {
                try
                {
                    Button button = (Button)b;
                    button.Enabled = true;
                    button.BackColor = Color.White;
                    button.Text = "";
                }
                catch { }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Turn_count = 0;
            Turn = true;
            foreach (Control b in Controls)
            {
                try
                {
                    Button button = (Button)b;
                    button.Enabled = true;
                    button.BackColor = Color.White;
                    button.Text = "";
                }
                catch { }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
