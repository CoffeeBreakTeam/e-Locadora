﻿using e_Locadora.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.ParceirosModule
{
    public class Parceiro : EntidadeBase
    {
        public string nome { get; }

        public Parceiro(string parceiro)
        {
            this.nome = parceiro;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";
            if(string.IsNullOrEmpty(nome))
                resultadoValidacao = "O Nome do Parceiro é obrigatório .";
            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Parceiro);
        }

        public bool Equals(Parceiro other)
        {
            return other!=null &&
                   Id == other.Id &&
                   this.nome == other.nome;
        }
        public override string ToString()
        {
            return nome;
        }
        public override int GetHashCode()
        {
            int hashCode = 2069752152;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            return hashCode;
        }
    }
}
