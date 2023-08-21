// See https://aka.ms/new-console-template for more information
using _08_conexaoBD;
using System.Data;

//Console.WriteLine("Hello, World!");
//ConexaoSimples conexaoSimples = new ConexaoSimples();

//ConexaoSegura conexaoFlexivel= new ConexaoSegura();
//conexaoFlexivel.executaQuery("SELECT * FROM tarefas;");
//conexaoFlexivel.executaQuery("SELECT * FROM tarefas WHERE id = 4;");
//conexaoFlexivel.executaQuery("SELECT * FROM tarefas WHERE descricao LIKE '%tud%';");
//Tarefa tarefa = new Tarefa();
//tarefa = tarefa.Busca_id(3);
//Console.WriteLine($"Tarefa {tarefa.id} - {tarefa.descricao}");
//Console.Write($" criado{tarefa.criado_em}");

Console.WriteLine("Seja bem-vindo ao sistema do Lira'Consults");
Console.WriteLine("Digite o ID da tarefa que deseja consultar: ");
//int id = int.Parse(Console.ReadLine());

//Tarefa tarefa = new Tarefa();
//tarefa = tarefa.Busca_id(id);


Console.WriteLine("Digite 1 para consultar ID ou 2 para consultar DESCRIÇÃO:");
string opcao = Console.ReadLine();

Tarefa tarefa = new Tarefa();

if (opcao == "1")
{
    Console.WriteLine("Digite o ID da tarefa que deseja consultar: ");
    int id = int.Parse(Console.ReadLine());
    tarefa = tarefa.Busca_id(id);
}
else
{
    Console.WriteLine("Digite a DESCRIÇÃO que deseja encontar:");
    string descricao = Console.ReadLine();
    tarefa = tarefa.Busca_Descricao(descricao);
}

Console.WriteLine("\nResultados encontrados:");
Console.WriteLine($"Tarefa {tarefa.id} - {tarefa.descricao}");
Console.WriteLine($" | criado em {tarefa.criado_em}");


