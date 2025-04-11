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

namespace projectTarefa
{
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {

            atu = new DAO();
            InitializeComponent();
            caixa8.ReadOnly = false;
            caixa5.ReadOnly = true;
            caixa6.ReadOnly = true;
           // dateTimePicker1.ReadOnly = true;



            InitializeComponent();
        }

        private void prioridade_Enter(object sender, EventArgs e)
        {

        }

        private void Atualizar_Load(object sender, EventArgs e)
        {
            ArredondarBotao(atualize, 22);

            //caixa

            ArredondarCaixa(caixa5, 22);
            ArredondarCaixa(caixa6, 22);
            //ArredondarCaixa(dateTimePicker1, 22);
            ArredondarCaixa(caixa8, 22);
            ArredondarCaixa2(prioridade1, 22);




            //volta

            ArredondarBotao(voltar, 40);
            ArredondarBotao(busca, 40);
            ArredondarBotao(atualize, 40);
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

        private void atualize_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(caixa8.Text);
            string titulo = caixa5.Text;
            string descricao = caixa6.Text;
           // string dataVencimento = .Text;
            string prioridade = prioridade1.Text;



            atu.Atualizar(codigo, "titulo", titulo);
            atu.Atualizar(codigo, "descricao", descricao);
            atu.Atualizar(codigo, "prioridade",prioridade);
            MessageBox.Show("Dados atualizados com sucesso!");
            this.Close();
        }

        private void busca_Click(object sender, EventArgs e)
        {
            if (caixa8.Text == "")
            {
                caixa5.Text = "Preencha os campos!";
                caixa6.Text = "Preencha os campos!";
               // prioridade1.Text = "Preencha os campos!";
                prioridade1.Text = "Preencha os campos!";
            }
            else
            {
                int codigo = Convert.ToInt32(caixa8.Text);
                caixa5.Text = atu.Retornartitulo(codigo);
                caixa6.Text = atu.Retornardescricao(codigo);
                dateTimePicker1.Text = (string)atu.RetornardataVencimento(codigo);
                prioridade1.Text = atu.RetornarPrioridade(codigo);
                caixa8.ReadOnly = true;

                caixa8.ReadOnly = true;
                caixa5.ReadOnly = false;
                caixa6.ReadOnly = false;
                prioridade1.Enabled = false;
            }
        }

        public string RemoverCampoData(string data)
        {
            string dt = data.Replace("/", "");
            string dia = dt.Substring(0, 2);
            string mes = dt.Substring(2, 2);
            string ano = dt.Substring(4, 4);

            return $"{ano}-{mes}-{dia}";
        }//fim da remoção

        public DateTime TransformarData(Object dataVencimento)
        {
            string dt = dataVencimento.ToString();
            string data = dt.Replace("-", "");
            string dia = data.Substring(0, 4);
            string mes = data.Substring(4, 2);
            string ano = data.Substring(6, 2);

            return Convert.ToDateTime($"{dia}/{mes}/{ano}");
        }//fim do método
    }

}

