using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEabyvisual
{
    public class Institucion
    {
        private String IDINSTITUCION;

        public String _IDINSTITUCION
        {
            get { return IDINSTITUCION; }
            set { IDINSTITUCION = value; }
        }
        private String PROVINCIA;

        public String _PROVINCIA
        {
            get { return PROVINCIA; }
            set { PROVINCIA = value; }
        }
        private String NOMBRE;

        public String _NOMBRE
        {
            get { return NOMBRE; }
            set { NOMBRE = value; }
        }
        public Institucion()
        {

        }
        public int InsertarInstitucion()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTARINSTITUCION ?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDINSTITUCION, 2);
            objetoconexion.annadir_parametro(this._PROVINCIA, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);

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
        public int ActualizarInstitucion()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZARINSTITUCION ?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDINSTITUCION, 2);
            objetoconexion.annadir_parametro(this._PROVINCIA, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
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
        public int EliminarInstitucion()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINARINSTITUCION ?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDINSTITUCION, 2);
            objetoconexion.annadir_parametro(this._PROVINCIA, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
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
        public static List<Institucion> Seleccionar()
        {
            List<Institucion> Listadeinstitucion = new List<Institucion>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARINSTITUCION";
            conx_detalles.annadir_consulta(Consulta);

            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Institucion IB = new Institucion();

                IB._IDINSTITUCION = Contenedor["IDINSTITUCION"].ToString();
                IB._PROVINCIA = Contenedor["PROVINCIA"].ToString();
                IB._NOMBRE = Contenedor["NOMBRE"].ToString();
                Listadeinstitucion.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listadeinstitucion;
        }
    }
}