﻿using e_Locadora.Controladores.ParceiroModule;
using e_Locadora.Dominio.ParceirosModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.Features.ParceirosModule
{
    public partial class TabelaParceiroControl : UserControl
    {
        private readonly ControladorParceiro controlador;
        public TabelaParceiroControl(ControladorParceiro controlador)
        {
            InitializeComponent();
            gridParceiros.ConfigurarGridZebrado();
            gridParceiros.ConfigurarGridSomenteLeitura();
            gridParceiros.Columns.AddRange(ObterColunas());
            this.controlador = controlador;

        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "nome", HeaderText = "Nome do Parceiro"}
           };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridParceiros.SelecionarId<int>();
        }

        public void AtualizarRegistros()
        {

            var parceirosEcontrados = controlador.SelecionarTodos();

            CarregarTbela(parceirosEcontrados);

        }

        public void CarregarTbela(List<Parceiro> parceirosEcontrados)
        {
            gridParceiros.DataSource = parceirosEcontrados;
        }
    }
}
