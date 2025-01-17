﻿using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Dominio.ClientesModule;
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

namespace e_Locadora.WindowsApp.ClientesModule
{
    public partial class TabelaClientesControl : UserControl
    {
        private readonly ControladorClientes controladorClientes;


        public TabelaClientesControl(ControladorClientes controladorClientes)
        {
            InitializeComponent();
            gridClientes.ConfigurarGridZebrado();
            gridClientes.ConfigurarGridSomenteLeitura();
            gridClientes.Columns.AddRange(ObterColunas());
            this.controladorClientes = controladorClientes;

        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn {DataPropertyName = "RG", HeaderText = "Numero RG"},

                new DataGridViewTextBoxColumn {DataPropertyName = "CPF", HeaderText = "Numero CPF"},

                 new DataGridViewTextBoxColumn {DataPropertyName = "CNPJ", HeaderText = "Numero CNPJ"},

                 new DataGridViewTextBoxColumn {DataPropertyName = "Email", HeaderText = "Email Cliente"}

            };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridClientes.SelecionarId<int>();
        }
       
        public void AtualizarRegistros()
        {      

            var clientes = controladorClientes.SelecionarTodos();

            CarregarTbela(clientes);

        }
   
        private void CarregarTbela(List<Clientes> clientes)
        {
            gridClientes.DataSource = clientes;    
        }

    }
}
