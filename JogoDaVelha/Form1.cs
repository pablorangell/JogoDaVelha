namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        int Xplayer = 0, Oplayer = 0, empatesPontos = 0, rodadas = 0;
        bool turno = true, jogoFinal = false;
        string[] texto = new string[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;
            if (btn.Text == "" && jogoFinal == false) 
            { 
                if(turno)
                {
                    btn.Text = "X";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(1);
                }
                else
                {
                    btn.Text = "O";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(2);
                }
            }

            void Vencedor(int PlayerVencedor)
            {
                jogoFinal= true;

                if(PlayerVencedor == 1)
                {
                    Xplayer++;
                    XPontos.Text = Convert.ToString(Xplayer);
                    MessageBox.Show("Jogador X ganhou!");
                    turno = true;
                }
                else
                {
                    Oplayer++;
                    OPontos.Text = Convert.ToString(Oplayer);
                    MessageBox.Show("Jogador O ganhou!");
                    turno = false;
                }
            }

            void Checagem(int ChecagemPlayer)
            {
                string suporte = "";

                if(ChecagemPlayer == 1)
                {
                    suporte= "X";
                }
                else
                {
                    suporte= "O";
                }

                for(int horizontal = 0; horizontal < 8; horizontal += 3)
                {
                    if (suporte == texto[horizontal])
                    {
                        if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                        {
                            Vencedor(ChecagemPlayer);
                            return;
                        }
                    }
                }

                for (int vertical = 0; vertical < 3; vertical ++)
                {
                    if (suporte == texto[vertical])
                    {
                        if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                        {
                            Vencedor(ChecagemPlayer);
                            return;
                        }
                    }
                }

                if (texto[0] == suporte) 
                {
                    if (texto[0] == texto[4] && texto[0] == texto[8])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }

                if (texto[2] == suporte)
                {
                    if (texto[2] == texto[4] && texto[2] == texto[6])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }

                if(rodadas == 9 && jogoFinal == false)
                {
                    empatesPontos++;
                    Empates.Text = Convert.ToString(empatesPontos);
                    MessageBox.Show("O jogo empatou!");
                    jogoFinal = true;
                    return;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Jogador1_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            btn.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";

            rodadas = 0;
            jogoFinal= false;

            for(int i = 0; i < 9; i ++)
            {
                texto[i] = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Empates_Click(object sender, EventArgs e)
        {

        }
    }
}