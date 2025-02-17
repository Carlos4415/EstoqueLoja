﻿// Este programa gerencia o estoque de uma loja utilizando um dicionário (Dictionary<string, int>).  
// Os produtos são armazenados como chaves no dicionário, e suas quantidades correspondentes como valores.  
// O usuário pode consultar a quantidade em estoque informando o nome do produto.  
// O objetivo é demonstrar o uso de dicionários para armazenamento e recuperação de dados de forma eficiente.
Dictionary<string, int> estoque = new Dictionary<string, int>
{
    { "camisetas", 50 },
    { "calças", 30 },
    { "tênis", 20 }
    // Adicione mais produtos conforme necessário
};

string produto = "camisetas";

if (estoque.ContainsKey(produto))
{
    Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]} unidades.");
}
else
{
    Console.WriteLine("Produto não encontrado no estoque.");
}