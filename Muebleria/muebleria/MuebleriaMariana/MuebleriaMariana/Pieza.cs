using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuebleriaMariana
{
    public class Pieza
    {
        private Int32 id_pieza;

        public Int32 _id_pieza
        {
            get { return id_pieza; }
            set { id_pieza = value; }
        }

        private String nombre_pieza;

        public String _Nombre_pieza
        {
            get { return nombre_pieza; }
            set { nombre_pieza = value; }
        }

        private String descripcion;

        public String _Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private String foto1_pieza;

        public String _Foto1_pieza
        {
            get { return foto1_pieza; }
            set { foto1_pieza = value; }
        }
        private String foto2_pieza;

        public String _Foto2_pieza
        {
            get { return foto2_pieza; }
            set { foto2_pieza = value; }
        }

        private Decimal precio_pieza;

        public Decimal _Precio_pieza
        {
            get { return precio_pieza; }
            set { precio_pieza = value; }
        }

        private String unidad_medida;

        public String _Unidad_medida
        {
            get { return unidad_medida; }
            set { unidad_medida = value; }
        }
        public Pieza() //constructor
        { 
        
        }
        //Eventos 
        public int Insertar_Piezas()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC INSERTAR_PIEZA ?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_pieza,1);
            objetoconexion.annadir_parametro(this.nombre_pieza, 2);
            objetoconexion.annadir_parametro(this.descripcion,2);
            objetoconexion.annadir_parametro(this.foto1_pieza,6);
            objetoconexion.annadir_parametro(this.foto2_pieza, 6);
            objetoconexion.annadir_parametro(this.precio_pieza, 3);
            objetoconexion.annadir_parametro(this.unidad_medida, 2);
            Contenedor = objetoconexion.busca();
            while(Contenedor.Read())
            {
                Resultado = Convert.ToInt32(Contenedor[0].ToString());
            }
            objetoconexion.conexion.Close();
            objetoconexion.conexion.Dispose();
            Contenedor.Close();
            return Resultado;
        }
        public int Modificar_Piezas()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ACTUALIZAR_PIEZA ?,?,?,?,?,?,?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_pieza, 1);
            objetoconexion.annadir_parametro(this.nombre_pieza, 2);
            objetoconexion.annadir_parametro(this.descripcion, 2);
            objetoconexion.annadir_parametro(this.foto1_pieza, 6);
            objetoconexion.annadir_parametro(this.foto2_pieza, 6);
            objetoconexion.annadir_parametro(this.precio_pieza, 3);
            objetoconexion.annadir_parametro(this.unidad_medida, 2);
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
        public int Eliminar_Piezas()
        {
            int Resultado = 0;
            Basededatos.Conexion objetoconexion = new Basededatos.Conexion();
            objetoconexion.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;
            Consulta = "EXEC ELIMINAR_PIEZA ?";
            objetoconexion.annadir_consulta(Consulta);
            objetoconexion.annadir_parametro(this.id_pieza, 1);
            
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
        public static List<Pieza> Seleccionar()
        {
            List<Pieza> Listadepiezas = new List<Pieza>();

            Basededatos.Conexion conx_detalles = new Basededatos.Conexion();
            conx_detalles.inicializa();
            string Consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;

            Consulta = "EXEC SELECCIONARPIEZA";
            conx_detalles.annadir_consulta(Consulta);
   
            Contenedor = conx_detalles.busca();
            while (Contenedor.Read())
            {
                Pieza IB = new Pieza();
                
                IB._id_pieza = Convert.ToInt32(Contenedor["ID_PIEZA"].ToString());
                IB._Nombre_pieza = Contenedor["NOMBRE_PIEZA"].ToString();
                IB._Descripcion = Contenedor["DESCRIPCION"].ToString();
                IB._Foto1_pieza = Contenedor["FOTO1_PIEZA"].ToString();
                IB._Foto2_pieza = Contenedor["FOTO2_PIEZA"].ToString();
                IB._Precio_pieza = Convert.ToDecimal(Contenedor["PRECIO_PIEZA"].ToString());
                IB._Unidad_medida = Contenedor["UNIDAD_MEDIDA"].ToString();
                Listadepiezas.Add(IB);
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            Contenedor.Close();
            return Listadepiezas;
        }
    }
}