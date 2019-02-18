using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuebleriaMariana
{
    public class Croquis
    {
        private Int32 id_croquis;
        public Int32 _Id_croquis
        {
            get { return id_croquis; }
            set { id_croquis = value; }
        }

        private String nombre_cliente;
        public String _Nombre_cliente
        {
            get { return nombre_cliente; }
            set { nombre_cliente = value; }
        }

        private DateTime fecha;
        public DateTime _Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Decimal precio_costo;
        public Decimal _Precio_costo
        {
            get { return precio_costo; }
            set { precio_costo = value; }
        }

        private Decimal precio_venta;

        public Decimal _Precio_venta
        {
            get { return precio_venta; }
            set { precio_venta = value; }
        }
        private List<Modulo> Modulos;
        public Croquis() //constructor
        { 
        
        }
        //Eventos 
        public int Insertar_Croquis() 
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTAR_CROQUIS ?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_croquis, 1);
            objetoconexion.annadir_parametro(this.nombre_cliente, 2);
            objetoconexion.annadir_parametro(this.fecha, 4);
            objetoconexion.annadir_parametro(this.precio_costo, 3);
            objetoconexion.annadir_parametro(this.precio_venta, 3);
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
        public int Modificar_Croquis()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZAR_CROQUIS ?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_croquis, 1);
            objetoconexion.annadir_parametro(this.nombre_cliente, 2);
            objetoconexion.annadir_parametro(this.fecha, 4);
            objetoconexion.annadir_parametro(this.precio_costo, 3);
            objetoconexion.annadir_parametro(this.precio_venta, 3);
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
        public int Eliminar_Croquis()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINAR_CROQUIS ?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_croquis, 1);
            objetoconexion.annadir_parametro(this.nombre_cliente, 2);
            objetoconexion.annadir_parametro(this.fecha, 4);
            objetoconexion.annadir_parametro(this.precio_costo, 3);
            objetoconexion.annadir_parametro(this.precio_venta, 3);
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
        public static int InsertaModuloACroquis(Modulo M, Croquis C, Decimal EJEX, Decimal EJEY)
        {
            int respuesta = 0;

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC INSERTAR_MODULO_CROQUIS ?,?,?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(M._Id_modulo, 1);
            conx_detalles.annadir_parametro(C._Id_croquis, 1);
            conx_detalles.annadir_parametro(EJEX, 3);
            conx_detalles.annadir_parametro(EJEY, 3);

            CONTENEDOR = conx_detalles.busca();
            while (CONTENEDOR.Read())
            {
                respuesta = Convert.ToInt16(CONTENEDOR[0].ToString());
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            CONTENEDOR.Close();
            return respuesta;
        }

        public static List<Croquis> Seleccionar()
        {
            List<Croquis> Listadecroquis = new List<Croquis>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARCROQUIS";
            conx_detalles.annadir_consulta(Consulta);

            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Croquis IB = new Croquis();

                IB._Id_croquis = Convert.ToInt32(Contenedor["ID_CROQUIS"].ToString());
                IB._Nombre_cliente = Contenedor["NOMBRE_CLIENTE"].ToString();
                IB._Fecha = Convert.ToDateTime(Contenedor["FECHA"].ToString());
                IB._Precio_costo = Convert.ToDecimal(Contenedor["PRECIO_COSTO"].ToString());
                IB._Precio_venta = Convert.ToDecimal(Contenedor["PRECIO_VENTA"].ToString());
                Listadecroquis.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listadecroquis;
        }

    }
}