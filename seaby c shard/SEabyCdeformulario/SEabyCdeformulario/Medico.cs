using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEabyvisual
{
    public class Medico
    {
        private String IDMEDICO;

        public String _IDMEDICO
        {
            get { return IDMEDICO; }
            set { IDMEDICO = value; }
        }
        private String NOMBRE;

        public String _NOMBRE
        {
            get { return NOMBRE; }
            set { NOMBRE = value; }
        }
        private Institucion INSTITUCION;

        public Institucion _INSTITUCION
        {
            get { return INSTITUCION; }
            set { INSTITUCION = value; }
        }
        public Medico()
        {

        }
        public int InsertarMedico()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTARMEDICO ?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDMEDICO, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
            objetoconexion.annadir_parametro(this._INSTITUCION._IDINSTITUCION, 2);
            
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
        public int ActualizarMedico()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZARMEDICO ?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDMEDICO, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
            objetoconexion.annadir_parametro(this._INSTITUCION._IDINSTITUCION, 2);
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
        public int EliminarMedico()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINARMEDICO ?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDMEDICO, 2);
      
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
        public static List<Medico> Seleccionar()
        {
            List<Medico> Listademedico = new List<Medico>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARMEDICO";
            conx_detalles.annadir_consulta(Consulta);

            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Medico IB = new Medico();

                IB._IDMEDICO = Contenedor["IDMEDICO"].ToString();
                IB._NOMBRE = Contenedor["NOMBRE"].ToString();
                Institucion inst = new Institucion();
                inst._IDINSTITUCION = Contenedor["INSTITUCION"].ToString();
                IB._INSTITUCION = inst;
                Listademedico.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listademedico;
        }
    }
}