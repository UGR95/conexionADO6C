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

        public DataTable Refrescar()
        {
            string Query = "Select * from Authors with(nolock)";
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(Connexionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }

            con.Close();
            return dt;

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
                string QueryAgregar = "INSERT INTO Authors VALUES (" +
                    "'" + id + "'," +
                    "'" + Apellido + "'," +
                    "'" + Nombre + "'," +
                    "'" + Telefono + "'," +
                    "'" + Direccion + "'," +
                    "'" + Ciudad + "'," +
                    "'" + Estado + "'," +
                    "" + CodigoPostal + "," +
                    "" + Contrato + ")";


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
