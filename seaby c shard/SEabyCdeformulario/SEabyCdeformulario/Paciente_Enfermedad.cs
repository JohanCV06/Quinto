using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEabyCdeformulario
{
    public class Paciente_Enfermedad
    {
        
        private SEabyvisual.Enfermedad IDENFERMEDAD;

        public SEabyvisual.Enfermedad _IDENFERMEDAD
        {
            get { return IDENFERMEDAD; }
            set { IDENFERMEDAD = value; }
        }
        private SEabyvisual.Paciente IDPACIENTE;

        public SEabyvisual.Paciente _IDPACIENTE
        {
            get { return IDPACIENTE; }
            set { IDPACIENTE = value; }
        }
        private String IDPACIENTEENFERMEDAD;

        public String _IDPACIENTEENFERMEDAD
        {
            get { return IDPACIENTEENFERMEDAD; }
            set { IDPACIENTEENFERMEDAD = value; }
        }
        public Paciente_Enfermedad()
        
        { }
        public int InsertarPacienteEnfermedad()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTARPACIENTE_ENFERMEDAD ?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this._IDPACIENTEENFERMEDAD, 2);
            objetoconexion.annadir_parametro(this._IDPACIENTE._IDPACIENTE, 2);
            objetoconexion.annadir_parametro(this._IDENFERMEDAD._IDENFERMEDAD, 2);

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

    }
}