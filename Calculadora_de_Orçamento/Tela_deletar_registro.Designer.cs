namespace Calculadora_de_Orçamento
{
    partial class Tela_deletar_registro
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_descricao = new System.Windows.Forms.ComboBox();
            this.button_voltar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo";
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "Gasto",
            "Ganho"});
            this.comboBox_tipo.Location = new System.Drawing.Point(12, 36);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipo.TabIndex = 0;
            this.comboBox_tipo.SelectedValueChanged += new System.EventHandler(this.ComboBox_tipo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Descrição";
            // 
            // comboBox_descricao
            // 
            this.comboBox_descricao.FormattingEnabled = true;
            this.comboBox_descricao.Items.AddRange(new object[] {
            "Gasto",
            "Ganho"});
            this.comboBox_descricao.Location = new System.Drawing.Point(12, 88);
            this.comboBox_descricao.Name = "comboBox_descricao";
            this.comboBox_descricao.Size = new System.Drawing.Size(175, 21);
            this.comboBox_descricao.TabIndex = 1;
            // 
            // button_voltar
            // 
            this.button_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(163, 136);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(75, 23);
            this.button_voltar.TabIndex = 3;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.Button_voltar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletar.Location = new System.Drawing.Point(48, 136);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 2;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.Button_deletar_Click);
            // 
            // Tela_deletar_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 211);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_descricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_tipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tela_deletar_registro";
            this.Text = "Deletar Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_deletar_registro_FormClosed);
            this.Load += new System.EventHandler(this.Tela_deletar_registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_descricao;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button button_deletar;
    }
}