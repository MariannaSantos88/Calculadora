using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_basica
{
    public partial class Form1 : Form
    {
        //definil variavel em cima pq vai usar de forma global.
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "6";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + ".";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "0";//faz com que apareça o numero escolhido pelo usuario, ao concatenar faz com que apareça outro numero na frente. pode ser usado txtResultado.Text += "0" acontece o mesmo.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);//converte a string do txtresultado e permite fazer contas com ponto.(ctrl ponto para acessar a biblioteca.
            txtResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "*";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);//converte a string do txtresultado e permite fazer contas com ponto.(ctrl ponto para acessar a biblioteca.
            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);//converte a string do txtresultado e permite fazer contas com ponto.(ctrl ponto para acessar a biblioteca.
            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);//faz a operacao de soma e convert para string
            } 
            else if(operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            } 
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);//converte a string do txtresultado e permite fazer contas com ponto.(ctrl ponto para acessar a biblioteca.
            txtResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";


            /*declaração de variavel do tipo double num1 num2 resultado
            double num1, num2, resultado;
            //converti para numero o conteudo do textbox
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            //resebe o conteudo e realiza o calculo
            resultado = num1 + num2;
            //recebe o conteudo da variavel resultado e converte para numero
            txtResultado.Text = resultado.ToString();*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
