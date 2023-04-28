using Funcionario.Dominio;
using System;
using System.Data;
using System.Collections.Generic;

Funcionario1 user = new Funcionario1();

user.CPF = 123432177;
user.RG = 1234556;
user.Nome = "Joao";
user.DataNascimento = new DateTime(1990, 03,01);
user.DataAdmissão = new DateTime (2003, 04,01);
user.Email = "marcos@exemplo.com";

user.Incluir();


List<Funcionario1> listaFuncionarios = new List<Funcionario1>();

Funcionario1 user2 = new Funcionario1();
user2.CPF = 123432177;
user2.RG = 1234556;
user2.Nome = "Joao";
user2.DataNascimento = new DateTime(1990, 03, 01);
user2.DataAdmissão = new DateTime(2003, 04, 01);
user2.Email = "marcos@exemplo.com";

listaFuncionarios.Add(user2);


Funcionario1 user3 = new Funcionario1();
user3.CPF = 987654321;
user3.RG = 654321;
user3.Nome = "Maria";
user3.DataNascimento = new DateTime(1985, 06, 15);
user3.DataAdmissão = new DateTime(2005, 07, 01);
user3.Email = "maria@exemplo.com";

listaFuncionarios.Add(user3);

Funcionario1 user4 = new Funcionario1();
user4.CPF = 0759860;
user4.RG = 6546321;
user4.Nome = "Perdo";
user4.DataNascimento = new DateTime(1945, 06, 25);
user4.DataAdmissão = new DateTime(2015, 09, 01);
user4.Email = "pedro@exemplo.com";

listaFuncionarios.Add(user4);


foreach (Funcionario1 funcionario in listaFuncionarios)
{
    Console.WriteLine($"Nome: {funcionario.Nome}");
    Console.WriteLine($"CPF: {funcionario.CPF}");
    Console.WriteLine($"RG: {funcionario.RG}");
    Console.WriteLine($"Data de Nascimento: {funcionario.DataNascimento.ToShortDateString()}");
    Console.WriteLine($"Data de Admissão: {funcionario.DataAdmissão.ToShortDateString()}");
    Console.WriteLine($"Email: {funcionario.Email}");
    Console.WriteLine("---------------------------");
}
