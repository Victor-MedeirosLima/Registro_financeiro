using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora_de_Orçamento
{
    public partial class Tela_deletar_registro : Form
    {
        private readonly Usuario usuario;
        public Tela_deletar_registro(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        private async void Tela_deletar_registro_Load(object sender, EventArgs e)
        {
            comboBox_tipo.Text = "Selecione";

        }


        // Fecha e abre janela

        private void Button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tela_deletar_registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tela_menu tela_Menu = new Tela_menu(usuario);
            tela_Menu.Show();
        }

        private void Button_deletar_Click(object sender, EventArgs e)
        {
            string id = usuario.Id;
            Conexao conexao = new Conexao();
            conexao.Deletar_registro(id,comboBox_descricao.Text);
        }

        //ao escolher o tipo ele carrega o as opçoes a serem excluidas

        private async void ComboBox_tipo_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = usuario.Id;
            comboBox_descricao.Items.Clear();
            Conexao conexao = new Conexao();


            List<string> valores = await conexao.BuscarValoresAsync(id, comboBox_tipo.Text);

            foreach (string valor in valores)
            {
                comboBox_descricao.Items.Add(valor);
            }

            if (comboBox_descricao.Items.Count > 0)
            {
                comboBox_descricao.SelectedIndex = 0;
            }
        }



    }
}
