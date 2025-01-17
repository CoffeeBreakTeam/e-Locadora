﻿using e_Locadora.Dominio.Shared;
using e_Locadora.Dominio.TaxasServicosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Dominio.LocacaoModule
{
    public class LocacaoTaxasServicos : EntidadeBase
    {
        public Locacao locacao { get; set; }
        public TaxasServicos taxasServicos { get; set; }

        public LocacaoTaxasServicos(Locacao locacao, TaxasServicos taxasServicos) 
        {
            this.locacao = locacao;
            this.taxasServicos = taxasServicos;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as LocacaoTaxasServicos);
        }

        public bool Equals(LocacaoTaxasServicos other)
        {
            return other != null
                && Id == other.Id
                && locacao.Equals(other.locacao)
                && taxasServicos.Equals(other.taxasServicos);
        }
        public override string Validar()
        {
            return "ESTA_VALIDO";
        }
    }
}
