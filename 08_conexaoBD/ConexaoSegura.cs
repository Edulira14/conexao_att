using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _08_conexaoBD
{
    internal class ConexaoSegura
    {
        string host = "localhost";
        string banco = "08_lista_tarefas";
        string usuario = "root";
        string senha = "senac";

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dados;


        public ConexaoSegura()
        {
            if (conexao == null)
            {
                string dadosConexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
                conexao = new MySqlConnection(dadosConexao);
            }
       
        }

        public void executaQuery(string query)
        {
            try
            {
                conexao.Open();

                comando = new MySqlCommand(query, conexao);
                dados = comando.ExecuteReader();

                Console.WriteLine("--------------------");
                if (!dados.HasRows)
                {
                    Console.WriteLine("Nenhum resultado encontrado D: ");
                }

                while (dados.Read() == true)
                {
                    Console.WriteLine("Tarefa" + dados["id"] + " - " + dados["descricao"]);
                }

                
            }
            catch (Exception erro) 
            {
                Console.WriteLine("Erro ao realizar consulta");
                Console.WriteLine(erro.Message);
                
            }
            finally 
            {
                conexao.Close(); 
            }

            
        }

    }
}
