namespace Calculadora_de_Orçamento
{
    partial class Tela_cadastro_Usuario
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
            this.textBox_cadastro_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cadastro_usuario = new System.Windows.Forms.TextBox();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.textBox_cadastro_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_cadastro_senha
            // 
            this.textBox_cadastro_senha.Location = new System.Drawing.Point(350, 201);
            this.textBox_cadastro_senha.Name = "textBox_cadastro_senha";
            this.textBox_cadastro_senha.PasswordChar = '*';
            this.textBox_cadastro_senha.Size = new System.Drawing.Size(100, 20);
            this.textBox_cadastro_senha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Senha";
            // 
            // textBox_cadastro_usuario
            // 
            this.textBox_cadastro_usuario.Location = new System.Drawing.Point(350, 162);
            this.textBox_cadastro_usuario.Name = "textBox_cadastro_usuario";
            this.textBox_cadastro_usuario.Size = new System.Drawing.Size(100, 20);
            this.textBox_cadastro_usuario.TabIndex = 0;
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(380, 146);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(35, 13);
            this.label_Usuario.TabIndex = 3;
            this.label_Usuario.Text = "Nome";
            // 
            // textBox_cadastro_email
            // 
            this.textBox_cadastro_email.Location = new System.Drawing.Point(350, 240);
            this.textBox_cadastro_email.Name = "textBox_cadastro_email";
            this.textBox_cadastro_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_cadastro_email.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "E-mail";
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrar.Location = new System.Drawing.Point(305, 281);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 3;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tela_cadastro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.textBox_cadastro_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cadastro_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cadastro_usuario);
            this.Controls.Add(this.label_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tela_cadastro_Usuario";
            this.Text = "Cadastro de Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_cadastro_Usuario_FormClosed);
            this.Load += new System.EventHandler(this.Tela_cadastro_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_cadastro_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cadastro_usuario;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.TextBox textBox_cadastro_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Button button1;
    }
}