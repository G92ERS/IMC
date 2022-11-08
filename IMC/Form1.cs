using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnimc_Click(object sender, EventArgs e)
        {
            try {
            //Declarando a Váriavel
            double altura = double.Parse(txbaltura.Text.ToString());
            double peso = double.Parse(txbpeso.Text.ToString());
            double IMC = (peso / (altura * altura));
            
            if (altura == 0)
            {
                lblsaud.Text = "Erro !";

            }else 
                {
                //Calculando o IMC
                txbresultado.Text = Math.Round(IMC, 2).ToString();

                if (IMC < 18.5)
                {
                    lblsaud.Text = "Magrin ";

                }
                else if (IMC < 24.9)
                {
                    lblsaud.Text = "Peso Ideal ";
                }
                else if (IMC < 29.9)
                {
                    lblsaud.Text = "Meio Gordo ";
                }
                else if (IMC < 34.9)
                {
                    lblsaud.Text = "Gordinho ";
                }
                else if (IMC < 39.9)
                {
                    lblsaud.Text = "Gordão ";
                }
                else if (IMC > 40)
                {
                    lblsaud.Text = "Super Gordão";
                }
                lblsaud.ForeColor = lblsaud.Text == "Magrin" ? Color.Red : Color.Green;
                lblsaud.ForeColor = lblsaud.Text == "Peso ideal" ? Color.Red : Color.Green;
                lblsaud.ForeColor = lblsaud.Text == "Meio Gordo" ? Color.Red : Color.Green;
                lblsaud.ForeColor = lblsaud.Text == "Gordinho" ? Color.Red : Color.Red;
                lblsaud.ForeColor = lblsaud.Text == "Gordão" ? Color.Red : Color.Red;
                lblsaud.ForeColor = lblsaud.Text == "Super Gordão" ? Color.Red : Color.Red;
            }
            } catch { lblsaud.Text = "Erro!!"; }


        }

    }
}
