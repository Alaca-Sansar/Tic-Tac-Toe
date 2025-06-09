using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        string[,] GamePlan = new string[3, 3];
        byte WinX;
        byte WinO;
        bool Victory = false;
        bool AnyEmpty = false;
        private void ButtonWrite(object sender)
        {
            Button ClickedButton = sender as Button;
            if (LabelPlayer.Text == "X" && ClickedButton.Text == " ")
            {
                ClickedButton.Text = "X";
                ClickedButton.ForeColor = Color.Red;
                LabelPlayer.Text = "O";
            }
            if (LabelPlayer.Text == "O" && ClickedButton.Text == " ")
            {
                ClickedButton.Text = "O";
                ClickedButton.ForeColor = Color.Blue;
                LabelPlayer.Text = "X";
            }
        }
        private void WinCheck()
        {
            AnyEmpty = false;
            for (int i = 0; i < 3; i++)
            {
                if (GamePlan[i, 0] == GamePlan[i, 1] && GamePlan[i, 1] == GamePlan[i, 2] && GamePlan[i, 0] != " ")
                {
                    switch (LabelPlayer.Text)
                    {
                        case "X": Win("O"); break;
                        case "O": Win("X"); break;
                    }
                }
                if (GamePlan[0, i] == GamePlan[1, i] && GamePlan[1, i] == GamePlan[2, i] && GamePlan[0, i] != " ")
                {
                    switch (LabelPlayer.Text)
                    {
                        case "X": Win("O"); break;
                        case "O": Win("X"); break;
                    }
                }
                if (Victory != true)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (GamePlan[i, y] == " ")
                        {
                            AnyEmpty = true;
                        }
                    }
                }
            }
            if (GamePlan[0, 0] == GamePlan[1, 1] && GamePlan[1, 1] == GamePlan[2, 2] && GamePlan[2, 2] != " ")
            {
                switch (LabelPlayer.Text)
                {
                    case "X": Win("O"); break;
                    case "O": Win("X"); break;
                }
            }
            if (GamePlan[0, 2] == GamePlan[1, 1] && GamePlan[1, 1] == GamePlan[2, 0] && GamePlan[0, 2] != " ")
            {
                switch (LabelPlayer.Text)
                {
                    case "X": Win("O"); break;
                    case "O": Win("X"); break;
                }
            }
            if (!Victory && AnyEmpty != true)
            {
                Console.Beep();
                MessageBox.Show("Beraberlik :)", "TicTacToe - Beraberlik!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
        private void Win(string Winner)
        {
            if (Winner == "X") { WinX++; }
            else { WinO++; }
            Console.Beep();
            MessageBox.Show("Kazanan Oyuncumuz: " + Winner + "\n Güncellenen Toplam Kazanmalar \n X : " + WinX + "\n O : " + WinO + "\n Unutmayýn TicTacToe basit bir oyundur.", "TicTacToe - KAZANANIMIZ !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XKazanma.Text = "Kazanma : " + WinX;
            OKazanma.Text = "Kazanma : " + WinO;
            Victory = true;

            Reset();
        }
        public void Reset()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    GamePlan[x, y] = " ";
                }
            }
            Victory = false;
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonWrite(sender);
            GamePlan[0, 0] = button1.Text;
            WinCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonWrite(sender);
            GamePlan[1, 0] = button2.Text;
            WinCheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonWrite(sender);
            GamePlan[2, 0] = button3.Text;
            WinCheck();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonWrite(sender);
            GamePlan[0, 1] = button4.Text;
            WinCheck();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonWrite(sender);
            GamePlan[1, 1] = button5.Text;
            WinCheck();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonWrite(sender);
            GamePlan[2, 1] = button6.Text;
            WinCheck();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonWrite(sender);
            GamePlan[0, 2] = button7.Text;
            WinCheck();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonWrite(sender);
            GamePlan[1, 2] = button8.Text;
            WinCheck();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonWrite(sender);
            GamePlan[2, 2] = button9.Text;
            WinCheck();
        }

        private void Sifirla_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun Þablonu [X,Y]" + "\n" + "[0,0]" + GamePlan[0, 0] + "[0,1]" + GamePlan[0, 1] + "[0,2]" + GamePlan[0, 2] + "\n" + "[1,0]" + GamePlan[1, 0] + "[1,1]" + GamePlan[1, 1] + "[1,2]" + GamePlan[1, 2] + "\n" + "[2,0]" + GamePlan[2, 0] + "[2, 1]" + GamePlan[2, 1] + "[2,2]" + GamePlan[2, 2] + "\n" + "Kazanma Durumu :" + Victory + " Boþluklar dolumu ? :" + AnyEmpty);
        }

    }
}
