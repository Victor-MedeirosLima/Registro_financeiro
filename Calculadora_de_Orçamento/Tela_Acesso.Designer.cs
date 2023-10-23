namespace Calculadora_de_Orçamento
{
    partial class Tela_Acesso
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
            this.label_Usuario = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Logar = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(612, 275);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label_Usuario.TabIndex = 0;
            this.label_Usuario.Text = "Usuário";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(582, 291);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(100, 20);
            this.textBox_usuario.TabIndex = 0;
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(582, 351);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(100, 20);
            this.textBox_senha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // Button_Logar
            // 
            this.Button_Logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Logar.Location = new System.Drawing.Point(537, 382);
            this.Button_Logar.Name = "Button_Logar";
            this.Button_Logar.Size = new System.Drawing.Size(75, 23);
            this.Button_Logar.TabIndex = 2;
            this.Button_Logar.Text = "Logar";
            this.Button_Logar.UseVisualStyleBackColor = true;
            this.Button_Logar.Click += new System.EventHandler(this.Button_Logar_Click_1);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrar.Location = new System.Drawing.Point(652, 382);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 3;
            this.button_cadastrar.Text = "Cadastra-se";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.Button_cadastrar_Click);
            // 
            // Tela_Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.Button_Logar);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tela_Acesso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_Acesso_FormClosed);
            this.Load += new System.EventHandler(this.Tela_Acesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Logar;
        private System.Windows.Forms.Button button_cadastrar;
    }
}