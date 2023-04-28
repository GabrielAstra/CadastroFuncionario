using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funcionario.Dominio
{
    public class Funcionario1
    {
        public int CPF { get; set; }
        
        public int RG { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataAdmissão { get; set; }

        public string Email { get; set; }


        public static List<Funcionario1> ListaFuncionarios = new List<Funcionario1>();

        public void Incluir()
        {
            ListaFuncionarios.Add(this);
        }

        public void Excluir()
        {
            ListaFuncionarios.Remove(this);
        }
        public static Funcionario1 Pesquisar(int cpf)
        {
            return ListaFuncionarios.Find(f => f.CPF == cpf);
        }

        public void CalcularFerias()
        {

        }
    }
}