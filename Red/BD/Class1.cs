using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Class1
    {

        public bool acceso;
        public bool Recuperar;
        public string foto = User.foto;
      


        private Bdconexion Conexion = new Bdconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public void Insertar(string nombre, String apellido, string foto, string correo, string usuario, string contraseña, string Ccontra)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into Registro values ('" + nombre + "','" + apellido + "','" + foto + "','" + correo + "','" + usuario + "','" + contraseña + "','" + Ccontra + "')";

            comando.ExecuteNonQuery();



        }

        public bool Login(string Usuario, string Contra)
        {

            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "SELECT usuario, contraseña FROM Registro where usuario='" + Usuario + "' And contraseña='" + Contra + "'";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                acceso = true;

            }
            else
            {
                acceso = false;
            }

            Conexion.CerrarConexion();
            comando.Connection = Conexion.AbrirConexion();

            string query = "SELECT IDU FROM Registro where usuario='" + Usuario + "' And contraseña='" + Contra + "'";
            comando.CommandText = query;

            User.user = Convert.ToInt32(comando.ExecuteScalar());

            Conexion.CerrarConexion();
            if (acceso == true)
            {
                comando.Connection = Conexion.AbrirConexion();

                string query1 = "SELECT foto FROM Registro where usuario='" + Usuario + "' And contraseña='" + Contra + "'";
                comando.CommandText = query1;

                User.foto = comando.ExecuteScalar().ToString();

                Conexion.CerrarConexion();
            }
            return acceso;

        }


        public void InsertarP(string titulo, string contenido, string fecha)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into publicacion values (" + User.user + " , '" + titulo + "' , '" + contenido + "' , '" + fecha + "')";

            comando.ExecuteNonQuery();



        }

        public void InsertarE(string NomE, string Lugar, int CntidadP, DateTime fecha)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into eventos values (" + User.user + " , '" + NomE + "' , '" + Lugar + "' ," + CntidadP + " , '" + fecha + "')";

            comando.ExecuteNonQuery();



        }


        public DataTable MostrarP()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select p.* from amigos a inner join publicacion p on p.IDU = a.IDUA or p.IDU = a.IDU where a.IDU =" + User.user;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarAE()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select a.IDUA, r.nombre, r.Apellido, r.usuario from amigos a inner join Registro r on r.IDU = a.IDUA where a.IDU =" + User.user;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarU()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select IDU ,usuario  from Registro  ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarME()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select * from eventos where IDU="+User.user;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }


        public DataTable MostrarC()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select * from comentario where IDP =" + User.IDP;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }


        public void InsertarA(string NombreU, int IDA)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into amigos values (" + User.user + "," + IDA + ",'" + NombreU + "')";

            comando.ExecuteNonQuery();



        }

        public void InsertarAE(int IDUA , string Nombre, string Apellido, string NombreU)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into invitados values (" + User.IDE + "," + IDUA + ",'" + Nombre + "','" + Apellido + "','" + NombreU + "',' Sin respuesta ')";

            comando.ExecuteNonQuery();



        }

        public void InsertarC(string comentario)
        {
           
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into comentario values (" + User.IDP + " ," + User.user + " , '" + comentario + "')";

            comando.ExecuteNonQuery();



        }

        public void IDP(string IDP)
        {

            User.IDP = Convert.ToInt32(IDP);

        }
        public void IDU(string IDU)
        {

            User.IDU = Convert.ToInt32(IDU);
        }
        public void IDE(int IDE)
        {

            User.IDE = IDE;
        }


        public void EliminarA(int IDA)
        {




            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "EliminarA";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDA", IDA);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarE(int IDE)
        {




            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "eliminarE";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDE", IDE);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarI(int IDI)
        {




            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "eliminarI";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDI", IDI);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarP(int ID)
        {




            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "EliminarP";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDP", ID);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public DataTable MostrarA()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select IDA ,NombreU  from amigos where IDU="+User.user;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarEI()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select e.* from eventos e inner join invitados i on i.IDE = e.IDE inner join Registro r on r.IDU = i.IDUA where r.IDU =" + User.user;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarMisP()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select * from publicacion where IDU=" + User.user;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public DataTable MostrarIR()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select IDI,nombre, Apellido, respuesta from invitados  where IDE =" + User.IDE;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

        public void Editar(int IDP, string titulo, string contenido)
        {

            SqlCommand comando = new SqlCommand();


            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "Editar ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", IDP);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@contenido", contenido);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();




        }


        public void EditarR(int IDI, string respuesta)
        {

            SqlCommand comando = new SqlCommand();


            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "Respuesta ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDI", IDI);
            comando.Parameters.AddWithValue("@Respuesta", respuesta);
            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();




        }


        public void recuperar(string nombreUsuario)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "SELECT usuario, contraseña FROM Registro where usuario='" + nombreUsuario + "'";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                Recuperar = true;

            }
            else
            {
                Recuperar = false;
            }

            Conexion.CerrarConexion();

            if(Recuperar == true)
            {

            comando.Connection = Conexion.AbrirConexion();

            string query = "SELECT IDU FROM Registro where usuario='" + nombreUsuario + "'";
            comando.CommandText = query;

            User.IDU = Convert.ToInt32(comando.ExecuteScalar());

            Conexion.CerrarConexion();
            comando.Connection = Conexion.AbrirConexion();

            string query1 = "SELECT correo FROM Registro where usuario='" + nombreUsuario + "'";
            comando.CommandText = query1;

            User.email = comando.ExecuteScalar().ToString();

            Conexion.CerrarConexion();

                Random rr = new Random();
                int contra = rr.Next(5552);

                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage();
                mm.To.Add(User.email);
                mm.Subject = Convert.ToString("su nueva contraseña");
                mm.SubjectEncoding = System.Text.Encoding.UTF8;

                mm.Body = (Convert.ToString(contra));
                mm.BodyEncoding = System.Text.Encoding.UTF8;
                mm.IsBodyHtml = true;
                mm.From = new System.Net.Mail.MailAddress("20186954@itla.edu.do");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                cliente.Credentials = new System.Net.NetworkCredential("20186954@itla.edu.do", "20186954");

                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";

                try
                {
                    cliente.Send(mm);
                   
                }
                catch (Exception)
                {
                   
                }


                comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "edi ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDU", User.IDU);
            comando.Parameters.AddWithValue("@contra", contra);
            comando.Parameters.AddWithValue("@ccontra", contra);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            }




        }



    }


}
