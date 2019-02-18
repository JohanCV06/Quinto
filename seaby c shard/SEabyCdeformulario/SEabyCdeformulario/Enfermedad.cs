using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEabyvisual
{
    public class Enfermedad
    {
        private String IDENFERMEDAD;

        public String _IDENFERMEDAD
        {
            get { return IDENFERMEDAD; }
            set { IDENFERMEDAD = value; }
        }
        private String NOMBRE;

        public String _NOMBRE
        {
            get { return NOMBRE; }
            set { NOMBRE = value; }
        }
        private String SINTOMAS;

        public String _SINTOMAS
        {
            get { return SINTOMAS; }
            set { SINTOMAS = value; }
        }
        public Enfermedad()
        {
        }

        public int InsertarEnfermedad()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTARENFERMEDAD ?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
            objetoconexion.annadir_parametro(this._SINTOMAS, 2);

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
        public int ActualizarEnfermedad()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZARENFERMEDAD ?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
            objetoconexion.annadir_parametro(this._SINTOMAS, 2);
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
        public int EliminarEnfermedad()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINARENFERMEDAD ?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
            objetoconexion.annadir_parametro(this._SINTOMAS, 2);
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
        public static List<Enfermedad> Seleccionar()
        {
            List<Enfermedad> Listadeenfermedad = new List<Enfermedad>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARENFERMEDADTODAS";
            conx_detalles.annadir_consulta(Consulta);

            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Enfermedad IB = new Enfermedad();

                IB._IDENFERMEDAD = Contenedor["IDENFERMEDAD"].ToString();
                IB._NOMBRE = Contenedor["NOMBRE"].ToString();
                IB._SINTOMAS = Contenedor["SINTOMAS"].ToString();
                Listadeenfermedad.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listadeenfermedad;
        }
        public  Enfermedad Seleccionar_enfermedad()
        {
            Enfermedad IB = new Enfermedad();
            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARENFERMEDAD ?";
            conx_detalles.annadir_consulta(Consulta);
            conx_detalles.annadir_parametro(this._IDENFERMEDAD, 2);
            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
               

                IB._IDENFERMEDAD = Contenedor["IDENFERMEDAD"].ToString();
                IB._NOMBRE = Contenedor["NOMBRE"].ToString();
                IB._SINTOMAS = Contenedor["SINTOMAS"].ToString();
          
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return IB;
        }
    }
}