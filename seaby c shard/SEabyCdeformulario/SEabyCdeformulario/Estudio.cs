using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEabyvisual
{
    public class Estudio
    {
        private String IDESTUDIO;

        public String _IDESTUDIO
        {
            get { return IDESTUDIO; }
            set { IDESTUDIO = value; }
        }
        private String IDDIAGNOSTICO;

        public String _IDDIAGNOSTICO
        {
            get { return IDDIAGNOSTICO; }
            set { IDDIAGNOSTICO = value; }
        }
        private String IDENFERMEDAD;

        public String _IDENFERMEDAD
        {
            get { return IDENFERMEDAD; }
            set { IDENFERMEDAD = value; }
        }
        private String IDINSTITUCION;

        public String _IDINSTITUCION
        {
            get { return IDINSTITUCION; }
            set { IDINSTITUCION = value; }
        }
        private String NOMBREENFERMEDAD;

        public String _NOMBREENFERMEDAD
        {
            get { return NOMBREENFERMEDAD; }
            set { NOMBREENFERMEDAD = value; }
        }
        private String PROVINCIA;

        public String _PROVINCIA
        {
            get { return PROVINCIA; }
            set { PROVINCIA = value; }
        }
        private Boolean GENERO;

        public Boolean _GENERO
        {
            get { return GENERO; }
            set { GENERO = value; }
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

        private String NOMBREINSTITUCION;

        public String _NOMBREINSTITUCION
        {
            get { return NOMBREINSTITUCION; }
            set { NOMBREINSTITUCION = value; }
        }
        public Estudio() 
        {
        }
        public int InsertarEstudio()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTARESTUDIO ?,?,?,?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDESTUDIO, 2);
            objetoconexion.annadir_parametro(this._IDDIAGNOSTICO, 2);
            objetoconexion.annadir_parametro(this._IDENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._IDINSTITUCION, 2);
            objetoconexion.annadir_parametro(this._NOMBREENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._PROVINCIA, 2);
            objetoconexion.annadir_parametro(this._GENERO, 1);
            objetoconexion.annadir_parametro(this._DIA, 2);
            objetoconexion.annadir_parametro(this._MES, 2);
            objetoconexion.annadir_parametro(this._ANNO, 2);
            objetoconexion.annadir_parametro(this._NOMBREINSTITUCION, 2);
         
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
        public int ActualizarEstudio()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZARESTUDIO ?,?,?,?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDESTUDIO, 2);
            objetoconexion.annadir_parametro(this._IDDIAGNOSTICO, 2);
            objetoconexion.annadir_parametro(this._IDENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._IDINSTITUCION, 2);
            objetoconexion.annadir_parametro(this._NOMBREENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._PROVINCIA, 2);
            objetoconexion.annadir_parametro(this._GENERO, 1);
            objetoconexion.annadir_parametro(this._DIA, 2);
            objetoconexion.annadir_parametro(this._MES, 2);
            objetoconexion.annadir_parametro(this._ANNO, 2);
            objetoconexion.annadir_parametro(this._NOMBREINSTITUCION, 2);
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
        public int EliminarEstudio()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINARESTUDIO ?,?,?,?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDESTUDIO, 2);
            objetoconexion.annadir_parametro(this._IDDIAGNOSTICO, 2);
            objetoconexion.annadir_parametro(this._IDENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._IDINSTITUCION, 2);
            objetoconexion.annadir_parametro(this._NOMBREENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._PROVINCIA, 2);
            objetoconexion.annadir_parametro(this._GENERO, 1);
            objetoconexion.annadir_parametro(this._DIA, 2);
            objetoconexion.annadir_parametro(this._MES, 2);
            objetoconexion.annadir_parametro(this._ANNO, 2);
            objetoconexion.annadir_parametro(this._NOMBREINSTITUCION, 2);
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
        public static List<Estudio> Seleccionar()
        {
            List<Estudio> Listadeestudios = new List<Estudio>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARESTUDIO";
            conx_detalles.annadir_consulta(Consulta);

            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Estudio IB = new Estudio();

                IB._IDESTUDIO = Contenedor["IDESTUDIO"].ToString();
                IB._IDDIAGNOSTICO = Contenedor["IDDIAGNOSTICO"].ToString();
                IB._IDENFERMEDAD = Contenedor["IDENFERMEDAD"].ToString();
                IB._IDINSTITUCION = Contenedor["IDINSTITUCION"].ToString();
                IB._NOMBREENFERMEDAD = Contenedor["NOMBREENFERMEDAD"].ToString();
                IB._PROVINCIA = Contenedor["PROVINCIA"].ToString();
                IB._GENERO = Convert.ToBoolean(Contenedor["GENERO"].ToString());
                IB._DIA = Contenedor["DIA"].ToString();
                IB._MES = Contenedor["MES"].ToString();
                IB._ANNO = Contenedor["ANNO"].ToString();
                IB._NOMBREINSTITUCION = Contenedor["NOMBREINSTITUCION"].ToString();

                Listadeestudios.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listadeestudios;
        }

    }
}