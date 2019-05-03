using System;
using static System.Console;
using static System.DateTime;

namespace BookManager
{
  class Program
  {
    static void Main(string[] args)
    {
      WriteLine($"BookManager Iniciados às {Now.ToShortDateString()}");
      while (true)
        ShowMenu();
    }

    private static void ShowMenu()
    {
      WriteLine("Escolha uma das opções abaixo:");
      WriteLine("1. Adicionar um novo livro");
      WriteLine("2. Listar livros cadastrados");
      WriteLine("3. Remover um livro");

      string opcao = ReadLine();

      switch (opcao)
      {
        case "1":
          AdicionarNovoLivro();
          break;
        case "2":
          ListarLivros();
          break;
        case "3":
          RemoveLivro();
          break;
        default:
          WriteLine("Opção Inválida!");
          break;
      }
    }

    private static void RemoveLivro()
    {

    }

    private static void ListarLivros()
    {

    }

    private static void AdicionarNovoLivro()
    {

    }
  }
}
