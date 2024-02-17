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
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do construtor

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void codigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do codigo

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim da telefone

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }//Fim do cidade

        private void estado_TextChanged(object sender, EventArgs e)
        {

        }//Fim do estado

        private void cadastrarBotao_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(codigo.Text);
            string name = nome.Text;
            string tel = telefone.Text;
            string cid = cidade.Text;
            string est = estado.Text;
            bd.Inserir(cod, name, tel, cid, est);//Inserindo no BD

            codigo.Text = "";
            nome.Text = "";
            telefone.Text = "";
            cidade.Text = "";
            estado.Text = "";

        }//Fim do cadastrar

        private void voltarBotao_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do voltar
    }//Fim da classe
}//Fim do projeto
