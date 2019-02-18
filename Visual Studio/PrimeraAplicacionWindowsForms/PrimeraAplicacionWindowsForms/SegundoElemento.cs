using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraAplicacionWindowsForms
{
    public partial class SegundoElemento : Form
    {
        /*Estas son variables las cuales son globales que vamos a utilizar en el futuro para todas las operaciones*/
        double NumeroIngresado1 = 0;
        double numeronegativo = 0;
        double i = 0;/*Esta Variable es un variable base para empexar un proceso de ciclo*/
        double NumeroIngresado2 = 0;
        int operador = 0;
        double NumeroIngresado3 = 0;
        double NumeroIngresado4 = 0;
        double resultado = 0;


        public SegundoElemento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "7";/*Estoy concatenando el numero 7 al estripar este boton*/
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "3";/*Estoy concatenando el numero 3 al estripar este boton*/
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {/*Creamos un switch para realizar las opciones, dependiendo de lo escogido se relaizara la especifica operacion*/
            NumeroIngresado2 = Convert.ToDouble(lblResultado.Text);
            switch (operador){
                case 1:/*Aqui se suman los dos numeros colocados en las dos variables*/
            resultado=NumeroIngresado1+NumeroIngresado2;
            break;
                case 2:/*Aqui se multiplican los dos numeros colocados en las dos variables*/
            resultado=NumeroIngresado1*NumeroIngresado2;
            break;
                case 3:/*Aqui se dividen los dos numeros colocados en las dos variables*/
            resultado=NumeroIngresado1/NumeroIngresado2;
            break;
                case 4:/*Aqui se restan los dos numeros colocados en las dos variables*/
            resultado=NumeroIngresado1-NumeroIngresado2;
            break;
                case 5:/*Aqui se saca el porcentaje deseado de un numero, siendo NumeroIngresado2 el porcentaje a sacar*/
            resultado = (NumeroIngresado1 * NumeroIngresado2) /100 ;
            break;
                case 6:
            resultado = NumeroIngresado1;/*Aqui se potencia un numero a otro exponente deseado, siendo NumeroIngresado2 el exponente*/
            for (i = 2; i <= NumeroIngresado2; i++)
            {

                resultado = resultado * NumeroIngresado1;
            }
                break;
                
              

            }
            lblResultado.Text = resultado.ToString();/*La respuesta debe pasarse de decimal a String para que pueda compilar*/

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "8";/*Estoy concatenando el numero 8 al estripar este boton*/
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";/*Estoy borrando el contenido de la calculadora*/
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "9";/*Estoy concatenando el numero 9 al estripar este boton*/
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "4";/*Estoy concatenando el numero 4 al estripar este boton*/
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "5";/*Estoy concatenando el numero 5 al estripar este boton*/
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "6";/*Estoy concatenando el numero 6 al estripar este boton*/
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "1";/*Estoy concatenando el numero 1 al estripar este boton*/
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "2";/*Estoy concatenando el numero 2 al estripar este boton*/
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "0";/*Estoy concatenando el numero 0 al estripar este boton*/
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {/*Aqui se empieza a realizar la operacion deseada transformando el texto del label en numeros*/
            NumeroIngresado1 = Convert.ToDouble(lblResultado.Text);
            operador = 1;
            lblResultado.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {/*Aqui se empieza a realuzar la operacion deseada transformando el texto del label en numeros*/
            NumeroIngresado1 = Convert.ToDouble(lblResultado.Text);
            operador = 4;
            lblResultado.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {/*Aqui se empieza a realuzar la operacion deseada transformando el texto del label en numeros*/
            NumeroIngresado1 = Convert.ToDouble(lblResultado.Text);
            operador = 2;
            lblResultado.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            /*Aqui se empieza a realuzar la operacion deseada transformando el texto del label en numeros*/
            NumeroIngresado1 = Convert.ToDouble(lblResultado.Text);
            operador = 3;
            lblResultado.Text = "";
        }

        private void SegundoElemento_Load(object sender, EventArgs e)
        {

        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            NumeroIngresado1 = Convert.ToDouble(lblResultado.Text);
            operador = 5;
            lblResultado.Text = "";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            NumeroIngresado1 = Convert.ToDouble(lblResultado.Text);/*Aqui se envia al swithc donde se sacara la pontencia*/
            operador = 6;
            lblResultado.Text = "";
        }

        private void btnNegativoPositivo_Click(object sender, EventArgs e)
        {
            numeronegativo = Convert.ToDouble(lblResultado.Text);/*Este no esta en el switch pues este no requiere de un segundo numero para realizar su funcion, asi que el proceso es realizado contiguamente*/
                
                resultado = numeronegativo *-1;
                lblResultado.Text = resultado.ToString();
               
        }

        private void btnRaiz_Click(object sender, EventArgs e)/*Este no necesita un segundo numero, se realiza el proceso contiguamente*/
        {
            NumeroIngresado1 = Convert.ToDouble(lblResultado.Text);
            double Raiz = Math.Sqrt(NumeroIngresado1);
            lblResultado.Text = Raiz.ToString();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text += ",";/*Estoy concatenando un decimal al estripar este boton*/
        }
    }
}
