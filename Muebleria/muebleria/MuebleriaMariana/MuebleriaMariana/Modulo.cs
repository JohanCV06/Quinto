using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuebleriaMariana
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
        private List<Componente> Componentes;
        public Modulo() //constructor
        { 
        
        }
        //Eventos 
        public int Insertar_Modulo()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTAR_MODULO ?,?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_modulo, 1);
            objetoconexion.annadir_parametro(this.nombre_modulo, 2);
            objetoconexion.annadir_parametro(this.alto, 3);
            objetoconexion.annadir_parametro(this.ancho, 3);
            objetoconexion.annadir_parametro(this.fondo, 3);
            objetoconexion.annadir_parametro(this.tipo_modulo, 2);
            objetoconexion.annadir_parametro(this.precio_modulo, 1);
            objetoconexion.annadir_parametro(this.foto1_modulo, 6);
            objetoconexion.annadir_parametro(this.foto2_modulo, 6);
            Contenedor = objetoconexion.busca();
            while (Contenedor.Read())
            {
                Resultado = Convert.ToInt32(Contenedor[0].ToString());
            }
            objetoconexion.conexion.Close();
            objetoconexion.conexion.Dispose();
            Contenedor.Close();
            return Resultado;
        }
        public int Modificar_Modulo()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZAR_MODULO ?,?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_modulo, 1);
            objetoconexion.annadir_parametro(this.nombre_modulo, 2);
            objetoconexion.annadir_parametro(this.alto, 3);
            objetoconexion.annadir_parametro(this.ancho, 3);
            objetoconexion.annadir_parametro(this.fondo, 3);
            objetoconexion.annadir_parametro(this.tipo_modulo, 2);
            objetoconexion.annadir_parametro(this.precio_modulo, 1);
            objetoconexion.annadir_parametro(this.foto1_modulo, 6);
            objetoconexion.annadir_parametro(this.foto2_modulo, 6);
            Contenedor = objetoconexion.busca();
            while (Contenedor.Read())
            {
                Resultado = Convert.ToInt32(Contenedor[0].ToString());
            }
            objetoconexion.conexion.Close();
            objetoconexion.conexion.Dispose();
            Contenedor.Close();
            return Resultado;
        }
        public int Eliminar_Modulo()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINAR_MODULO ?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_modulo, 1);
            Contenedor = objetoconexion.busca();
            while (Contenedor.Read())
            {
                Resultado = Convert.ToInt32(Contenedor[0].ToString());
            }
            objetoconexion.conexion.Close();
            objetoconexion.conexion.Dispose();
            Contenedor.Close();
            return Resultado;
        }

        public static List<Modulo> Seleccionar()
        {
            List<Modulo> Listademodulos = new List<Modulo>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARMODULO";
            conx_detalles.annadir_consulta(Consulta);

            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Modulo IB = new Modulo();

                IB._Id_modulo = Convert.ToInt32(Contenedor["ID_MODULO"].ToString());
                IB._Nombre_modulo = Contenedor["NOMBRE_MODULO"].ToString();
                IB._Ancho = Convert.ToDecimal(Contenedor["ANCHO"].ToString());
                IB._Alto = Convert.ToDecimal(Contenedor["ALTO"].ToString());
                IB._Fondo = Convert.ToDecimal(Contenedor["FONDO"].ToString());
                IB._Tipo_modulo = Contenedor["TIPO_MODULO"].ToString();
                IB._Foto1_modulo = Contenedor["FOTO1_MODULO"].ToString();
                IB._Foto2_modulo = Contenedor["FOTO2_MODULO"].ToString();
                IB._Precio_modulo = Convert.ToInt32(Contenedor["PRECIO_MODULO"].ToString());
                Listademodulos.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listademodulos;
        }
        public static int InsertarComponenteAModulo(Modulo L, Componente M, Decimal CANTIDAD)
        {
            int respuesta = 0;
            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();

            conx_detalles.inicializa();

            string CONSULTA;

            System.Data.OleDb.OleDbDataReader CONTENEDOR;


            CONSULTA = "EXEC INSERTAR_COMPONENT_MODULO ?,?,?";

            conx_detalles.annadir_consulta(CONSULTA);

            conx_detalles.annadir_parametro(L._Id_modulo, 1);

            conx_detalles.annadir_parametro(M._Id_componente, 1);

            conx_detalles.annadir_parametro(CANTIDAD, 3);


            CONTENEDOR = conx_detalles.busca();

            while (CONTENEDOR.Read())
            {

                respuesta = Convert.ToInt16(CONTENEDOR[0].ToString());

            }

            conx_detalles.conexion.Close();

            conx_detalles.conexion.Dispose();

            CONTENEDOR.Close();

            return L._Id_modulo;

        }

        public string _Tipo_componente { get; set; }

        public int _Precio_componente { get; set; }

        public string _Foto2_componente { get; set; }

        public string _Foto1_componente { get; set; }

        internal int Eliminar_Piezas()
        {
            throw new NotImplementedException();
        }
    }
}