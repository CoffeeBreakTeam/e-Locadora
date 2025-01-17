﻿using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.FuncionarioModule
{
    public class Funcionario : EntidadeBase
    {
        public string Nome { get; }
        public string NumeroCpf { get; }
        public string Usuario { get; }
        public string Senha { get; }
        public DateTime DataAdmissao { get; }
        public double Salario { get; }

        public Funcionario(string nome,string numeroCpf, string usuario, string senha, DateTime dataAdmissao, double salario)
        {
            Nome = nome;
            NumeroCpf = numeroCpf;
            Usuario = usuario;
            Senha = senha;
            DataAdmissao = dataAdmissao;
            Salario = salario;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao = "O atributo nome é obrigatório e não pode ser vazio.";

            if (string.IsNullOrEmpty(NumeroCpf))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O CPF digitado está inválido. Tente Novamente.";

            if (string.IsNullOrEmpty(Usuario))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O atributo usuário é obrigatório e não pode ser vazio.";

            if (string.IsNullOrEmpty(Senha))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O atributo senha é obrigatório e não pode ser vazio.";

            if (DataAdmissao > DateTime.Now)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "A data de admissão do funcionário não pode ser maior que a Data atual.";

            if(Salario <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O atributo salário é obrigatório e não pode ser vazio.";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Funcionario);
        }

        public  bool Equals(Funcionario obj)
        {
            return obj is Funcionario funcionario &&
                   Id == funcionario.Id &&
                   Nome == funcionario.Nome &&
                   NumeroCpf == funcionario.NumeroCpf &&
                   Usuario == funcionario.Usuario &&
                   Senha == funcionario.Senha &&
                   DataAdmissao == funcionario.DataAdmissao &&
                   Salario == funcionario.Salario;
        }

        public override int GetHashCode()
        {
            int hashCode = 1656116949;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NumeroCpf);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Usuario);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Senha);
            hashCode = hashCode * -1521134295 + DataAdmissao.GetHashCode();
            hashCode = hashCode * -1521134295 + Salario.GetHashCode();
            return hashCode;
        }
        

    }
}
