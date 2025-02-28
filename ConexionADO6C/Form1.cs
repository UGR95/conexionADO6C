using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionADO6C
{
    public partial class Form1 : Form
    {
        Datos datos = new Datos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        private void Refrescar()
        {
            try
            {
                dgvDatos.DataSource = datos.Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = datos.Filtro(txbFiltro.Text);

                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = "";

                Error = datos.AgregarAutor(txbId.Text, txbNombre.Text, txbApellido.Text, txbTelefono.Text, txbDireccion.Text, txbCiudad.Text, txbEstado.Text, Convert.ToInt32(txbCP.Text), chbContrato.Checked);

                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Registro agregado correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
