﻿
namespace e_Locadora.WindowsApp.GrupoVeiculoModule
{
    partial class TelaGrupoVeiculoForm
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.labelPlanoControladoFixo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlanoControladoValorDiario = new System.Windows.Forms.TextBox();
            this.txtPlanoControladoValorKm = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labeld = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.TbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlanoDiarioValorKm = new System.Windows.Forms.TextBox();
            this.txtPlanoDiarioValorDiario = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPlanoControladoQtdKm = new System.Windows.Forms.TextBox();
            this.labelQuantidadeKm = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlanoLivreValorDiario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(135, 219);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 70;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(216, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(167, 40);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 2;
            // 
            // labelPlanoControladoFixo
            // 
            this.labelPlanoControladoFixo.AutoSize = true;
            this.labelPlanoControladoFixo.Location = new System.Drawing.Point(6, 35);
            this.labelPlanoControladoFixo.Name = "labelPlanoControladoFixo";
            this.labelPlanoControladoFixo.Size = new System.Drawing.Size(68, 13);
            this.labelPlanoControladoFixo.TabIndex = 7;
            this.labelPlanoControladoFixo.Text = "Valor Por Km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor Diário";
            // 
            // txtPlanoControladoValorDiario
            // 
            this.txtPlanoControladoValorDiario.Location = new System.Drawing.Point(104, 6);
            this.txtPlanoControladoValorDiario.Name = "txtPlanoControladoValorDiario";
            this.txtPlanoControladoValorDiario.Size = new System.Drawing.Size(134, 20);
            this.txtPlanoControladoValorDiario.TabIndex = 5;
            // 
            // txtPlanoControladoValorKm
            // 
            this.txtPlanoControladoValorKm.Location = new System.Drawing.Point(104, 32);
            this.txtPlanoControladoValorKm.Name = "txtPlanoControladoValorKm";
            this.txtPlanoControladoValorKm.Size = new System.Drawing.Size(134, 20);
            this.txtPlanoControladoValorKm.TabIndex = 6;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(164, 24);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 11;
            this.labelCategoria.Text = "Categoria";
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Location = new System.Drawing.Point(12, 21);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(18, 13);
            this.labeld.TabIndex = 13;
            this.labeld.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(15, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(104, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // TbControl
            // 
            this.TbControl.Controls.Add(this.tabPage1);
            this.TbControl.Controls.Add(this.tabPage2);
            this.TbControl.Controls.Add(this.tabPage3);
            this.TbControl.Location = new System.Drawing.Point(15, 82);
            this.TbControl.Name = "TbControl";
            this.TbControl.SelectedIndex = 0;
            this.TbControl.Size = new System.Drawing.Size(252, 113);
            this.TbControl.TabIndex = 81;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtPlanoDiarioValorKm);
            this.tabPage1.Controls.Add(this.txtPlanoDiarioValorDiario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(244, 87);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plano Diário";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor Por Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Diário";
            // 
            // txtPlanoDiarioValorKm
            // 
            this.txtPlanoDiarioValorKm.Location = new System.Drawing.Point(104, 32);
            this.txtPlanoDiarioValorKm.Name = "txtPlanoDiarioValorKm";
            this.txtPlanoDiarioValorKm.Size = new System.Drawing.Size(134, 20);
            this.txtPlanoDiarioValorKm.TabIndex = 12;
            // 
            // txtPlanoDiarioValorDiario
            // 
            this.txtPlanoDiarioValorDiario.Location = new System.Drawing.Point(104, 6);
            this.txtPlanoDiarioValorDiario.Name = "txtPlanoDiarioValorDiario";
            this.txtPlanoDiarioValorDiario.Size = new System.Drawing.Size(134, 20);
            this.txtPlanoDiarioValorDiario.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPlanoControladoQtdKm);
            this.tabPage2.Controls.Add(this.labelQuantidadeKm);
            this.tabPage2.Controls.Add(this.labelPlanoControladoFixo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtPlanoControladoValorKm);
            this.tabPage2.Controls.Add(this.txtPlanoControladoValorDiario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(244, 87);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plano Controlado";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtPlanoControladoQtdKm
            // 
            this.txtPlanoControladoQtdKm.Location = new System.Drawing.Point(104, 58);
            this.txtPlanoControladoQtdKm.Name = "txtPlanoControladoQtdKm";
            this.txtPlanoControladoQtdKm.Size = new System.Drawing.Size(134, 20);
            this.txtPlanoControladoQtdKm.TabIndex = 9;
            // 
            // labelQuantidadeKm
            // 
            this.labelQuantidadeKm.AutoSize = true;
            this.labelQuantidadeKm.Location = new System.Drawing.Point(6, 61);
            this.labelQuantidadeKm.Name = "labelQuantidadeKm";
            this.labelQuantidadeKm.Size = new System.Drawing.Size(95, 13);
            this.labelQuantidadeKm.TabIndex = 8;
            this.labelQuantidadeKm.Text = "Quantidade de Km";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtPlanoLivreValorDiario);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(244, 87);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Plano Livre";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor Diário";
            // 
            // txtPlanoLivreValorDiario
            // 
            this.txtPlanoLivreValorDiario.Location = new System.Drawing.Point(104, 6);
            this.txtPlanoLivreValorDiario.Name = "txtPlanoLivreValorDiario";
            this.txtPlanoLivreValorDiario.Size = new System.Drawing.Size(134, 20);
            this.txtPlanoLivreValorDiario.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.TbControl);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.labeld);
            this.groupBox1.Controls.Add(this.labelCategoria);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 201);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Grupo de Veículo";
            // 
            // TelaGrupoVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaGrupoVeiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Grupo de Veículo";
            this.TbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPlanoControladoValorDiario;
        private System.Windows.Forms.TextBox txtPlanoControladoValorKm;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelPlanoControladoFixo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl TbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtPlanoControladoQtdKm;
        private System.Windows.Forms.Label labelQuantidadeKm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlanoDiarioValorKm;
        private System.Windows.Forms.TextBox txtPlanoDiarioValorDiario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlanoLivreValorDiario;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}