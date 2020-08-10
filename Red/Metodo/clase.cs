using BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo
{
    public class clase
    {

        public bool acceso;
        public string foto;
      


        private Class1 objetocd = new Class1();



        private Bdconexion Conexion = new Bdconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();



        public void Insertar(string nombre, String apellido, string foto, string correo, String usuario, string contraseña, string Ccontra)
        {
            objetocd.Insertar(nombre, apellido, foto, correo, usuario, contraseña, Ccontra);


        }

        public void Login(string Usuario, string Contra)
        {

            objetocd.Login(Usuario, Contra);
            acceso = objetocd.acceso;
            foto = objetocd.foto;

        }



        public void InsertarP(string titulo, string contenido, string fecha)
        {
            objetocd.InsertarP(titulo, contenido, fecha);


        }

        public DataTable MostrarP()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarP();
            return tabla;
        }

        public DataTable MostrarAE()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarAE();
            return tabla;
        }

        public DataTable MostrarU()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarP();
            return tabla;
        }

        public DataTable MostrarA()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarP();
            return tabla;
        }
        public DataTable MostrarC()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarC();
            return tabla;
        }

        public void EliminiarA(String IDA)
        {

            objetocd.EliminarA(Convert.ToInt32(IDA));

        }

        public void EliminiarP(String ID)
        {

            objetocd.EliminarP(Convert.ToInt32(ID));

        }



        public void InsertarA(string NombreU, int IDA)
        {
            objetocd.InsertarA(NombreU, IDA);


        }

        public void InsertarC(string comentario)
        {
            objetocd.InsertarC(comentario); 
        }

        public void IDP(string IDP)
        {
            objetocd.IDP(IDP);
        }
        public void IDU(string IDU)
        {
            objetocd.IDU(IDU);
        }


        public void Editar(int IDP ,string titulo, string contenido)
        {

            objetocd.Editar(IDP, titulo,contenido);

        }
        public DataTable mostrarMP()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarMisP();
            return tabla;
        }
    }
}
