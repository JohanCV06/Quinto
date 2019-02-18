using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace muebleriavisualstudio
{
    public class pieza
    {
        private Int32 id_pieza;

        public Int32 _id_pieza
        {
            get { return id_pieza; }
            set { id_pieza = value; }
        }

        private String nombre_pieza;

        public String _Nombre_pieza
        {
            get { return nombre_pieza; }
            set { nombre_pieza = value; }
        }

        private String descripcion;

        public String _Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private String foto1_pieza;

        public String _Foto1_pieza
        {
            get { return foto1_pieza; }
            set { foto1_pieza = value; }
        }
        private String foto2_pieza;

        public String _Foto2_pieza
        {
            get { return foto2_pieza; }
            set { foto2_pieza = value; }
        }

        private Decimal precio_pieza;

        public Decimal _Precio_pieza
        {
            get { return precio_pieza; }
            set { precio_pieza = value; }
        }

        private String unidad_medida;

        public String _Unidad_medida
        {
            get { return unidad_medida; }
            set { unidad_medida = value; }
        }


    }
}