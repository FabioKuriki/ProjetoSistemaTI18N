using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoSistemaTI18N
{
    class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public string sql;
        public DAO()
        {
            conexao = new MySqlConnection("Server = localhost; Database = TI18N; Uid = root; Password =");
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");
            }catch(Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                conexao.Close();
            }//Fim do catch
        }//Fim da DAO

        public void Inserir(int codigo, string nome, string telefone, string cidade, string estado)
        {
            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + cidade + "','" + estado + "')";
            sql = "insert into pessoa(codigo, nome, telefone, cidade, estado) values " + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);//Prepara o comando no banco de dados
                MessageBox.Show(conn.ExecuteNonQuery() + " dado inserido");//Executar o comando no banco de dados
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//Fim do método Inserir
    }//Fim da classe
}//Fim do projeto
