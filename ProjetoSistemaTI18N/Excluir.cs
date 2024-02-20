using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaTI18N
{
    public partial class Excluir : Form
    {
        DAO conectar;
        public Excluir()
        {
            InitializeComponent();
            conectar = new DAO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text != "")
                {
                    conectar.Excluir(Convert.ToInt32(maskedTextBox1.Text));
                    maskedTextBox1.Text = "";//Limpa o campo
                }
                else
                {
                    MessageBox.Show("Impossível excluir, informe um código!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//Fim do botão excluir

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botão voltar

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo código
    }//Fim da classe
}//Fim do projeto
