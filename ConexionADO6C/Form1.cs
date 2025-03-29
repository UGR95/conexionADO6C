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
                //llenamos el gridview con la información que regresa el metodo Refrescar
                dgvDatos.DataSource = datos.Refrescar(null);

                //Lamamo el metodo para cargar los estados en el Combobox
                CargarEstados();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            DataTable dt = new DataTable();
            try
            {
                //Lenamos un dataTable con la información que regresa el metodo CargarEstados
                dt = datos.CargarEstados();

                //Generamos una nueva fila para seleccionarla por default
                DataRow nuevaFila = dt.NewRow();
                nuevaFila["Abreviacion"] = DBNull.Value;  // Sin valor
                nuevaFila["Nombre"] = "Seleccionar Estado";
                dt.Rows.InsertAt(nuevaFila, 0);

                //Cargamos el combobox con los estados
                cbEstados.DataSource = dt;
                //Indicamos que se va a mostrar el valor Nombre
                cbEstados.DisplayMember = "Nombre";
                //Indicamos que se va a enviar el valor Abreviación cuando realicemos alguna acción
                cbEstados.ValueMember = "Abreviacion";

                cbEstados.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
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

                    //Limpiamos controles despues de agregar registro
                    Limpiar();
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
            //Generamos una region usando #region, sirve para colapsar el código dentro de la región
            #region Mapeo Grid
            //if (dgvDatos.SelectedRows.Count > 0)
            //{

            //    DataGridViewRow selec = dgvDatos.SelectedRows[0];

            //    if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
            //    {
            //        mskId.Text = selec.Cells[0].Value.ToString();
            //        mskId.Enabled = false;
            //        txbApellido.Text = selec.Cells[1].Value.ToString();
            //        txbNombre.Text = selec.Cells[2].Value.ToString();
            //        mskTelefono.Text = selec.Cells[3].Value.ToString();
            //        txbDireccion.Text = selec.Cells[4].Value.ToString();
            //        txbCiudad.Text = selec.Cells[5].Value.ToString();
            //        txbEstado.Text = selec.Cells[6].Value.ToString();
            //        txbCP.Text = selec.Cells[7].Value.ToString();
            //        chbContrato.Checked = Convert.ToBoolean(selec.Cells[8].Value);

            //    }
            //    else
            //    {
            //        Limpiar();
            //    }
            //}
            #endregion
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string _Id = "";
            string _Nombre = "";
            string _Apellido = "";
            string _Telefono = "";
            string _Direccion = "";
            string _Ciudad = "";
            string _Estado = "";
            string _CodigoPostal = "";
            bool _Contrato = false;
            try
            {

                //Validamos que solo se pueda seleccionar 1 registro
                if (dgvDatos.SelectedRows.Count == 1)
                {

                    DataGridViewRow selec = dgvDatos.SelectedRows[0];

                    //Validamos que la información no sea nulla o vacia
                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        _Id = selec.Cells[0].Value.ToString();
                        _Nombre = selec.Cells[1].Value.ToString();
                        _Apellido = selec.Cells[2].Value.ToString();
                        _Telefono = selec.Cells[3].Value.ToString();
                        _Direccion = selec.Cells[4].Value.ToString();
                        _Ciudad = selec.Cells[5].Value.ToString();
                        _Estado = selec.Cells[6].Value.ToString();
                        _CodigoPostal = selec.Cells[7].Value.ToString();
                        _Contrato = Convert.ToBoolean(selec.Cells[8].Value);

                        //Realizamos instancia del formulario frmAtualizarAutor, le enviamos los parametros seleccionados
                        frmActualizarAutor frm = new frmActualizarAutor(_Id, _Nombre, _Apellido, _Telefono, _Direccion, _Ciudad, _Estado, _CodigoPostal, _Contrato);
                        //Mostramos el formulario
                        frm.Show();
                        //Ocultamos el formulario principal
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Favor de seleccionar un registro válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Favor de seleccionar solo 1 registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //Generamos una region usando #region, sirve para colapsar el código dentro de la región
                #region Antes llamado a datos.Modificar
                //Error = datos.ModificarAutor(mskId.Text, txbNombre.Text, txbApellido.Text, mskTelefono.Text, txbDireccion.Text, txbCiudad.Text, txbEstado.Text, Convert.ToInt32(txbCP.Text), chbContrato.Checked);
                //if (string.IsNullOrEmpty(Error))
                //{
                //    MessageBox.Show("Registro Actualizado correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    Refrescar();
                //}
                //else
                //{
                //    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                #endregion

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string estado = cbEstados.SelectedIndex != 0 ? cbEstados.SelectedValue?.ToString() : null;
                dgvDatos.DataSource = datos.Refrescar(estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            mskId.Clear();
            mskId.Enabled = true;
            txbApellido.Clear();
            txbNombre.Clear();
            mskTelefono.Clear();
            txbDireccion.Clear();
            txbCiudad.Clear();
            txbEstado.Clear();
            txbCP.Clear();
            chbContrato.Checked = false;
        }
    }
}
