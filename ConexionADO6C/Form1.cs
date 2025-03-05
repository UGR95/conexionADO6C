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

                Error = datos.AgregarAutor(mskId.Text, txbNombre.Text, txbApellido.Text, mskTelefono.Text, txbDireccion.Text, txbCiudad.Text, txbEstado.Text, Convert.ToInt32(txbCP.Text), chbContrato.Checked);

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = "";

                Error = datos.EliminarAutor(mskId.Text);

                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Registro Borrado correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {

                DataGridViewRow selec = dgvDatos.SelectedRows[0];

                if (selec != null)
                {
                    mskId.Text = selec.Cells[0].Value.ToString();
                    txbApellido.Text = selec.Cells[1].Value.ToString();
                    txbNombre.Text = selec.Cells[2].Value.ToString();
                    mskTelefono.Text = selec.Cells[3].Value.ToString();
                    txbDireccion.Text = selec.Cells[4].Value.ToString();
                    txbCiudad.Text = selec.Cells[5].Value.ToString();
                    txbEstado.Text = selec.Cells[6].Value.ToString();
                    txbCP.Text = selec.Cells[7].Value.ToString();
                    chbContrato.Checked = Convert.ToBoolean(selec.Cells[8].Value);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string Error;

                Error = datos.ModificarAutor(mskId.Text, txbNombre.Text, txbApellido.Text, mskTelefono.Text, txbDireccion.Text, txbCiudad.Text, txbEstado.Text, Convert.ToInt32(txbCP.Text), chbContrato.Checked);
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Registro Actualizado correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Refrescar();
                }
                else
                {
                    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
