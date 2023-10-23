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
    public partial class Tela_cadastro_registro : Form
    {

        private readonly Usuario usuario;

        public Tela_cadastro_registro(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }

        private void Tela_informe_de_renda_Load(object sender, EventArgs e)
        {
            comboBox_tipo.Text = "Selecione";
        }

        

        public void Button_adicionar_renda_Click(object sender, EventArgs e )
        {   
            string Tipo = comboBox_tipo.Text;
            if ( (Tipo != "Ganho") && (Tipo != "Gasto"))
            {
                MessageBox.Show("Selecione uma opção valida(Gasto ou Ganho)");
                comboBox_tipo.Text = "Selecione";
            }
            else
            {
                string Descricao = textBox_descricao.Text;
                if(Descricao == "")
                {
                    MessageBox.Show("Preencha a Descrição");
                }
                else
                {
                    string valor = textBox_valor.Text;
                    if (decimal.TryParse(valor, out _) == false)
                    {
                        MessageBox.Show("Insira um valor numerico");
                    }
                    else
                    {
                        string data = textBox_data.Text;
                        if (data == "")
                        {
                            MessageBox.Show("Preencha a Data (dd/mm/yyyy)");
                        }
                        else
                        {
                            string Id = this.usuario.Id;
                            _ = decimal.Parse(valor);


                            Conexao.Cadastro_RegistroAsync(Descricao, Id, Tipo, valor, data);
                            MessageBox.Show("Cadastro feito com sucesso");
                        }
                    }
                }
            } 
            
            


        }

        private void Button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tela_cadastro_registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tela_menu tela_Menu = new Tela_menu(usuario) ;
            tela_Menu.Show();
        }
    }
}
