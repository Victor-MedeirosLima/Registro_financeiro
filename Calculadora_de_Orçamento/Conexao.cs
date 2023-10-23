using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Calculadora_de_Orçamento
{
    internal class Conexao
    {


        public static async Task<Dictionary<string, AttributeValue>> Verifica_usuario(string emailD)
        {
            try
            {

                
                

                var client = new AmazonDynamoDBClient(accessKey, secretKey, RegionEndpoint.GetBySystemName(region));

                string tableName = "Usuarios";

                var table = Table.LoadTable(client, tableName);

                var searchFilter = new ScanFilter();
                searchFilter.AddCondition("E-mail", ScanOperator.Equal, emailD);
                

                var search = table.Scan(searchFilter);
                var searchResponse = await search.GetNextSetAsync();

                if (searchResponse.Count == 1)
                {
                    
                    var usuario = searchResponse[0];
                    return usuario.ToAttributeMap(); 
                }
                else
                {
                    
                    return null;
                }


            }            
            catch (Exception ex) {
                MessageBox.Show("erro"+ ex);
                return null;
                
            }
           




            
        }

        public static async Task<bool> Cadastro_UsuarioAsync(string id, string email, string nome, string senha)
        {
            try
            {
                

                

                var client = new AmazonDynamoDBClient(accessKey, secretKey, RegionEndpoint.GetBySystemName(region));

                string tableName = "Usuarios";



                var item = new Dictionary<string, AttributeValue>
                {
                    ["Id "] = new AttributeValue { S = id },
                    ["E-mail"] = new AttributeValue { S = email },
                    ["Nome"] = new AttributeValue { S = nome },
                    ["Senha"] = new AttributeValue { S = senha },
                };



                var request = new PutItemRequest
                {
                    TableName = tableName,
                    Item = item,
                };

                var response = await client.PutItemAsync(request);
                return response.HttpStatusCode == System.Net.HttpStatusCode.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro cadastro usuario" + ex);
                return false;
            }
        }


        public static int Contador_usuarios()
        {
            

            var client = new AmazonDynamoDBClient(accessKey, secretKey, RegionEndpoint.GetBySystemName(region));

            var tableName = "Usuarios";

            var table = Table.LoadTable(client, tableName);

            var scanFilter = new ScanFilter();
            var search = table.Scan(scanFilter);

            int itemCount = 0;

            do
            {
                var searchResponse = search.GetNextSetAsync();
                itemCount += searchResponse.Result.Count;
            } while (!search.IsDone);
            itemCount += 1;

            return itemCount;

        }




        public static async Task<bool> Cadastro_RegistroAsync(string descricao, string id_usuario, string tipo, string valor, string data)
        {
            try
            {
                

                var client = new AmazonDynamoDBClient(accessKey, secretKey, RegionEndpoint.GetBySystemName(region));
                string tableName = "Registros";

                var item = new Dictionary<string, AttributeValue>
                {
                    ["Descrição"] = new AttributeValue { S = descricao },
                    ["Id_Usuario"] = new AttributeValue { S = id_usuario },
                    ["Data"] = new AttributeValue { S = data },
                    ["Tipo"] = new AttributeValue { S = tipo },
                    ["Valor"] = new AttributeValue { S = valor }, 
                };

                var request = new PutItemRequest
                {
                    TableName = tableName,
                    Item = item,
                };

                var response = await client.PutItemAsync(request);
                return response.HttpStatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro cadastro registro" + ex);
                return false;
            }
        }


        public async Task<List<string>> BuscarValoresAsync(string Id, string Tipo)
        {

            



            var client = new AmazonDynamoDBClient(accessKey, secretKey, RegionEndpoint.GetBySystemName(region));
            

            string tableName = "Registros";

            Table tabela = Table.LoadTable(client, tableName);

            
            ScanFilter scanFilter = new ScanFilter();
            scanFilter.AddCondition("Id_Usuario", ScanOperator.Equal, Id);
            scanFilter.AddCondition("Tipo", ScanOperator.Equal, Tipo);

            
            Search search = tabela.Scan(scanFilter);
            List<string> resultados = new List<string>();

            
            List<Document> documentos = search.GetRemaining();
            foreach (Document documento in documentos)
            {
                string descricao = documento["Descrição"];
                string data = documento["Data"];
                string tipo = documento["Tipo"];
                string valor = documento["Valor"];

                
                string resultado = $"{tipo}|{descricao}|{data}|{valor}";
                resultados.Add(resultado);
            }

            return resultados;
        }
        
        public void Deletar_registro(string Id_Usuario, string Descricao)
        {
            



            var client = new AmazonDynamoDBClient(accessKey, secretKey, RegionEndpoint.GetBySystemName(region));


            string tableName = "Registros";



            string[] partes = Descricao.Split('|');
            if (partes.Length != 4)
            {
                
                return;
            }

            
            
            string descricao = partes[1];
            

            var request = new DeleteItemRequest
            {
                TableName = tableName,
                Key = new Dictionary<string, AttributeValue>
        {
            { "Descrição", new AttributeValue { S = descricao } },
            { "Id_Usuario", new AttributeValue { S = Id_Usuario } }
            
        }
            };

            client.DeleteItem(request);
            MessageBox.Show("Registro deletado");



        }


        public async Task<List<string>> BuscarValoresTodosAsync(string Id)
        {

            



            var client = new AmazonDynamoDBClient(accessKey, secretKey, RegionEndpoint.GetBySystemName(region));


            string tableName = "Registros";

            Table tabela = Table.LoadTable(client, tableName);

            
            ScanFilter scanFilter = new ScanFilter();
            scanFilter.AddCondition("Id_Usuario", ScanOperator.Equal, Id);
            

            
            Search search = tabela.Scan(scanFilter);
            List<string> resultados = new List<string>();

            
            List<Document> documentos = search.GetRemaining();
            foreach (Document documento in documentos)
            {
                string descricao = documento["Descrição"];
                string data = documento["Data"];
                string tipo = documento["Tipo"];
                string valor = documento["Valor"];

                
                string resultado = $"{tipo}|{descricao}|{data}|{valor}";
                resultados.Add(resultado);
            }

            return resultados;
        }



        public  async Task<bool> Atualizar_RegistroAsync(string Id_Usuario,string Descricao, string mudança, string Onde_alterar)
        {

            



            var client = new AmazonDynamoDBClient(accessKey, secretKey, RegionEndpoint.GetBySystemName(region));


            string tableName = "Registros";

            var key = new Dictionary<string, AttributeValue>
            {
                ["Descrição"] = new AttributeValue { S = Descricao },
                ["Id_Usuario"] = new AttributeValue { S = Id_Usuario },
                
            };

            var updates = new Dictionary<string, AttributeValueUpdate>
            {
                [$"{Onde_alterar}"] = new AttributeValueUpdate
                {
                    Action = AttributeAction.PUT,
                    Value = new AttributeValue { S = mudança },
                },

                
            };

            var request = new UpdateItemRequest
            {
                AttributeUpdates = updates,
                Key = key,
                TableName = tableName,
            };

            var response = await client.UpdateItemAsync(request);

            return response.HttpStatusCode == System.Net.HttpStatusCode.OK;

            
        }



        public async  Task<bool>Delete_ContaAsync(string id, string email)
        {
            try
            {
                

                var client = new AmazonDynamoDBClient(accessKey, secretKey, RegionEndpoint.GetBySystemName(region));

                var tableName = "Usuarios";

                var key = new Dictionary<string, AttributeValue>
                {
                    ["Id "] = new AttributeValue { S = id },
                    ["E-mail"] = new AttributeValue { S = email },
                    
                };

                var request = new DeleteItemRequest
                {
                    TableName = tableName,
                    Key = key,
                };

                var response = await client.DeleteItemAsync(request);
                
                return response.HttpStatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message);   
                return false;
            }
        }

    }
}













