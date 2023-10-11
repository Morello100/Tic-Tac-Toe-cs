using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] GameBoard = new string[9];
        int CurrentTurn = 0;

        public String ReturnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public void CheckForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = "";

                switch (i)
                {
                    case 0:
                        combination = GameBoard[0] + GameBoard[1] + GameBoard[2];
                        break;
                    case 1:
                        combination = GameBoard[3] + GameBoard[4] + GameBoard[5];
                        break;
                    case 2:
                        combination = GameBoard[6] + GameBoard[7] + GameBoard[8];
                        break;
                    case 3:
                        combination = GameBoard[0] + GameBoard[3] + GameBoard[6];
                        break;
                    case 4:
                        combination = GameBoard[1] + GameBoard[4] + GameBoard[7];
                        break;
                    case 5:
                        combination = GameBoard[2] + GameBoard[5] + GameBoard[8];
                        break;
                    case 6:
                        combination = GameBoard[0] + GameBoard[4] + GameBoard[8];
                        break;
                    case 7:
                        combination = GameBoard[2] + GameBoard[4] + GameBoard[6];
                        break;
                }

                if (combination.Equals("XXX"))
                {
                    MessageBox.Show("Ти переміг!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (combination.Equals("OOO"))
                {
                    MessageBox.Show("Ти програв)", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int boardIndex = 0;
            CurrentTurn++;
            GameBoard[boardIndex] = ReturnSymbol(CurrentTurn);
            button1.Text = GameBoard[boardIndex];
            button1.Enabled = false;
            CheckForWinner();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            const int boardIndex = 1;
            CurrentTurn++;
            GameBoard[boardIndex] = ReturnSymbol(CurrentTurn);
            button2.Text = GameBoard[boardIndex];
            button2.Enabled = false;
            CheckForWinner();
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            const int boardIndex = 2;
            CurrentTurn++;
            GameBoard[boardIndex] = ReturnSymbol(CurrentTurn);
            button3.Text = GameBoard[boardIndex];
            button3.Enabled = false;
            CheckForWinner();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            const int boardIndex = 3;
            CurrentTurn++;
            GameBoard[boardIndex] = ReturnSymbol(CurrentTurn);
            button4.Text = GameBoard[boardIndex];
            button4.Enabled = false;
            CheckForWinner();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            const int boardIndex = 4;
            CurrentTurn++;
            GameBoard[boardIndex] = ReturnSymbol(CurrentTurn);
            button5.Text = GameBoard[boardIndex];
            button5.Enabled = false;
            CheckForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const int boardIndex = 5;
            CurrentTurn++;
            GameBoard[boardIndex] = ReturnSymbol(CurrentTurn);
            button6.Text = GameBoard[boardIndex];
            button6.Enabled = false;
            CheckForWinner();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            const int boardIndex = 6;
            CurrentTurn++;
            GameBoard[boardIndex] = ReturnSymbol(CurrentTurn);
            button7.Text = GameBoard[boardIndex];
            button7.Enabled = false;
            CheckForWinner();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            const int boardIndex = 7;
            CurrentTurn++;
            GameBoard[boardIndex] = ReturnSymbol(CurrentTurn);
            button8.Text = GameBoard[boardIndex];
            button8.Enabled = false;
            CheckForWinner();
        }

  
        private void button9_Click(object sender, EventArgs e)
        {
            const int boardIndex = 8;
            CurrentTurn++;
            GameBoard[boardIndex] = ReturnSymbol(CurrentTurn);
            button9.Text = GameBoard[boardIndex];
            button9.Enabled = false;
            CheckForWinner();
        }

    

  

       
    }
}
