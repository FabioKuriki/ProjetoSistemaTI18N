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
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] cidade;
        public string[] estado;
        public int i;
        public int contador;
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

        public void PreencherVetor()
        {
            string query = "select * from pessoa";

            //Instanciar os vetores
            codigo = new int[100];
            nome = new string[100];
            telefone = new string[100];
            cidade = new string[100];
            estado = new string[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                telefone[i] = "";
                cidade[i] = "";
                estado[i] = ""; 
            }//Fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contador
            contador = 0;//Contar quantos dados eu tenho no banco

            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);//Verifica se há dados no campo codigo e caso haja, sera retornado o dado na variável
                nome[i] = "" + leitura["nome"];//Nome é convertido pois sem "", o dado vem como OBJETO, ou seja, com varios dados
                telefone[i] = "" + leitura["telefone"];
                cidade[i] = "" + leitura["cidade"];
                estado[i] = "" + leitura["estado"];
                i++;//Mudando do contador
                contador++;//Contar quantos dados tem no banco
            }//Fim do while

            //Encerrar o banco
            leitura.Close();
        }//Fim do método

        public int RetornarContagem()
        {
            return contador;
        }//Fim do método

        public int SelecionarPorCodigo(int id)
        {
            PreencherVetor();
            for (int i = 0; i < RetornarContagem(); i++)
            {
                if (codigo[i] == id)
                {
                    return i;
                }
            }//Fim do for
            return -1;//Flag - Bandeira|Sinal
        }//Fim do método

        public void Atualizar(int codigo, string nome, string telefone, string cidade, string estado)
        {
            try
            {
                string query = "update pessoa set nome = '" + nome + "', telefone = '" + telefone + "', cidade = '" + cidade +
                               "', estado = '" + estado + "' where codigo = '" + codigo + "'";
                //Preparar o comando no BD
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + "\nAtualizado com sucesso!");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Impossível atualizar\n\n" + erro);
            }
        }//Fim do Atualizar

        public void Excluir(int id)
        {
            string query = "delete from pessoa where codigo = '" + id + "'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = "" + sql.ExecuteNonQuery();

            MessageBox.Show(resultado + "\ndado excluido");

        }//Fim do método Excluir
    }//Fim da classe
}//Fim do projeto
