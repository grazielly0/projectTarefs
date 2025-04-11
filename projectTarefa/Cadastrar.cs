using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace projectTarefa
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

          
        

            // não fez
           /// ArredondarBotao(naoFez1, 22);
           /// ArredondarBotao(naoFez2, 22);
           // ArredondarBotao(naoFez3, 22);
           // ArredondarBotao(naoFez4, 22);
        }

        private void ArredondarBotao(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            botao.Region = new Region(path);
        } // Fim

        /*
        private void ArredondarDate(dateTimePicker1 dt, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(dt.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(dt.Width - raio, dt.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, dt.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            dt.Region = new Region(path);
        } // Fi m
        */


        private void ArredondarCaixa(TextBox caixa, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(caixa.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(caixa.Width - raio, caixa.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, caixa.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            caixa.Region = new Region(path);
        } // Fim


        private void ArredondarCaixa2(ComboBox caixa, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(caixa.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(caixa.Width - raio, caixa.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, caixa.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            caixa.Region = new Region(path);
        } // Fim
        





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }// fim do button baixo 

        private void button2_Click(object sender, EventArgs e)
        {

        }// fim do button medio

        private void button3_Click(object sender, EventArgs e)
        {

        }// fim do butrton alta

        private void button4_Click(object sender, EventArgs e)
        {
            DAO inserir = new DAO();

            int codigo = Convert.ToInt32(caixa8.Text);
            string titulo = caixa5.Text;
            string descricao = caixa6.Text;
            string dataVencimento = RemoverCampoData(dateTimePicker1.Text);
            MessageBox.Show(dataVencimento + "");
            string prioridade = prioridade1.Text;
           



            MessageBox.Show(inserir.Inserir(codigo,
                            titulo,
                            descricao,
                            dataVencimento,
                            prioridade));
            this.Close();




        }//fimm do cadastrar

        public string RemoverCampoData(string data)
        {
            string dt = data.Replace("/", "");
            string dia = dt.Substring(0, 2);
            string mes = dt.Substring(2, 2);
            string ano = dt.Substring(4, 4);

            return $"{ano}-{mes}-{dia}";
        }//fim da remoção

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }// fim do volta 

        private void label7_Click_1(object sender, EventArgs e)
        {

        }// label baixa

        private void baixa_TextChanged(object sender, EventArgs e)
        {

        }

        private void media_TextChanged(object sender, EventArgs e)
        {

        }

        private void alta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa7_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa8_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa5_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            ArredondarBotao(cadastro, 22);

            //caixa

            ArredondarCaixa(caixa5, 22);
            ArredondarCaixa(caixa6, 22);
            //ArredondarCaixa(dateTimePicker1, 22);
            ArredondarCaixa(caixa8, 22);
            ArredondarCaixa2(prioridade1, 22);
           



            //volta

            ArredondarBotao(voltar, 40);

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//fim do prioridade

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
