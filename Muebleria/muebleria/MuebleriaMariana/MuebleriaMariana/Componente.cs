using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuebleriaMariana
{
    public class Componente
    {
        private Int32 id_componente;

        public Int32 _Id_componente
        {
            get { return id_componente; }
            set { id_componente = value; }
        }

        private String nombre_componente;

        public String _Nombre_componente
        {
            get { return nombre_componente; }
            set { nombre_componente = value; }
        }

        private Int32 precio_componente;

        public Int32 _Precio_componente
        {
            get { return precio_componente; }
            set { precio_componente = value; }
        }

        private String foto1_componente;

        public String _Foto1_componente
        {
            get { return foto1_componente; }
            set { foto1_componente = value; }
        }

        private String foto2_componente;

        public String _Foto2_componente
        {
            get { return foto2_componente; }
            set { foto2_componente = value; }
        }

        private String tipo_componente;

        public String _Tipo_componente
        {
            get { return tipo_componente; }
            set { tipo_componente = value; }
        }
        
        private List<Pieza> Piezas;
        public Componente() //constructor
        { 
        
        }
        //Eventos 
        public int Insertar_Componente()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTAR_COMPONENTE ?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_componente, 1);
            objetoconexion.annadir_parametro(this.nombre_componente, 2);
            objetoconexion.annadir_parametro(this.precio_componente, 1);
            objetoconexion.annadir_parametro(this.foto1_componente, 6);
            objetoconexion.annadir_parametro(this.foto2_componente, 6);
            objetoconexion.annadir_parametro(this.tipo_componente, 2);
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
        public int Modificar_Componente()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZAR_COMPONENTE ?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_componente, 1);
            objetoconexion.annadir_parametro(this.nombre_componente, 2);
            objetoconexion.annadir_parametro(this.precio_componente, 1);
            objetoconexion.annadir_parametro(this.foto1_componente, 6);
            objetoconexion.annadir_parametro(this.foto2_componente, 6);
            objetoconexion.annadir_parametro(this.tipo_componente, 2);
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
        public int Eliminar_Componente()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINAR_COMPONENTE ?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_componente, 1);

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
        public static List<Componente> Seleccionar()
        {
            List<Componente> Listadecomponentes = new List<Componente>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARCOMPONENTE";
            conx_detalles.annadir_consulta(Consulta);

            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Componente IB = new Componente();

                IB._Id_componente = Convert.ToInt32(Contenedor["ID_COMPONENTE"].ToString());
                IB._Nombre_componente = Contenedor["NOMBRE_COMPONENTE"].ToString();
                IB._Tipo_componente = Contenedor["TIPO_COMPONENTE"].ToString();
                IB._Foto1_componente = Contenedor["FOTO1_COMPONENTE"].ToString();
                IB._Foto2_componente = Contenedor["FOTO2_COMPONENTE"].ToString();
                IB._Precio_componente = Convert.ToInt32(Contenedor["PRECIO_COMPONENTE"].ToString());
                Listadecomponentes.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listadecomponentes;
        }
        public static int InsertarPiezaAComponente(Componente L, Pieza M, Decimal CANTIDAD)
        {
            int respuesta = 0;

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC INSERTAR_PIEZA_COMPONENTE ?,?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            
            conx_detalles.annadir_parametro(M._id_pieza, 1);
            conx_detalles.annadir_parametro(L._Id_componente, 1);
            conx_detalles.annadir_parametro(CANTIDAD, 3);

            CONTENEDOR = conx_detalles.busca();
            while (CONTENEDOR.Read())
            {
                respuesta = Convert.ToInt16(CONTENEDOR[0].ToString());
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            CONTENEDOR.Close();
            return L._Id_componente;
        }

    }
}