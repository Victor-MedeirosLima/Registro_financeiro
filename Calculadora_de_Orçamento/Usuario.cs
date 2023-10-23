using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Orçamento
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public double Calcula_saldo(List<string> Registros)
        {
            double Saldo = 0.0;
            string tipo, saldoT;

            foreach (string registro in Registros)
            {
                string[] valores = registro.Split('|');

                tipo = valores[0];
                if (tipo == "Ganho")
                {
                    saldoT = valores[3];

                    if (saldoT.Contains("."))
                    {
                        int indiceDoPonto = saldoT.IndexOf(".");
                        if (indiceDoPonto < saldoT.Length - 1)
                        {

                            Saldo += (double.Parse(saldoT) / 100);

                        }
                        else
                        {
                            Saldo += double.Parse(saldoT);

                        }


                    }
                    else
                    {
                        Saldo += double.Parse(saldoT);


                    }


                }
                else
                {
                    saldoT = valores[3];
                    if (saldoT.Contains("."))
                    {
                        int indiceDoPonto = saldoT.IndexOf(".");
                        if (indiceDoPonto < saldoT.Length - 1)
                        {

                            Saldo -= (double.Parse(saldoT) / 100);

                        }
                        else
                        {
                            Saldo -= double.Parse(saldoT);

                        }


                    }
                    else
                    {
                        Saldo -= double.Parse(saldoT);


                    }
                }
            }

            return Saldo;
        }


        public int[] Conta_tipo(List<string> Registros)
        {
            int[] itens = new int[2];
            int NGanho = 0;
            int NGasto = 0;

            foreach (string registro in Registros)
            {
                string[] valores = registro.Split('|');
                string tipo = valores[0];
                if (tipo == "Ganho")
                {
                    NGanho++;
                }
                else
                {
                    NGasto++;
                }


            }

            itens[0] = NGanho;
            itens[1] = NGasto;

            return itens;
        }

        public List<string> Registros_separado_tempo(List<string> Registros, int Periodo)
        {

            List<string> registrosFiltrados = new List<string>();

            
            DateTime dataAtual = DateTime.Now;

            foreach (string registro in Registros)
            {
                string[] valores = registro.Split('|');
                string dataString = valores[2];
                if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataRegistro))
                {
                    
                    int mesesDiferenca = ((dataAtual.Year - dataRegistro.Year) * 12) + dataAtual.Month - dataRegistro.Month;

                    
                    if ((Periodo == 1 && mesesDiferenca == 0) ||
                        (Periodo == 3 && mesesDiferenca >= 0 && mesesDiferenca <= 2) ||
                        (Periodo == 6 && mesesDiferenca >= 0 && mesesDiferenca <= 5) ||
                        (Periodo == 12 && mesesDiferenca >= 0 && mesesDiferenca <= 11) ||
                        (Periodo == 100)) 
                    {
                        registrosFiltrados.Add(registro);
                    }
                }
            }

            return registrosFiltrados;
        }


        

    }
}
