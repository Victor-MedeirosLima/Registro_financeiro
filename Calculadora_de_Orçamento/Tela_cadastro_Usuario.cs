using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Orçamento
{
    public partial class Tela_cadastro_Usuario : Form
    {
        public Tela_cadastro_Usuario()
        {
            InitializeComponent();
            
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {   
            string nome = textBox_cadastro_usuario.Text;
            string senha = textBox_cadastro_senha.Text;
            string email = textBox_cadastro_email.Text;

            if (nome == "" || senha == "" || email == "")
            {
                MessageBox.Show("Complete todos os campos ");
            }
            else
            {
                int numero_usuarios = Conexao.Contador_usuarios();
                string id = numero_usuarios.ToString();

                Conexao.Cadastro_UsuarioAsync(id, email, nome, senha);

                MessageBox.Show("Cadastro feito com sucesso");

                this.Hide();
                Tela_Acesso tela_Acesso = new Tela_Acesso();
                tela_Acesso.Show();

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Tela_cadastro_Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tela_Acesso tela_Acesso = new Tela_Acesso();
            tela_Acesso.Show();
        }

        private void Tela_cadastro_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
