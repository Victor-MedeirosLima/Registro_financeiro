namespace Calculadora_de_Orçamento
{
    partial class Tela_cadastro_registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_adicionar_renda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_voltar = new System.Windows.Forms.Button();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // textBox_valor
            // 
            this.textBox_valor.Location = new System.Drawing.Point(18, 144);
            this.textBox_valor.Name = "textBox_valor";
            this.textBox_valor.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe o valor";
            // 
            // button_adicionar_renda
            // 
            this.button_adicionar_renda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adicionar_renda.Location = new System.Drawing.Point(30, 264);
            this.button_adicionar_renda.Name = "button_adicionar_renda";
            this.button_adicionar_renda.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar_renda.TabIndex = 4;
            this.button_adicionar_renda.Text = "Adicionar";
            this.button_adicionar_renda.UseVisualStyleBackColor = true;
            this.button_adicionar_renda.Click += new System.EventHandler(this.Button_adicionar_renda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Informe a data de recebimento";
            // 
            // button_voltar
            // 
            this.button_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(182, 264);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(75, 23);
            this.button_voltar.TabIndex = 5;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.Button_voltar_Click);
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "Gasto",
            "Ganho"});
            this.comboBox_tipo.Location = new System.Drawing.Point(18, 36);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipo.TabIndex = 0;
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.Location = new System.Drawing.Point(18, 88);
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.Size = new System.Drawing.Size(100, 20);
            this.textBox_descricao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 10;
            this.label4.Tag = "";
            this.label4.Text = "Tipo";
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(18, 198);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(100, 20);
            this.textBox_data.TabIndex = 11;
            // 
            // Tela_cadastro_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 326);
            this.Controls.Add(this.textBox_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_tipo);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_adicionar_renda);
            this.Controls.Add(this.textBox_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_descricao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tela_cadastro_registro";
            this.Text = "Cadastro de Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_cadastro_registro_FormClosed);
            this.Load += new System.EventHandler(this.Tela_informe_de_renda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_adicionar_renda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_valor;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.TextBox textBox_descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_data;
    }
}