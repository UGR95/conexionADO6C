using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace ConexionADO6C
{
    internal class Datos
    {
        public string Connexionstring = "Data Source = DESKTOP-7789AN9\\SQLEXPRESS; Initial Catalog = pubs6c; Integrated security = true;";

        public DataTable Refrescar(string Estado)
        {
            //string Query = "Select * from vwAutores with(nolock)";
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(Connexionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("sprConsultarAutores", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Estado", Estado );

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }

            con.Close();
            return dt;

        }

        public DataTable CargarEstados()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand("sprObtenerEstados", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Filtro(string Filtro)
        {
            DataTable dt = new DataTable();
            try
            {
                string QueryFiltro = "SELECT * FROM Authors WITH(NOLOCK) WHERE au_Fname like '%" + Filtro + "%'";

                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(QueryFiltro, con);

                da.Fill(dt);

                con.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string AgregarAutor(string id, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, int CodigoPostal, bool Contrato)
        {
            try
            {
                int cont = Contrato == true ? 1 : 0;
                #region Query insert
                /*string QueryAgregar = "INSERT INTO Authors VALUES (" +
                //    "'" + id + "'," +
                //    "'" + Apellido + "'," +
                //    "'" + Nombre + "'," +
                //    "'" + Telefono + "'," +
                //    "'" + Direccion + "'," +
                //    "'" + Ciudad + "'," +
                //    "'" + Estado + "'," +
                //    "" + CodigoPostal + "," +
                //    "" + cont + ")";
                */
                #endregion

                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand("spi_AgregarAutor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id );
                cmd.Parameters.AddWithValue("@Nombre", Nombre );
                cmd.Parameters.AddWithValue("@Apellido",Apellido );
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Ciudad", Ciudad);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                cmd.Parameters.AddWithValue("@Contrato", cont);

                cmd.ExecuteNonQuery();

                con.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string EliminarAutor(string id)
        {
            try
            {

                string QueryAgregar = "DELETE FROM Authors WHERE au_id = '" + id + "'";


                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand(QueryAgregar, con);

                cmd.ExecuteNonQuery();

                con.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string ModificarAutor(string id, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, int CodigoPostal, bool Contrato)
        {
            try
            {
                int cont = Contrato == true ? 1 : 0;
                string QueryAgregar = "UPDATE Authors" +
                    " SET au_lname = '" + Apellido + "'," +
                    "au_fname = '" + Nombre + "'," +
                    "phone = '" + Telefono + "'," +
                    "address ='" + Direccion + "'," +
                    "city = '" + Ciudad + "'," +
                    "state = '" + Estado + "'," +
                    "zip = " + CodigoPostal + "," +
                    "contract = " + cont + 
                    "WHERE au_id = '" + id +"'";


                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand(QueryAgregar, con);

                cmd.ExecuteNonQuery();

                con.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
