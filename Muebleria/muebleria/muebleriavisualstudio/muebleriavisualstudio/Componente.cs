using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace muebleriavisualstudio
{
    public class Componente
    {
        private Int32 id_componente;

        public Int32 _Id_componente
        {
            get { return id_componente; }
            set { id_componente = value; }
        }

        private String nombre_componente;

        public String _Nombre_componente
        {
            get { return nombre_componente; }
            set { nombre_componente = value; }
        }

        private Int32 precio_componente;

        public Int32 _Precio_componente
        {
            get { return precio_componente; }
            set { precio_componente = value; }
        }

        private String foto1_componente;

        public String _Foto1_componente
        {
            get { return foto1_componente; }
            set { foto1_componente = value; }
        }

        private String foto2_componente;

        public String _Foto2_componente
        {
            get { return foto2_componente; }
            set { foto2_componente = value; }
        }

        private String tipo_componente;
        public String _Tipo_componente
        {
            get { return tipo_componente; }
            set { tipo_componente = value; }
        }


    }
}