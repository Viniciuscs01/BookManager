using System;
using System.Collections.Generic;

namespace BookManager.Models
{
  public class Livro
  {
    public static List<Livro> Livros { get; set; }

    public string Nome { get; set; } 
    public string Descricao { get; set; }
    public int Ano { get; set; }
    public DateTime DataLancamento { get; set; }
    public float Largura { get; set; }
    public float Altura { get; set; }
    public float Profundidade { get; set; }
    public string Dimensoes { get => $"{Largura} x {Altura} x {Profundidade}"; }

    public Livro(string nome)
    {
      Nome = nome;
    }
  }
}
