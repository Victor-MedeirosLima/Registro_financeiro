using Amazon.DynamoDBv2.Model;
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
    public partial class Tela_Acesso : Form
    {
        public Tela_Acesso()
        {
            InitializeComponent();
        }

        

        

        private async void Button_Logar_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox_usuario.Text;
            string senha = textBox_senha.Text;      
            

            
            Dictionary<string, AttributeValue> resultado = await Conexao.Verifica_usuario(usuario);

            if (resultado != null)
            {
                if (resultado["E-mail"].S == usuario && resultado["Senha"].S == senha)
                {
                    Usuario usu = new Usuario
                    {
                        Nome = resultado["Nome"].S,
                        Id = resultado["Id "].S,
                        Email = resultado["E-mail"].S
                    };

                    Tela_menu tela_Menu = new Tela_menu(usu);
                    _ = new Tela_cadastro_registro(usu);
                    _ = new Tela_deletar_registro(usu);
                    _ = new Tela_atualizar_registro(usu);

                    MessageBox.Show("Login feito com sucesso");

                    this.Hide();
                    tela_Menu.Show();
                    textBox_usuario.Text = "";
                    textBox_senha.Text = "";

                }
                else
                {
                    MessageBox.Show("Usuario ou Senha incorretos");
                    textBox_usuario.Text = "";
                    textBox_senha.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Usuario não cadastrado");
                textBox_usuario.Text = "";
                textBox_senha.Text = "";
            }

        }

        private void Button_cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_cadastro_Usuario cadastro_Usuario =    new Tela_cadastro_Usuario();
            cadastro_Usuario.Show();
        }

        

        private void Tela_Acesso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Tela_Acesso_Load(object sender, EventArgs e)
        {

        }
    }
}
