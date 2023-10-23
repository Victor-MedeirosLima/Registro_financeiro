namespace Calculadora_de_Orçamento
{
    partial class Tela_atualizar_registro
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
            this.comboBox_descricao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tipo_alteracao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_voltar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.textBox_alteracao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descrição";
            // 
            // comboBox_descricao
            // 
            this.comboBox_descricao.FormattingEnabled = true;
            this.comboBox_descricao.Items.AddRange(new object[] {
            "Gasto",
            "Ganho"});
            this.comboBox_descricao.Location = new System.Drawing.Point(12, 36);
            this.comboBox_descricao.MaxDropDownItems = 15;
            this.comboBox_descricao.Name = "comboBox_descricao";
            this.comboBox_descricao.Size = new System.Drawing.Size(158, 21);
            this.comboBox_descricao.TabIndex = 0;
            this.comboBox_descricao.SelectedIndexChanged += new System.EventHandler(this.ComboBox_descricao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de alteração";
            // 
            // comboBox_tipo_alteracao
            // 
            this.comboBox_tipo_alteracao.FormattingEnabled = true;
            this.comboBox_tipo_alteracao.Items.AddRange(new object[] {
            "Tipo",
            "Valor",
            "Data"});
            this.comboBox_tipo_alteracao.Location = new System.Drawing.Point(12, 88);
            this.comboBox_tipo_alteracao.Name = "comboBox_tipo_alteracao";
            this.comboBox_tipo_alteracao.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipo_alteracao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alteração";
            // 
            // button_voltar
            // 
            this.button_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(163, 197);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(75, 23);
            this.button_voltar.TabIndex = 4;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.Button_voltar_Click);
            // 
            // button_atualizar
            // 
            this.button_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar.Location = new System.Drawing.Point(48, 197);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(75, 23);
            this.button_atualizar.TabIndex = 3;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.Button_atualizar_Click);
            // 
            // textBox_alteracao
            // 
            this.textBox_alteracao.Location = new System.Drawing.Point(12, 141);
            this.textBox_alteracao.Name = "textBox_alteracao";
            this.textBox_alteracao.Size = new System.Drawing.Size(121, 20);
            this.textBox_alteracao.TabIndex = 2;
            // 
            // Tela_atualizar_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 247);
            this.Controls.Add(this.textBox_alteracao);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_tipo_alteracao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_descricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tela_atualizar_registro";
            this.Text = "Atualizar Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_atualizar_registro_FormClosed);
            this.Load += new System.EventHandler(this.Tela_atualizar_registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tipo_alteracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.TextBox textBox_alteracao;
    }
}