using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porcentagemforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dinheiro, taxa, investimento;
            int mes, contagem = 1;

            dinheiro = double.Parse(textBox1.Text);
            taxa = double.Parse(textBox2.Text);
            investimento = taxa / 100;
            mes = int.Parse(textBox3.Text);
            

            while (contagem <= mes){
                dinheiro = dinheiro + (dinheiro * investimento);
               listBox1.Items.Add("o valor do seu investimento no "+contagem+" mês é de : "+dinheiro);
                contagem++;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
