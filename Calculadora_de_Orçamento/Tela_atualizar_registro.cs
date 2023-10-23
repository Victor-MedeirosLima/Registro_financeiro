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
    public partial class Tela_atualizar_registro : Form
    {   
        private readonly Usuario usuario;
        public Tela_atualizar_registro(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private async void Tela_atualizar_registro_Load(object sender, EventArgs e)
        {
            string id = usuario.Id;
            comboBox_descricao.Items.Clear();
            Conexao conexao = new Conexao();


            List<string> valores = await conexao.BuscarValoresTodosAsync(id);

            foreach (string valor in valores)
            {
                comboBox_descricao.Items.Add(valor);
            }

            if (comboBox_descricao.Items.Count > 0)
            {
                comboBox_descricao.SelectedIndex = 0;
            }
        }

        private void Button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Tela_atualizar_registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tela_menu tela_Menu = new Tela_menu(usuario);
            tela_Menu.Show();
        }

        private void ComboBox_descricao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_atualizar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            string Descricao = comboBox_descricao.Text;

            string[] partes = Descricao.Split('|');

            if (partes.Length != 4)
            {
                
                return;
            }

            Descricao = partes[1];


            string Onde_alterar = comboBox_tipo_alteracao.Text;
            
            
            conexao.Atualizar_RegistroAsync(usuario.Id, Descricao, textBox_alteracao.Text, Onde_alterar);

            MessageBox.Show("Registor atualizado");

        }

    }
    
}
