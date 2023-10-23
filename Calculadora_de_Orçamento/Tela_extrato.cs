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
    public partial class Tela_extrato : Form
    {
        public Tela_extrato()
        {
            InitializeComponent();      

        }
        

        public Tela_extrato(string valor)
        {
            InitializeComponent();
            label1.Text = valor;
        }

        private void Tela_extrato_Load(object sender, EventArgs e)
        {

        }
    }
}
