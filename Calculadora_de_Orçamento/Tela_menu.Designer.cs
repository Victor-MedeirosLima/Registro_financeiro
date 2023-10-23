namespace Calculadora_de_Orçamento
{
    partial class Tela_menu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.button_adicionar_registro = new System.Windows.Forms.Button();
            this.button_deletar_registro = new System.Windows.Forms.Button();
            this.button_Atualizar_registro = new System.Windows.Forms.Button();
            this.button_lista_registros = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nome_usuario = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.button_deletar_conta = new System.Windows.Forms.Button();
            this.label_valor_saldo = new System.Windows.Forms.Label();
            this.dataGridView_registros = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Saldo = new System.Windows.Forms.Label();
            this.button_periodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_registros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_adicionar_registro
            // 
            this.button_adicionar_registro.Location = new System.Drawing.Point(20, 63);
            this.button_adicionar_registro.Name = "button_adicionar_registro";
            this.button_adicionar_registro.Size = new System.Drawing.Size(75, 68);
            this.button_adicionar_registro.TabIndex = 0;
            this.button_adicionar_registro.Text = "Cadastro";
            this.button_adicionar_registro.UseVisualStyleBackColor = true;
            this.button_adicionar_registro.Click += new System.EventHandler(this.Button_adicionar_registro_Click);
            // 
            // button_deletar_registro
            // 
            this.button_deletar_registro.Location = new System.Drawing.Point(101, 63);
            this.button_deletar_registro.Name = "button_deletar_registro";
            this.button_deletar_registro.Size = new System.Drawing.Size(75, 68);
            this.button_deletar_registro.TabIndex = 1;
            this.button_deletar_registro.Text = "Deletar";
            this.button_deletar_registro.UseVisualStyleBackColor = true;
            this.button_deletar_registro.Click += new System.EventHandler(this.Button_deletar_registro_Click);
            // 
            // button_Atualizar_registro
            // 
            this.button_Atualizar_registro.Location = new System.Drawing.Point(182, 63);
            this.button_Atualizar_registro.Name = "button_Atualizar_registro";
            this.button_Atualizar_registro.Size = new System.Drawing.Size(75, 68);
            this.button_Atualizar_registro.TabIndex = 2;
            this.button_Atualizar_registro.Text = "Atualizar";
            this.button_Atualizar_registro.UseVisualStyleBackColor = true;
            this.button_Atualizar_registro.Click += new System.EventHandler(this.Button_Atualizar_registro_Click);
            // 
            // button_lista_registros
            // 
            this.button_lista_registros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_lista_registros.Location = new System.Drawing.Point(1121, 137);
            this.button_lista_registros.Name = "button_lista_registros";
            this.button_lista_registros.Size = new System.Drawing.Size(75, 23);
            this.button_lista_registros.TabIndex = 3;
            this.button_lista_registros.Text = "Registros";
            this.button_lista_registros.UseVisualStyleBackColor = true;
            this.button_lista_registros.Click += new System.EventHandler(this.Button_lista_registros_Click);
            // 
            // button_sair
            // 
            this.button_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sair.Location = new System.Drawing.Point(1121, 197);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 5;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.Button_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registros";
            // 
            // label_nome_usuario
            // 
            this.label_nome_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nome_usuario.AutoSize = true;
            this.label_nome_usuario.Location = new System.Drawing.Point(1124, 47);
            this.label_nome_usuario.Name = "label_nome_usuario";
            this.label_nome_usuario.Size = new System.Drawing.Size(35, 13);
            this.label_nome_usuario.TabIndex = 6;
            this.label_nome_usuario.Text = "Nome";
            // 
            // label_Id
            // 
            this.label_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(1124, 77);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(16, 13);
            this.label_Id.TabIndex = 7;
            this.label_Id.Text = "Id";
            // 
            // button_deletar_conta
            // 
            this.button_deletar_conta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_deletar_conta.Location = new System.Drawing.Point(1121, 167);
            this.button_deletar_conta.Name = "button_deletar_conta";
            this.button_deletar_conta.Size = new System.Drawing.Size(124, 23);
            this.button_deletar_conta.TabIndex = 4;
            this.button_deletar_conta.Text = "Deletar conta";
            this.button_deletar_conta.UseVisualStyleBackColor = true;
            this.button_deletar_conta.Click += new System.EventHandler(this.Button_deletar_conta_Click);
            // 
            // label_valor_saldo
            // 
            this.label_valor_saldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_valor_saldo.AutoSize = true;
            this.label_valor_saldo.Location = new System.Drawing.Point(1192, 107);
            this.label_valor_saldo.Name = "label_valor_saldo";
            this.label_valor_saldo.Size = new System.Drawing.Size(34, 13);
            this.label_valor_saldo.TabIndex = 9;
            this.label_valor_saldo.Text = "Saldo";
            // 
            // dataGridView_registros
            // 
            this.dataGridView_registros.AllowUserToAddRows = false;
            this.dataGridView_registros.AllowUserToDeleteRows = false;
            this.dataGridView_registros.AllowUserToResizeColumns = false;
            this.dataGridView_registros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_registros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_registros.Location = new System.Drawing.Point(20, 167);
            this.dataGridView_registros.Name = "dataGridView_registros";
            this.dataGridView_registros.ReadOnly = true;
            this.dataGridView_registros.Size = new System.Drawing.Size(324, 456);
            this.dataGridView_registros.TabIndex = 10;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(350, 41);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(518, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(350, 347);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(518, 268);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Location = new System.Drawing.Point(1124, 107);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(34, 13);
            this.Saldo.TabIndex = 13;
            this.Saldo.Text = "Saldo";
            // 
            // button_periodo
            // 
            this.button_periodo.Location = new System.Drawing.Point(897, 57);
            this.button_periodo.Name = "button_periodo";
            this.button_periodo.Size = new System.Drawing.Size(75, 23);
            this.button_periodo.TabIndex = 14;
            this.button_periodo.UseVisualStyleBackColor = true;
            this.button_periodo.Click += new System.EventHandler(this.Button_periodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(911, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Periodo";
            // 
            // Tela_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_periodo);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label_valor_saldo);
            this.Controls.Add(this.button_lista_registros);
            this.Controls.Add(this.button_Atualizar_registro);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.button_adicionar_registro);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_deletar_registro);
            this.Controls.Add(this.button_deletar_conta);
            this.Controls.Add(this.label_nome_usuario);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView_registros);
            this.Controls.Add(this.label1);
            this.Name = "Tela_menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_menu_FormClosed);
            this.Load += new System.EventHandler(this.Tela_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_registros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_adicionar_registro;
        private System.Windows.Forms.Button button_deletar_registro;
        private System.Windows.Forms.Button button_Atualizar_registro;
        private System.Windows.Forms.Button button_lista_registros;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nome_usuario;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button button_deletar_conta;
        private System.Windows.Forms.Label label_valor_saldo;
        private System.Windows.Forms.DataGridView dataGridView_registros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label Saldo;
        private System.Windows.Forms.Button button_periodo;
        private System.Windows.Forms.Label label2;
    }
}