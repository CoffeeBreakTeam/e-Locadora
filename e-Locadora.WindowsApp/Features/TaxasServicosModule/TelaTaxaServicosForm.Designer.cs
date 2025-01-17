﻿
namespace e_Locadora.WindowsApp.Features.TaxasServicosModule
{
    partial class TelaTaxaServicosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taxaDiaria = new System.Windows.Forms.RadioButton();
            this.taxaFixa = new System.Windows.Forms.RadioButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTaxaFixa = new System.Windows.Forms.TextBox();
            this.textTaxaDiaria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taxaDiaria
            // 
            this.taxaDiaria.AutoSize = true;
            this.taxaDiaria.Location = new System.Drawing.Point(73, 19);
            this.taxaDiaria.Name = "taxaDiaria";
            this.taxaDiaria.Size = new System.Drawing.Size(52, 17);
            this.taxaDiaria.TabIndex = 38;
            this.taxaDiaria.Text = "Diária";
            this.taxaDiaria.UseVisualStyleBackColor = true;
            this.taxaDiaria.CheckedChanged += new System.EventHandler(this.taxaDiaria_CheckedChanged);
            // 
            // taxaFixa
            // 
            this.taxaFixa.AutoSize = true;
            this.taxaFixa.Location = new System.Drawing.Point(6, 19);
            this.taxaFixa.Name = "taxaFixa";
            this.taxaFixa.Size = new System.Drawing.Size(44, 17);
            this.taxaFixa.TabIndex = 37;
            this.taxaFixa.Text = "Fixa";
            this.taxaFixa.UseVisualStyleBackColor = true;
            this.taxaFixa.CheckedChanged += new System.EventHandler(this.taxaFixa_CheckedChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(74, 88);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(165, 20);
            this.txtDescricao.TabIndex = 35;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(74, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 20);
            this.txtId.TabIndex = 34;
            this.txtId.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Valor Fixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Descricao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Id";
            // 
            // textTaxaFixa
            // 
            this.textTaxaFixa.Location = new System.Drawing.Point(74, 114);
            this.textTaxaFixa.Name = "textTaxaFixa";
            this.textTaxaFixa.Size = new System.Drawing.Size(165, 20);
            this.textTaxaFixa.TabIndex = 42;
            // 
            // textTaxaDiaria
            // 
            this.textTaxaDiaria.Location = new System.Drawing.Point(74, 140);
            this.textTaxaDiaria.Name = "textTaxaDiaria";
            this.textTaxaDiaria.Size = new System.Drawing.Size(165, 20);
            this.textTaxaDiaria.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Valor Diário";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(166, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 23);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(85, 166);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(73, 23);
            this.btnGravar.TabIndex = 45;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taxaFixa);
            this.groupBox1.Controls.Add(this.taxaDiaria);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 44);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Taxa";
            // 
            // TelaTaxaServicosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 201);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.textTaxaDiaria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTaxaFixa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaTaxaServicosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Taxas e Serviços";
            this.Load += new System.EventHandler(this.TelaTaxaServicosForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton taxaDiaria;
        private System.Windows.Forms.RadioButton taxaFixa;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTaxaFixa;
        private System.Windows.Forms.TextBox textTaxaDiaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}