using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDoDado
{
    public partial class Form1 : Form
    {
        int ptsjg1, ptsjg2, rodadas = 0;
        string mensagem = "";
        List<int> resjg1;
        List<int> resjg2;
        Random rnd = new Random();

        public void ResultadoParcial(int jog1, int jog2)
        {
            rodadas += 1;
            lblHeader.Text = "Rodada Nº " + (rodadas+1).ToString();

            if(jog1 > jog2)
            {
                ptsjg1 += 1;
                mensagem = "O Jogador 1 venceu a " + rodadas + "ª rodada!"; 
            }
            else if(jog2 > jog1)
            {
                ptsjg2 += 1;
                mensagem = "O Jogador 2 venceu a " + rodadas + "ª rodada!";
            }

            lblResultado.Text = mensagem;
            btnjg1.Enabled = true;
            btnjg2.Enabled = false;

            if(rodadas >= 2)
            {
                GeraResultado();
            }
        }

        public void GeraResultado()
        {
            if (ptsjg1 >= 2 && ptsjg1 > ptsjg2)
            {
                btnjg1.Enabled = false;
                btnjg2.Enabled = false;
                MessageBox.Show("O jogador 1 venceu a partida!!!");
                lblResultado.Text = "O jogador 1 venceu a partida!!!";
                btnReset.Enabled = true;
            }
            else if (ptsjg2 >= 2 && ptsjg2 > ptsjg1)
            {
                btnjg1.Enabled = false;
                btnjg2.Enabled = false;
                MessageBox.Show("O jogador 2 venceu a partida!!!");
                lblResultado.Text = "O jogador 2 venceu a partida!!!";
                btnReset.Enabled = true;
            }
        }

        public void Reset()
        {
            lblresjg1.Text = "";
            lblresjg2.Text = "";
            lblResultado.Text = "";
            btnjg1.Enabled = true;
            btnjg2.Enabled = false;
            btnReset.Enabled = false;
            ptsjg1 = 0;
            ptsjg2 = 0;
            rodadas = 0;
            mensagem = "";
            lblHeader.Text = "Rodada Nº " + (rodadas + 1).ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnjg1_Click(object sender, EventArgs e)
        {
            lblresjg1.Text = rnd.Next(1, 7).ToString();
            btnjg1.Enabled = false;
            btnjg2.Enabled = true;
        }

        private void btnjg2_Click(object sender, EventArgs e)
        {
            lblresjg2.Text = rnd.Next(1, 7).ToString();

            ResultadoParcial(Convert.ToInt32(lblresjg1.Text), Convert.ToInt32(lblresjg2.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
