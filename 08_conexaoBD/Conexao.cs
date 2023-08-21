using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_conexaoBD
{
    internal class Conexao
    {
        const string host = "localhost";
        const string banco = "08_lista_tarefas";
        const string usuario = "root";
        const string senha = "senac";

        const string dadosConexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
        static MySqlConnection conexao = new MySqlConnection(dadosConexao);

        MySqlCommand comando;
        MySqlDataReader dados;


        public static DataTable executaQuery(string query)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataReader dados = comando.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(dados);

                return tabela;
            }
            catch (Exception erro) 
            {
                Console.WriteLine("Erro ao realizar consulta");
                Console.WriteLine(erro.Message);
                return null;
            }
            finally 
            {
                conexao.Close(); 
            }

            
        }

    }
}
