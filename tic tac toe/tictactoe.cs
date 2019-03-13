using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class tictactoe : Form
    {
        bool turn = true; //true="X", false=""O
        bool against_computer = false;//if against computer true
        int turn_count=0;

        public tictactoe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Tic Tac Toe by Sudhananda Biswas.\nDiploma in Computer Technology.\nJessore Polytechnic Institute.");
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
            turn = (!turn);
            b.Enabled = false;
            turn_count++;

            cheack_winner();

            //checking to see against computer or not
            if (!turn && against_computer)
                computer_make_move();
           
        }

        private void computer_make_move()
        {
            /*
             * priority1: check for win
             * priority2: check for block
             * priority3: check for corner
             * priority5: check for free space
             */
            Button move = null;

            move = look_for_win_or_block("O");
            if (move == null)
            {
                move = look_for_win_or_block("X");
                if (move == null)
                {
                    move = Look_for_corner();
                    if (move == null)
                    {
                        move = look_for_free_space();
                    }//end if
                }//endif
            }//endif
            try
            {
                move.PerformClick();
            }
            catch { }
        }//computer make move

        private Button look_for_win_or_block(String mark)
        {
            Console.WriteLine("Look for win or block" + mark);

            //Horizontal checking for move
            if (a1.Text == mark && a2.Text == mark && a3.Text == "")
                return a3;
            if (a1.Text == mark && a2.Text == "" && a3.Text == mark)
                return a2;
            if (a1.Text == "" && a2.Text == mark && a3.Text == mark)
                return a1;

            if (b1.Text == mark && b2.Text == mark && b3.Text == "")
                return b3;
            if (b1.Text == mark && b2.Text == "" && b3.Text == mark)
                return b2;
            if (b1.Text == "" && b2.Text == mark && b3.Text == mark)
                return b1;

            if (c1.Text == mark && c2.Text == mark && c3.Text == "")
                return c3;
            if (c1.Text == mark && c2.Text == "" && c3.Text == mark)
                return c2;
            if (c1.Text == "" && c2.Text == mark && c3.Text == mark)
                return c1;

            //Vertical checking for move
            if (a1.Text == mark && b1.Text == mark && c1.Text == "")
                return c1;
            if (a1.Text == mark && b1.Text == "" && c1.Text == mark)
                return b1;
            if (a1.Text == "" && b1.Text == mark && c1.Text == mark)
                return a1;

            if (a2.Text == mark && b2.Text == mark && c2.Text == "")
                return c2;
            if (a2.Text == mark && b2.Text == "" && c2.Text == mark)
                return b2;
            if (a2.Text == "" && b2.Text == mark && c2.Text == mark)
                return a2;

            if (a3.Text == mark && b3.Text == mark && c3.Text == "")
                return c3;
            if (a3.Text == mark && b3.Text == "" && c3.Text == mark)
                return b3;
            if (a3.Text == "" && b3.Text == mark && c3.Text == mark)
                return a3;

            //Diagonal checking for move
            if (a1.Text == mark && b2.Text == mark && c3.Text == "")
                return c3;
            if (a1.Text == mark && b2.Text == "" && c3.Text == mark)
                return b2;
            if (a1.Text == "" && b2.Text == mark && c3.Text == mark)
                return a1;

            if (a3.Text == mark && b2.Text == mark && c1.Text == "")
                return c1;
            if (a3.Text == mark && b2.Text == "" && c1.Text == mark)
                return b2;
            if (a3.Text == "" && b2.Text == mark && c1.Text == mark)
                return a3;

            return null;
        } //look for win or block

        private Button Look_for_corner()
        {
            Console.WriteLine("look for corner to move");

            if (a1.Text == "O")
            {
                if (a3.Text == "")
                    return a3;
                if (c3.Text == "")
                    return c3;
                if (c1.Text == "")
                    return c1;
            }

            if (a3.Text == "O")
            {
                if (a1.Text == "")
                    return a1;
                if (c3.Text == "")
                    return c3;
                if (c1.Text == "")
                    return c1;
            }

            if (c3.Text == "O")
            {
                if (c1.Text == "")
                    return c1;
                if (a1.Text == "")
                    return a1;
                if (a3.Text == "")
                    return a3;
            }

            if (c1.Text == "O")
            {
                if (a3.Text == "")
                    return a3;
                if (c3.Text == "")
                    return c3;
                if (a1.Text == "")
                    return c1;
            }

            if (a1.Text == "")
                return a1;
            if (a3.Text == "")
                return a3;
            if (c3.Text == "")
                return c3;
            if (c1.Text == "")
                return c1;

            return null;
        }

        private Button look_for_free_space()
        {
            Console.WriteLine("looking for free space to move");
            Button b = null;

            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            
            return null;
        }

        private void cheack_winner()
        {
            bool there_is_winner = false;
            //Vertical checking
            if (a1.Text == b1.Text && b1.Text == c1.Text && !a1.Enabled)
                there_is_winner = true;
            else if (a2.Text == b2.Text && b2.Text == c2.Text && !a2.Enabled)
                there_is_winner = true;
            else if (a3.Text == b3.Text && b3.Text == c3.Text && !a3.Enabled)
                there_is_winner = true;
            //Horizontal checking
            if (a1.Text == a2.Text && a2.Text == a3.Text && !a1.Enabled)
                there_is_winner = true;
            else if (b1.Text == b2.Text && b2.Text == b3.Text && !b1.Enabled)
                there_is_winner = true;
            else if (c1.Text == c2.Text && c2.Text == c3.Text && !c1.Enabled)
                there_is_winner = true;
            //Diagonal checking
            if (a1.Text == b2.Text && b2.Text == c3.Text && !a1.Enabled)
                there_is_winner = true;
            else if (a3.Text == b2.Text && b2.Text == c1.Text && !b2.Enabled)
                there_is_winner = true;

            if (there_is_winner)
            {
                disable_button();
                String winner = "";
                if (turn)
                {
                    winner = p2.Text;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = p1.Text;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }

                MessageBox.Show("winner is " + winner);
            }//endif
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("It is draw");
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                }//endif
            }//end of if-else

        }//end of check winner

        private void disable_button()
        {
            
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
                catch { };
            }//end of foreach        
            
        }//end of disable button

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try 
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { };
            }//end of foreach
            
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                    
                }
                else
                {
                    b.Text = "O";
                   
                }
            }//endif
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }

        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void p2_textchanged(object sender, EventArgs e)
        {
            if (p2.Text.ToUpper() == "COMPUTER")
                against_computer = true;
            else
                against_computer = false;
        }

        private void tictactoe_Load(object sender, EventArgs e)
        {
            setDefaultToolStripMenuItem.PerformClick();
        }

        private void setDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p1.Text = "Shbsovon";
            p2.Text = "Computer";
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      