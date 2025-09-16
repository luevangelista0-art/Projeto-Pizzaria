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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblValorpizza = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.chkTempero = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 474);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValorpizza);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblValorpizza;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.CheckBox chkTempero;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.CheckBox chkBorda;
    }
}

