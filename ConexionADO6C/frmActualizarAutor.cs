﻿using System;
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
    public partial class frmActualizarAutor : Form
    {
        string _Id;
        string _Nombre;
        string _Apellido;
        string _Telefono;
        string _Direccion;
        string _Ciudad;
        string _Estado;
        string _CodigoPostal;
        bool _Contrato;
            
        Datos datos = new Datos();
        Form1 form1 = new Form1();
            
        public frmActualizarAutor(string Id, string Nombre, string Apellido, string Telefono , string Direccion, string Ciudad, string Estado, string CodigoPostal, bool Contrato)
        {
            InitializeComponent();
            //Inicializamor componentes globales con la información que recibe el formulario
            _Id = Id;
            _Nombre = Nombre;
            _Apellido = Apellido;
            _Telefono = Telefono;
            _Direccion = Direccion;
            _Ciudad = Ciudad;
            _Estado = Estado;
            _CodigoPostal = CodigoPostal;
            _Contrato = Contrato;

        }

        private void frmActualizarAutor_Load(object sender, EventArgs e)
        {
            mskId.Text = _Id;
            mskId.Enabled = false;
            txbNombre.Text = _Nombre;
            txbApellido.Text = _Apellido;
            mskTelefono.Text = _Telefono;
            txbDireccion.Text = _Direccion;
            txbCiudad.Text = _Ciudad;
            txbEstado.Text = _Estado;
            txbCP.Text = _CodigoPostal;
            chbContrato.Checked = _Contrato;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Error = "";
            try
            {

                Error = datos.ModificarAutor(mskId.Text, txbNombre.Text, txbApellido.Text, mskTelefono.Text, txbDireccion.Text, txbCiudad.Text, txbEstado.Text, Convert.ToInt32(txbCP.Text), chbContrato.Checked);
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Registro Actualizado correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form1.Show();
                    this.Close();
                }
                else
                    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
