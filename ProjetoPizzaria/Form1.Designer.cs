namespace ProjetoPizzaria
{
    partial class Form1
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
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.dvgPedido = new System.Windows.Forms.DataGridView();
            this.lblValorpizza = new System.Windows.Forms.Label();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.chkTempero = new System.Windows.Forms.CheckBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPedido)).BeginInit();
            this.grpOpcionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(6, 42);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(111, 17);
            this.chkCebola.TabIndex = 0;
            this.chkCebola.Text = "Cebola sem choro";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // dvgPedido
            // 
            this.dvgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPedido.Location = new System.Drawing.Point(266, 197);
            this.dvgPedido.Name = "dvgPedido";
            this.dvgPedido.Size = new System.Drawing.Size(465, 152);
            this.dvgPedido.TabIndex = 1;
            // 
            // lblValorpizza
            // 
            this.lblValorpizza.AutoSize = true;
            this.lblValorpizza.Location = new System.Drawing.Point(271, 22);
            this.lblValorpizza.Name = "lblValorpizza";
            this.lblValorpizza.Size = new System.Drawing.Size(95, 13);
            this.lblValorpizza.TabIndex = 2;
            this.lblValorpizza.Text = "VALOR DA PIZZA";
            this.lblValorpizza.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(266, 42);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(100, 20);
            this.txtValorPizza.TabIndex = 3;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(308, 397);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(12, 41);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(140, 21);
            this.cmbTamanhoPizza.TabIndex = 5;
            this.cmbTamanhoPizza.Text = "TAMANHO DA PIZZA";
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkTempero);
            this.grpOpcionais.Controls.Add(this.chkCatupiry);
            this.grpOpcionais.Controls.Add(this.chkBorda);
            this.grpOpcionais.Controls.Add(this.chkCebola);
            this.grpOpcionais.Location = new System.Drawing.Point(12, 81);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(200, 125);
            this.grpOpcionais.TabIndex = 6;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "Escolhas opcionais";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(416, 397);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(514, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(386, 22);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 9;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(536, 22);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 10;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(6, 19);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(107, 17);
            this.chkBorda.TabIndex = 1;
            this.chkBorda.Text = "Borda Recheada";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // chkCatupiry
            // 
            this.chkCatupiry.AutoSize = true;
            this.chkCatupiry.Location = new System.Drawing.Point(6, 65);
            this.chkCatupiry.Name = "chkCatupiry";
            this.chkCatupiry.Size = new System.Drawing.Size(102, 17);
            this.chkCatupiry.TabIndex = 2;
            this.chkCatupiry.Text = "Catupiry Original";
            this.chkCatupiry.UseVisualStyleBackColor = true;
            // 
            // chkTempero
            // 
            this.chkTempero.AutoSize = true;
            this.chkTempero.Location = new System.Drawing.Point(6, 88);
            this.chkTempero.Name = "chkTempero";
            this.chkTempero.Size = new System.Drawing.Size(68, 17);
            this.chkTempero.TabIndex = 3;
            this.chkTempero.Text = "Tempero";
            this.chkTempero.UseVisualStyleBackColor = true;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(404, 42);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 11;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(529, 42);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 12;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(448, 144);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 14;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(347, 148);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 13;
            this.lblPesquisar.Text = "PESQUISAR";
            this.lblPesquisar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(617, 397);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 474);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.lblValorpizza);
            this.Controls.Add(this.dvgPedido);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPedido)).EndInit();
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.DataGridView dvgPedido;
        private System.Windows.Forms.Label lblValorpizza;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.CheckBox chkTempero;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnSair;
    }
}

