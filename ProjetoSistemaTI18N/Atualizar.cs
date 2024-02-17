using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaTI18N
{
    public partial class Atualizar : Form
    {
        DAO conectar;
        public Atualizar()
        {
            InitializeComponent();
            conectar = new DAO();
        }//Fim do construtor

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo codigo

        private void buscarBotao_Click(object sender, EventArgs e)
        {
            try
            {
                int id = conectar.SelecionarPorCodigo(Convert.ToInt32(maskedTextBox1.Text));//Buscando o código digitado
                if (id == -1)
                {
                    MessageBox.Show("Código digitado não existe!");
                    maskedTextBox1.Text = "";
                    textBox1.Text = "";
                    maskedTextBox2.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    //Substituir os campos
                    maskedTextBox1.Enabled = false;//Bloqueia o acesso ao campo código
                    textBox1.Text = conectar.nome[id];
                    maskedTextBox2.Text = conectar.telefone[id];
                    textBox2.Text = conectar.cidade[id];
                    textBox3.Text = conectar.estado[id];
                }//Fim do else
            }
            catch(Exception erro)
            {
                MessageBox.Show("Preencha o campo com o código\n\n" + erro);
            }
            
        }//Fim do buscar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo nome

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo telefone

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo cidade

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo estado

        private void atualizarBotao_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text != "")
                {
                    int id = Convert.ToInt32(maskedTextBox1.Text);
                    string nome = textBox1.Text;
                    string telefone = maskedTextBox2.Text;
                    string cidade = textBox2.Text;
                    string estado = textBox3.Text;
                    conectar.Atualizar(id, nome, telefone, cidade, estado);

                    //Limpar os campos
                    maskedTextBox1.Enabled = true;
                    maskedTextBox1.Text = "";
                    textBox1.Text = "";
                    maskedTextBox2.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor , informe um código e clique em buscar");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n" + erro);
            }//Fim do catch
        }//Fim do campo atualizar

        private void voltarButao_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do voltar
    }//Fim da classe
}//Fim do Projeto
