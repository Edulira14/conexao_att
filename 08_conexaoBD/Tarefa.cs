using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _08_conexaoBD
{
    internal class Tarefa
    {
        public int id;
        public string descricao;
        public bool concluido;
        public string criado_em;

        public Tarefa()
        {

        }

        public Tarefa(int id, string descricao, bool concluido, string criado_em)
        {
            this.id = id;
            this.descricao = descricao;
            this.concluido = concluido;
            this.criado_em = criado_em;
        }

        public Tarefa Busca_id( int id )
        {
            string query = $"SELECT * FROM tarefas WHERE id = {id}; ";

            DataTable tabela = Conexao.executaQuery( query );

            Tarefa tarefa = CarregaDados( tabela.Rows[0] );
            return tarefa; 
        }

        public Tarefa Busca_Descricao(string descricao)
        {
            string query = $"SELECT * FROM tarefas WHERE descricao LIKE '%{descricao}%'; ";

            DataTable tabela = Conexao.executaQuery(query);

            Tarefa tarefa = CarregaDados(tabela.Rows[0]);
            return tarefa;
        }

        public Tarefa CarregaDados( DataRow linha)
        {
            int id = int.Parse( linha["id"].ToString() );
            string descricao = linha["descricao"].ToString();
            bool concluido = linha["conluido"].ToString() == "1" ? true : false;
            string criado_em = linha["criado_em"].ToString();

            Tarefa tarefa = new Tarefa(id, descricao, concluido, criado_em);
            return tarefa;
        }

    }
}
