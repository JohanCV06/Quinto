using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_OO
{
    class clase_pelicula
    {
        private String nombre;

        public String _Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String clasificacion;

        public String _Clasificacion
        {
            get { return clasificacion; }
            set { clasificacion = value; }
        }
        private Int16 duracionminutos;

        public Int16 _duracionminutos
        {
            get { return duracionminutos; }
            set { duracionminutos = value; }
        }
        private String idioma;

        public String _Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }
        private String subtitulos;

        public String _Subtitulos
        {
            get { return subtitulos; }
            set { subtitulos = value; }
        }
        private String tipo;

        public String _Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private String fecha;

        public String _Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private String hora;

        public String _Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        private List<clase_butaca> listadebutacas;

        public List<clase_butaca> _Listadebutacas
        {
            get { return listadebutacas; }
            set { listadebutacas = value; }
        }
        //constructor
        public clase_pelicula()
        {

        }


        public List<clase_pelicula> listadepeliculas()
        {
            clase_pelicula pelicula = new clase_pelicula();
            pelicula.nombre = "Chucky";
            clase_pelicula pelicula2 = new clase_pelicula();
            pelicula2.nombre= "Saw";
            List<clase_pelicula> lista= new List<clase_pelicula>();
            lista.Add(pelicula);
            lista.Add(pelicula2);
            return lista;

        }
        public String Factura()
        {
            string cliente ="";
            string facturaentexto= "";
            int montototal = 0;
            foreach (clase_butaca item in this._Listadebutacas)
            {
                facturaentexto += "\n letra de fila : " + item._letradefila + "\n";
                facturaentexto += "Numero de fila :" + item._numeroasiento.ToString() + "\n";
                facturaentexto += "Precio de la butaca: "+ item._Precio.ToString() + "\n";
                montototal += item._Precio;
                facturaentexto += "---------------------------------";

                cliente = "Numero de Cedula: " + item._Cliente._cedula+ "\n " + item._Cliente._Nombre + " " +
                    item._Cliente._Primerapellido + " " + item._Cliente._Segundoapellido + " \n" + "Numero de tarjeta: " + item._Cliente._Numerotarjeta; 
            
            }
            facturaentexto += " \n" + cliente;
            facturaentexto += "\n" + montototal.ToString();
            return facturaentexto;

        }

        

    
    

    
    }
}
