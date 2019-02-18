using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_OO
{
    class clase_cliente
    {
        private Int32 cedula;

        public Int32 _cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private String nombre;

        public String _Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String primerapellido;

        public String _Primerapellido
        {
            get { return primerapellido; }
            set { primerapellido = value; }
        }
        private String segundoapellido;

        public String _Segundoapellido
        {
            get { return segundoapellido; }
            set { segundoapellido = value; }
        }
        private Int32 numerotarjeta;

        public Int32 _Numerotarjeta
        {
            get { return numerotarjeta; }
            set { numerotarjeta = value; }
        }
        //constructor
        public clase_cliente()
        {

        }
    }
}
