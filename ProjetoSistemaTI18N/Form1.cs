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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }//Método construtor

        private void Menu_Load(object sender, EventArgs e)
        {

        }//Faz o carregamento de conteúdos da minha tela

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Aparecer a tela cadastrar
        }//Fim do cadastrar

        private void consultar_Click(object sender, EventArgs e)
        {
            Consultar con = new Consultar();//Conexão com BD
            con.ShowDialog();//Mostar a tela
        }//Fim do consultar

        private void atualizar_Click(object sender, EventArgs e)
        {
            Atualizar atu = new Atualizar();
            atu.ShowDialog();
        }//Fim do atualizar

        private void deletar_Click(object sender, EventArgs e)
        {

        }//Fim do deletar
    }//Fim da classe
}//Fim do projeto
