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
    public partial class Consultar : Form
    {
        DAO conectar;
        public Consultar()
        {
            InitializeComponent();
            conectar = new DAO();

            ConfigurarGrid();//Prepara a tabela do grid
            NomeColunas();//Preencher os nomes da colunas
            conectar.PreencherVetor();//Preencher com os dados do BD
            AdicionarDados();//Pegar os dados do vetor e colocar no grid
        }//Fim do construtor Consultar

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";//Dar um nome a coluna do dataGrid
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "Estado";
        }//Fim do método

        public void AdicionarDados()
        {
            for(int i = 0; i < conectar.RetornarContagem(); i++)
            {
                dataGridView1.Rows.Add(conectar.codigo[i], conectar.nome[i], 
                                       conectar.telefone[i], conectar.cidade[i], conectar.estado[i]);
            }//Fim do for
        }//Fim do método

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Para não adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Para não deletar linhas
            dataGridView1.AllowUserToResizeColumns= false;//Para não redimensionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//Para não redimensionar as linhas
            dataGridView1.ColumnCount = 5;//Quantidade de colunas
        }//Fim do ConfigurarGrid

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }//Fim do dataGrid

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do voltar
    }//Fim da classe
}
