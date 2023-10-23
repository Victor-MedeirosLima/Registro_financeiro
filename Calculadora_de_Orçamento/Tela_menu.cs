using Google.Protobuf.WellKnownTypes;
using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Calculadora_de_Orçamento
{
    public partial class Tela_menu : Form
    {
        private readonly Usuario usuario;


        public Tela_menu(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            label_nome_usuario.Text = usuario.Nome;
            label_Id.Text = usuario.Id;
        }

        
        
        //Abre telas para mecher com os registros 
        private void Button_adicionar_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_cadastro_registro cadastro_Registro = new Tela_cadastro_registro( usuario );
            cadastro_Registro.Show();
        }

        private void Button_deletar_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_deletar_registro deletar_Registro = new Tela_deletar_registro(usuario);
            deletar_Registro.Show();
        }

        private void Button_Atualizar_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_atualizar_registro atualizar_Registro = new Tela_atualizar_registro(usuario);
            atualizar_Registro.Show();
        }

        
        //Fechando telas
        private void Tela_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Tela_Acesso tela_Acesso = new Tela_Acesso();
            tela_Acesso.Show();
            
        }

        private void Button_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Acesso tela_Acesso = new Tela_Acesso();
            tela_Acesso.Show();
        }

        //Deleta a conta logada
        private async void Button_deletar_conta_Click(object sender, EventArgs e)
        {   
           
            string id = usuario.Id;
            string email = usuario.Email;


            Conexao conexao = new Conexao();

            DialogResult resposta = MessageBox.Show("Tem certeza em excluir a conta ?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(resposta == DialogResult.Yes)
            {
                conexao.Delete_ContaAsync(id, email);
                MessageBox.Show("Conta excluida");
                this.Close();
            }
            else
            {
                MessageBox.Show("Conta não excluida");
            }


            



        }

        private int periodo = 1;
        private async void Tela_menu_Load(object sender, EventArgs e)
        {
            
            button_periodo.Text = $"Período: {periodo} meses";
            // Preenche a tabela

            Conexao conexao = new Conexao();
            string id = usuario.Id;
            List<string> Registros = await conexao.BuscarValoresTodosAsync(id);
            List<string> Registros_filtrados = usuario.Registros_separado_tempo(Registros, periodo);

            Preenche_tabela_registros(Registros_filtrados);


            //calcula saldo total 
            double saldo = usuario.Calcula_saldo(Registros);

            Define_cor_saldo(saldo);

            //grafico pizza
            Grafico_pizza(Registros_filtrados);

            Grafico_coluna(Registros_filtrados);
        }

        private void Button_lista_registros_Click(object sender, EventArgs e)
        {
            bool visivel = dataGridView_registros.Visible;
            
            
            if(visivel == false)
            {
                visivel = true;
                dataGridView_registros.Visible = visivel;
            }
            else
            {
                visivel = false;
                dataGridView_registros.Visible = visivel;
            }
        }





        public void Preenche_tabela_registros(List<string> Registros)
        {

            dataGridView_registros.Rows.Clear();
            dataGridView_registros.ColumnCount = 4;
            dataGridView_registros.ColumnHeadersVisible = true;

            dataGridView_registros.Columns[0].Name = "Tipo";
            dataGridView_registros.Columns[1].Name = "Descrição";
            dataGridView_registros.Columns[2].Name = "Data";
            dataGridView_registros.Columns[3].Name = "Valor";

            foreach (string registro in Registros)
            {
                string[] valores = registro.Split('|');
                if (valores.Length == 4)
                {
                    dataGridView_registros.Rows.Add(valores);
                }
            }

        }


        public void Define_cor_saldo(double saldo)
        {
            
            if (saldo >= 0)
            {
                label_valor_saldo.ForeColor = Color.Green;
            }
            if (saldo < 0)
            {
                label_valor_saldo.ForeColor = Color.Red;
            }

            label_valor_saldo.Text = saldo.ToString("F2");
        }

        public void Grafico_pizza(List<string> Registros)
        {   chart1.Series.Clear();
            var valor = usuario.Conta_tipo(Registros);
            string[] tipos = new string[2];
            tipos[0] = "Ganho";
            tipos[1] = "Gasto";
            chart1.Series.Add("Registrospizza");

            chart1.Series[0].ChartType = SeriesChartType.Pie;

            chart1.Series[0].Points.DataBindXY(tipos, valor);
            chart1.Series["Registrospizza"].Points[0].Color = Color.Green;
            chart1.Series["Registrospizza"].Points[1].Color = Color.Red;

        }


        public void Grafico_coluna(List<string> Registros)
        {   
            
            chart2.Series.Clear();
            chart2.Series.Add("Registroscoluna");

            
            chart2.Series[0].ChartType = SeriesChartType.Column;
            chart2.Series["Registroscoluna"].BorderWidth = 4;

            DateTime dataAtual = DateTime.Now;

            // Dicionário para armazenar os saldos por mês
            Dictionary<string, double> saldosPorMes = new Dictionary<string, double>();

            // Itere sobre os registros
            foreach (string registro in Registros)
            {
                string[] valores = registro.Split('|');
                if (valores.Length >= 4)
                {
                    string dataString = valores[2];
                    if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataRegistro))
                    {
                        // Calcule a diferença de meses
                        _ = ((dataAtual.Year - dataRegistro.Year) * 12) + dataAtual.Month - dataRegistro.Month;



                        string saldoT;
                        saldoT = valores[3];
                        double saldo;
                        if (saldoT.Contains("."))
                        {
                            int indiceDoPonto = saldoT.IndexOf(".");
                            if (indiceDoPonto < saldoT.Length - 1)
                            {
                                saldo = (double.Parse(saldoT) / 100);

                            }
                            else
                            {
                                saldo = double.Parse(saldoT);

                            }


                        }
                        else
                        {   
                            saldo = double.Parse(saldoT);

                        }


                        



                        string mesAno = dataRegistro.ToString("MM/yyyy");

                        // Se o mês/ano ainda não estiver no dicionário, adicione-o; caso contrário, some ao saldo existente
                        if (saldosPorMes.ContainsKey(mesAno))
                        {
                            saldosPorMes[mesAno] += saldo;
                        }
                        else
                        {
                            saldosPorMes[mesAno] = saldo;
                        }


                        


                    }
                }
            }


            // Adicione os valores ao gráfico
            foreach (var kvp in saldosPorMes)
            {
                chart2.Series["Registroscoluna"].Points.AddXY(kvp.Key, kvp.Value);
            }

            // Defina o formato de data no eixo X
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/yyyy";



        }


        private async void Button_periodo_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string id = usuario.Id;
            List<string> Registros = await conexao.BuscarValoresTodosAsync(id);
            List<string> Registros_filtrados = usuario.Registros_separado_tempo(Registros, periodo);

            Preenche_tabela_registros(Registros_filtrados);
            Grafico_pizza(Registros_filtrados);
            Grafico_coluna(Registros_filtrados);

            if (periodo == 1)
            {
                periodo = 3;
                
            }
            else if (periodo == 3)
            {
                periodo = 6;
                
            }
            else if (periodo == 6)
            {
                periodo = 12;
                
            }
            else if (periodo == 12)
            {
                periodo = 100;
            }
            else
            {
                periodo = 1;
            }

            button_periodo.Text = $"Período: {periodo} meses";
            

        }
    }


    


}
