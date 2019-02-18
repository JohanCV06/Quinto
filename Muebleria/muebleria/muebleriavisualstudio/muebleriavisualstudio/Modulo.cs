using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace muebleriavisualstudio
{
    public class Modulo
    {
        private Int32 id_modulo;

        public Int32 _Id_modulo
        {
            get { return id_modulo; }
            set { id_modulo = value; }
        }

        private String nombre_modulo;

        public String _Nombre_modulo
        {
            get { return nombre_modulo; }
            set { nombre_modulo = value; }
        }

        private Decimal ancho;
        public Decimal _Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        private Decimal alto;
        public Decimal _Alto
        {
            get { return alto; }
            set { alto = value; }
        }

        private Decimal fondo;

        public Decimal _Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }

        private String tipo_modulo;
        public String _Tipo_modulo
        {
            get { return tipo_modulo; }
            set { tipo_modulo = value; }
        }

        private Int32 precio_modulo;
        public Int32 _Precio_modulo
        {
            get { return precio_modulo; }
            set { precio_modulo = value; }
        }

        private String foto1_modulo;
        public String _Foto1_modulo
        {
            get { return foto1_modulo; }
            set { foto1_modulo = value; }
        }

        private String foto2_modulo;
        public String _Foto2_modulo
        {
            get { return foto2_modulo; }
            set { foto2_modulo = value; }
        }
    }
}