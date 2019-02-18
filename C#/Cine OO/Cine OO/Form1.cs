using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_OO
{
    public partial class Form1 : Form
    {
        clase_cliente cliente = new clase_cliente();
        clase_pelicula peliculas = new clase_pelicula();
        List<clase_butaca> listadebutacas = new List<clase_butaca>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 11;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 2500;
            peliculas._Listadebutacas.Add(butaca);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clase_pelicula peliculas = new clase_pelicula();
            comboBox1.DataSource = peliculas.listadepeliculas();
            comboBox1.DisplayMember = "_Nombre";
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {
            
            cliente._cedula = Convert.ToInt32(textBox3.Text);
            cliente._Nombre = textBox4.Text;
            cliente._Primerapellido = textBox5.Text;
            cliente._Segundoapellido = textBox1.Text;
            cliente._Numerotarjeta = Convert.ToInt32(textBox2.Text); 
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 1;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 2500;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 2;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 2500;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 3;
            butaca._tipo = "miedo";
            butaca._Precio = 2500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._Precio = 2500;
            butaca._numeroasiento = 4;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 5;
            butaca._tipo = "miedo";
            butaca._Precio = 2500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 6;
            butaca._Precio = 2500;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 7;
            butaca._Precio = 2500;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 8;
            butaca._tipo = "miedo";
            butaca._Precio = 2500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 9;
            butaca._tipo = "miedo";
            butaca._Precio = 2500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "A";
            butaca._numeroasiento = 10;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 2500;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 1;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 3000;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 2;
            butaca._tipo = "miedo";
            butaca._Precio = 3000;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 3;
            butaca._tipo = "miedo";
            butaca._Precio = 3000;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 4;
            butaca._Precio = 3000;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 5;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 3000;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 6;
            butaca._tipo = "miedo";
            butaca._Precio = 3000;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 7;
            butaca._tipo = "miedo";
            butaca._Precio = 3000;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 8;
            butaca._tipo = "miedo";
            butaca._Precio = 3000;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 9;
            butaca._tipo = "miedo";
            butaca._Precio = 3000;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 10;
            butaca._tipo = "miedo";
            butaca._Precio = 3000;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "B";
            butaca._numeroasiento = 11;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 3000;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 1;
            butaca._tipo = "miedo";
            butaca._Precio = 3500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 2;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 3500;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 3;
            butaca._tipo = "miedo";
            butaca._Precio = 3500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 4;
            butaca._Precio = 3500;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 5;
            butaca._Precio = 3500;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 6;
            butaca._tipo = "miedo";
            butaca._Precio = 3500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 7;
            butaca._tipo = "miedo";
            butaca._Precio = 3500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 8;
            butaca._tipo = "miedo";
            butaca._Precio = 3500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 9;
            butaca._tipo = "miedo";
            butaca._Precio = 3500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 10;
            butaca._tipo = "miedo";
            butaca._Precio = 3500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "C";
            butaca._numeroasiento = 11;
            butaca._Precio = 3500;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 1;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 4500;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 2;
            butaca._tipo = "miedo";
            butaca._Precio = 4500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 3;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 4500;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 4;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 4500;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 5;
            butaca._tipo = "miedo";
            butaca._Precio = 4500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 6;
            butaca._tipo = "miedo";
            butaca._Precio = 4500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 7;
            butaca._tipo = "miedo";
            butaca._Precio = 4500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 8;
            butaca._tipo = "miedo";
            butaca._Precio = 4500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 9;
            butaca._tipo = "miedo";
            butaca._Precio = 4500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 10;
            butaca._tipo = "miedo";
            butaca._Precio = 4500;
            butaca._Cliente = cliente;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            clase_butaca butaca = new clase_butaca();
            butaca._letradefila = "D";
            butaca._numeroasiento = 11;
            butaca._tipo = "miedo";
            butaca._Cliente = cliente;
            butaca._Precio = 4500;
            listadebutacas.Add(butaca);
            peliculas._Listadebutacas = listadebutacas;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            MessageBox.Show(peliculas.Factura(), "");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
