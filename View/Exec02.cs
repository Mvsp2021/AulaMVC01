using AulaMVC01.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaMVC01.View
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void Exec02_Load(object sender, EventArgs e)
        {
            //List<string[]> lista = Controller2.SelectAll("Estaciona");

            //foreach (var item in lista)
            //{
            //    dgVagas.Rows.Add(item);
            //}

            AtualizaTudo();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exec02_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }


        private void AtualizaTudo()
        {
            dgVagas.Rows.Clear();
            cbPlacas.Items.Clear();
            cbVagasLivres.Items.Clear();
            //Data grid
            List<string[]> lista = Controller2.SelectAll("Estaciona");

            foreach (var item in lista)
            {
                dgVagas.Rows.Add(item);
            }
            //
            //cbVagasLivres
            List<string> listaVagas = Controller2.SelectAllFree();
            foreach (var item in listaVagas)
            {
                cbVagasLivres.Items.Add(item);
            }

            //
            //Placas
            List<string> listaPlacas = Controller2.SelectAllOccupied();

            foreach (var item in listaPlacas)
            {
                cbPlacas.Items.Add(item);
            }
            //
            cbVagasLivres.Text = "";
            cbPlacas.Text = "";
            txtHoraEntrada.Clear();
            txtHoraSaida.Clear();
            txtPlaca.Clear();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(Controller2.AtualizaEntrada(txtPlaca.Text, txtHoraEntrada.Text, cbVagasLivres.Text))
            {
                MessageBox.Show("Carro Estacionado");
            }
            else
            {
                MessageBox.Show("Algum valor estava incorreto");
            }
            AtualizaTudo();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            double valorFinal = Controller2.AtualizaSaida(cbPlacas.Text, txtHoraSaida.Text, rbS.Checked);

            if (valorFinal == -1)
            {
                MessageBox.Show("Placa não encontrada");
            }
            else if (valorFinal == -2)
            {
                MessageBox.Show("Preencha todos os campos!!!");
            }
            else
            {
                MessageBox.Show($"Valor final a pagar: {valorFinal:c}");
            }
            AtualizaTudo();
        }
    }
}
