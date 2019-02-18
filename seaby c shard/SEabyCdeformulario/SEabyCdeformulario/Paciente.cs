using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEabyvisual
{
    public class Paciente
    {
        private String IDPACIENTE;

        public String _IDPACIENTE
        {
            get { return IDPACIENTE; }
            set { IDPACIENTE = value; }
        }
        private Institucion IDINSTITUCION;

        public Institucion _IDINSTITUCION
        {
            get { return IDINSTITUCION; }
            set { IDINSTITUCION = value; }
        }

        private Medico IDMEDICO;

        public Medico _IDMEDICO
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
        private int EDAD;

        public int _EDAD
        {
            get { return EDAD; }
            set { EDAD = value; }
        }
        private Decimal PESO;

        public Decimal _PESO
        {
            get { return PESO; }
            set { PESO = value; }
        }
        private Decimal ESTATURA;

        public Decimal _ESTATURA
        {
            get { return ESTATURA; }
            set { ESTATURA = value; }
        }
        private String SANGRE;

        public String _SANGRE
        {
            get { return SANGRE; }
            set { SANGRE = value; }
        }
        private String VICIOS;

        public String _VICIOS
        {
            get { return VICIOS; }
            set { VICIOS = value; }
        }
        private String MEDICACION;

        public String _MEDICACION
        {
            get { return MEDICACION; }
            set { MEDICACION = value; }
        }
        private String ALERGIAS;

        public String _ALERGIAS
        {
            get { return ALERGIAS; }
            set { ALERGIAS = value; }
        }
        private String PADECIMIENTOS;

        public String _PADECIMIENTOS
        {
            get { return PADECIMIENTOS; }
            set { PADECIMIENTOS = value; }
        }
        private Boolean GENERO;

        public Boolean _GENERO
        {
            get { return GENERO; }
            set { GENERO = value; }
        }
        private List<SEabyCdeformulario.Paciente_Enfermedad> ENFERMEDADES;

        public List<SEabyCdeformulario.Paciente_Enfermedad> _ENFERMEDADES
        {
            get { return ENFERMEDADES; }
            set { ENFERMEDADES = value; }
        }
        public Paciente()
        {

        }
        public int InsertaEnfermedades_a_Pacientes()
        {
            foreach (SEabyCdeformulario.Paciente_Enfermedad item in this._ENFERMEDADES)
            {
                String respuesta = "";
                Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
                conx_detalles.inicializa();
                String CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;
                CONSULTA = "EXEC INSERTARPACIENTE_ENFERMEDAD ?,?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(this._IDPACIENTE, 2);
                conx_detalles.annadir_parametro(item._IDENFERMEDAD._IDENFERMEDAD, 2);
                CONTENEDOR = conx_detalles.busca();
                while (CONTENEDOR.Read())
                {
                    respuesta = CONTENEDOR[0].ToString();
                }
                conx_detalles.conexion.Close();
                conx_detalles.conexion.Dispose();
                CONTENEDOR.Close();
            }
            return 2;
        }
        public int SeleccionaEnfermedades_de_Pacientes()
        {
            List<SEabyCdeformulario.Paciente_Enfermedad> lista = new List<SEabyCdeformulario.Paciente_Enfermedad>();
            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONAR_TODAS_PACIENTE_ENFERMEDAD ?";
            conx_detalles.annadir_consulta(Consulta);

            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                SEabyCdeformulario.Paciente_Enfermedad IB = new SEabyCdeformulario.Paciente_Enfermedad();
                Enfermedad Enfer = new Enfermedad();
                Enfer._IDENFERMEDAD = Contenedor["IDENFERMEDAD"].ToString();
                Enfer = Enfer.Seleccionar_enfermedad();

                IB._IDENFERMEDAD= Enfer;
                lista.Add(IB);
                
            }
            this._ENFERMEDADES = lista;
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return 1;
            
        }
        public int InsertarPaciente()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTARPACIENTE ?,?,?,?,?,?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDPACIENTE, 2);
            objetoconexion.annadir_parametro(this._IDMEDICO._IDMEDICO, 2);
            objetoconexion.annadir_parametro(this._IDINSTITUCION._IDINSTITUCION, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
            objetoconexion.annadir_parametro(this._EDAD, 1);
            objetoconexion.annadir_parametro(this._PESO, 3);
            objetoconexion.annadir_parametro(this._ESTATURA, 3);
            objetoconexion.annadir_parametro(this._SANGRE, 2);
            objetoconexion.annadir_parametro(this._VICIOS, 2);
            objetoconexion.annadir_parametro(this._MEDICACION, 2);
            objetoconexion.annadir_parametro(this._ALERGIAS, 2);
            objetoconexion.annadir_parametro(this._PADECIMIENTOS, 2);
            objetoconexion.annadir_parametro(this._GENERO, 1);
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
        public int ActualizarPaciente()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZARPACIENTE ?,?,?,?,?,?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDPACIENTE, 2);
            objetoconexion.annadir_parametro(this._IDMEDICO._IDMEDICO, 2);
            objetoconexion.annadir_parametro(this._IDINSTITUCION._IDINSTITUCION, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
            objetoconexion.annadir_parametro(this._EDAD, 1);
            objetoconexion.annadir_parametro(this._PESO, 3);
            objetoconexion.annadir_parametro(this._ESTATURA, 3);
            objetoconexion.annadir_parametro(this._SANGRE, 2);
            objetoconexion.annadir_parametro(this._VICIOS, 2);
            objetoconexion.annadir_parametro(this._MEDICACION, 2);
            objetoconexion.annadir_parametro(this._ALERGIAS, 2);
            objetoconexion.annadir_parametro(this._PADECIMIENTOS, 2);
            objetoconexion.annadir_parametro(this._GENERO, 1);
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
        public int EliminarPaciente()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINARPACIENTE ?,?,?,?,?,?,?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDPACIENTE, 2);
            objetoconexion.annadir_parametro(this._IDMEDICO._IDMEDICO, 2);
            objetoconexion.annadir_parametro(this._IDINSTITUCION._IDINSTITUCION, 2);
            objetoconexion.annadir_parametro(this._NOMBRE, 2);
            objetoconexion.annadir_parametro(this._EDAD, 1);
            objetoconexion.annadir_parametro(this._PESO, 3);
            objetoconexion.annadir_parametro(this._ESTATURA, 3);
            objetoconexion.annadir_parametro(this._SANGRE, 2);
            objetoconexion.annadir_parametro(this._VICIOS, 2);
            objetoconexion.annadir_parametro(this._MEDICACION, 2);
            objetoconexion.annadir_parametro(this._ALERGIAS, 2);
            objetoconexion.annadir_parametro(this._PADECIMIENTOS, 2);
            objetoconexion.annadir_parametro(this._GENERO, 1);
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
        public static List<Paciente> Seleccionar()
        {
            List<Paciente> Listadepaciente = new List<Paciente>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARPACIENTE";
            conx_detalles.annadir_consulta(Consulta);
   
            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Paciente IB = new Paciente();
                
                IB._IDPACIENTE = Contenedor["IDPACIENTE"].ToString();
                Medico medic = new Medico();
                medic._IDMEDICO = Contenedor["IDMEDICO"].ToString();
                IB._IDMEDICO = medic;
                Institucion inst = new Institucion();
                inst._IDINSTITUCION = Contenedor["IDINSTITUCION"].ToString();
                IB._IDINSTITUCION = inst;
                IB._NOMBRE = Contenedor["NOMBRE"].ToString();
                IB._EDAD = Convert.ToInt32(Contenedor["EDAD"].ToString());
                IB._PESO = Convert.ToDecimal(Contenedor["PESO"].ToString());
                IB._ESTATURA = Convert.ToDecimal(Contenedor["ESTATURA"].ToString());
                IB._SANGRE = Contenedor["SANGRE"].ToString();
                IB._VICIOS = Contenedor["VICIOS"].ToString();
                IB._MEDICACION = Contenedor["MEDICACION"].ToString();
                IB._ALERGIAS = Contenedor["ALERGIAS"].ToString();
                IB._PADECIMIENTOS = Contenedor["PADECIMIENTOS"].ToString();
                IB._GENERO = Convert.ToBoolean(Contenedor["GENERO"].ToString());
                Listadepaciente.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listadepaciente;
        }


 
    }
}
