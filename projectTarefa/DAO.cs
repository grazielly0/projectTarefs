using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace projectTarefa
{


    class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] titulo;
        public string[] descricao;
        public DateTime[] dataVencimento;
        public string[] prioridade;
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=Tintcsharp;Uid=root;password=;Convert Zero Datetime=True");
            try
            {
                conexao.Open();//tentando conectar com o banco 

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n\n" + erro);
            }
        }//fim do construtror


        public string Inserir(int codigo, string titulo, string descricao, string dataVencimento, string prioriade)
        {
            string inserir = $"insert into tarefa( codigo, titulo, descricao, dataVencimento, prioridade) values(' {codigo}', '{titulo}', '{descricao}', '{dataVencimento}', '{prioriade}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Execultado";
            return resultado;
        }
       public int ConsultarPorCodigo(int cod)
       {
            //instanciar os vetores 
             PreencherVetor();
            i = 0;
            while (i < QuantidadeDados())
            {
            if (codigo[i] == cod)
            {
                   return i;
            }
                i++;
            }//fim do while
            return -1;
            //encerrar o processso da leitura
       }

       public string Retornartitulo(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
           if (posicao > -1)
           {
               return titulo[posicao];
           }
            return "Código digitado inválido!";
        }

        public string Retornardescricao(int cod)
        {
           int posicao = ConsultarPorCodigo(cod);

           if (posicao > -1)
            {
                return descricao[posicao];
            }
            return "Código digitado inválido!";
        }

         public Object RetornardataVencimento(int cod)
         {
           int posicao = ConsultarPorCodigo(cod);
          if (posicao > -1)
         {
              return dataVencimento[posicao];
         }
             return new DateTime();
          }

        public DateTime TransformarData(Object dataVencimento)
        {
            string dt = dataVencimento.ToString();
            string data = dt.Replace("-", "");
            string dia = data.Substring(0, 4);
            string mes = data.Substring(4, 2);
            string ano = data.Substring(6, 2);

            return Convert.ToDateTime($"{dia}/{mes}/{ano}");
        }//fim do método

        public string RetornarPrioridade(int cod)
         {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)

            {
                return prioridade[posicao];
            }
            return "Código digitado inválido!";
          }

        public void PreencherVetor()
        {
        string query = "select * from pessoa";
            // instanciar os vetores           

        this.codigo = new int[100];
        this.titulo = new string[100];
        this.descricao = new string[100];
        this.dataVencimento = new DateTime[100];
        this.prioridade = new string[100];

                ///repara o comando para o banco 

            MySqlCommand sql = new MySqlCommand(query, conexao);

                // chamar o leitor de banco de dados 

             MySqlDataReader leitura = sql.ExecuteReader();

                i = 0;
                contador = 0; //


        while (leitura.Read())
        {
          codigo[i] = Convert.ToInt32(leitura["codigo"]);
          titulo[i] = leitura["titulo"] + "";
          descricao[i] = leitura["descricao"] + "";
          dataVencimento[i] = Convert.ToDateTime(leitura["dataVencimento"]); 
          prioridade[i] = leitura["prioridade"] + "";
            i++;
            contador++;
        }//fim do while

            //encerrar o processso da leitura
            leitura.Close();

        }//fim do metodo 

        public int QuantidadeDados()
        {
            return contador;
        }

       public string Atualizar(int codigo, string campo, string dado)
       {
            string query = $"update tarefa set {campo} = '{dado}' Where codigo = '{codigo}'";
           MySqlCommand sql = new MySqlCommand(query, conexao);
           string resultado = sql.ExecuteNonQuery() + "Atualizado!";
           return resultado; 

       }

        public string Excluir(int codigo)
        {
            string query = $"delete from pessoa where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
           string resultado = sql.ExecuteNonQuery() + "Deletado!";
          return resultado;
        }

     }//fim da DAO
 }//fim do projeto 
