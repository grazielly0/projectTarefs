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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArredondarBotao (Visualizar, 22);
            ArredondarBotao(visualizar2, 22);
            ArredondarBotao(visualizar3, 22);
            ArredondarBotao(visualizar4, 22);

            //caixa

            ArredondarCaixa(caixa1, 22);
            ArredondarCaixa2(caixa2, 22);
            ArredondarCaixa2(caixa3, 22);
            ArredondarCaixa2(caixa4, 22);


            //criar 

            ArredondarBotao(criar, 40);

            // não fez
            ArredondarBotao(naoFez1, 22);
            ArredondarBotao(naoFez2, 22);
            ArredondarBotao(naoFez3, 22);
            ArredondarBotao(naoFez4, 22);


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

        private void ArredondarCaixa2(MaskedTextBox caixa, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(caixa.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(caixa.Width - raio, caixa.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, caixa.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            caixa.Region = new Region(path);
        } // Fim

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
          


        }//visualizar label 1

        private void caixa1_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void caixa3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void caixa2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void caixa2_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void caixa3_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
