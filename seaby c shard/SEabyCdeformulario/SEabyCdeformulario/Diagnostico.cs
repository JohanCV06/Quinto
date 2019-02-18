using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEabyvisual
{
    public class Diagnostico
    {
        private String IDDIAGNOSTICO;

        public String _IDDIAGNOSTICO
        {
            get { return IDDIAGNOSTICO; }
            set { IDDIAGNOSTICO = value; }
        }
        private Medico IDMEDICO;

        public Medico _IDMEDICO
        {
            get { return IDMEDICO; }
            set { IDMEDICO = value; }
        }
        private Paciente IDPACIENTE;

        public Paciente _IDPACIENTE
        {
            get { return IDPACIENTE; }
            set { IDPACIENTE = value; }
        }
        private String DESCRIPCION;

        public String _DESCRIPCION
        {
            get { return DESCRIPCION; }
            set { DESCRIPCION = value; }
        }
        private String SEGUIMIENTO;

        public String _SEGUIMIENTO
        {
            get { return SEGUIMIENTO; }
            set { SEGUIMIENTO = value; }
        }
        private String DIA;

        public String _DIA
        {
            get { return DIA; }
            set { DIA = value; }
        }
        private String MES;

        public String _MES
        {
            get { return MES; }
            set { MES = value; }
        }
        private String ANNO;

        public String _ANNO
        {
            get { return ANNO; }
            set { ANNO = value; }
        }

        public Diagnostico()
        {

        }
        public int InsertarDiagnostico()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTARDIAGNOSTICO ?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDDIAGNOSTICO, 2);
            objetoconexion.annadir_parametro(this._IDMEDICO._IDMEDICO, 2);
            objetoconexion.annadir_parametro(this._IDPACIENTE._IDPACIENTE, 2);
            objetoconexion.annadir_parametro(this._DESCRIPCION, 2);
            objetoconexion.annadir_parametro(this._SEGUIMIENTO, 2);
            objetoconexion.annadir_parametro(this._DIA, 2);
            objetoconexion.annadir_parametro(this._MES, 2);
            objetoconexion.annadir_parametro(this._ANNO, 2);
           

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
        public int ActualizarDiagnostico()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZARDIAGNOSTICO ?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDDIAGNOSTICO, 2);
            objetoconexion.annadir_parametro(this._IDMEDICO._IDMEDICO, 2);
            objetoconexion.annadir_parametro(this._IDPACIENTE._IDPACIENTE, 2);
            objetoconexion.annadir_parametro(this._DESCRIPCION, 2);
            objetoconexion.annadir_parametro(this._SEGUIMIENTO, 2);
            objetoconexion.annadir_parametro(this._DIA, 2);
            objetoconexion.annadir_parametro(this._MES, 2);
            objetoconexion.annadir_parametro(this._ANNO, 2);
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
        public int EliminarDiagnostico()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINARDIAGNOSTICO ?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDDIAGNOSTICO, 2);
            objetoconexion.annadir_parametro(this._IDMEDICO._IDMEDICO, 2);
            objetoconexion.annadir_parametro(this._IDPACIENTE._IDPACIENTE, 2);
            objetoconexion.annadir_parametro(this._DESCRIPCION, 2);
            objetoconexion.annadir_parametro(this._SEGUIMIENTO, 2);
            objetoconexion.annadir_parametro(this._DIA, 2);
            objetoconexion.annadir_parametro(this._MES, 2);
            objetoconexion.annadir_parametro(this._ANNO, 2);
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
        public static List<Diagnostico> Seleccionar()
        {
            List<Diagnostico> Listadediagnosticos = new List<Diagnostico>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARDIAGNOSTICO";
            conx_detalles.annadir_consulta(Consulta);

            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Diagnostico IB = new Diagnostico();

                IB._IDDIAGNOSTICO = Contenedor["IDDIAGNOSTICO"].ToString();
                Medico medic = new Medico();
                medic._IDMEDICO = Contenedor["IDMEDICO"].ToString();
                IB._IDMEDICO = medic;
                Paciente pacie = new Paciente();
                pacie._IDPACIENTE = Contenedor["IDPACIENTE"].ToString();
                IB._IDPACIENTE = pacie;
                IB._DESCRIPCION = Contenedor["DESCRIPCION"].ToString();
                IB._SEGUIMIENTO = Contenedor["SEGUIMIENTO"].ToString();
                IB._DIA = Contenedor["DIA"].ToString();
                IB._MES = Contenedor["MES"].ToString();
                IB._ANNO = Contenedor["ANNO"].ToString();

                Listadediagnosticos.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listadediagnosticos;
        }

    }
}