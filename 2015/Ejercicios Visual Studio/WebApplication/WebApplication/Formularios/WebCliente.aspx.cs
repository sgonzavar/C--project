using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libWebAppplication.AtenderFormularios;

namespace WebApplication.Formularios
{
    public partial class WebCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            LlenarComboTipoId();
            LlenarComboCiudad();

        }

        private void LlenarGrid()
        {
            ClsCliente oCliente = new ClsCliente();
            oCliente._GridCliente = GridView1;
            if (!oCliente.LlenarGrid())
            {
                lblError.Text = oCliente._Error;
            }

            oCliente = null;
        }

        private void LlenarComboTipoId()
        {
            
            ClsCliente oCliente = new ClsCliente();
            oCliente._TipoId = cmbTipoId;
            if (!oCliente.LenarComboTipoId())
            {
                lblError.Text = oCliente._Error;
            }           

            oCliente = null;

        }

        private void LlenarComboCiudad()
        {
            ClsCliente oCliente = new ClsCliente();
            oCliente._Ciudad = cmbCuidad;
            if (!oCliente.LenarComboCiudad())
            {
                lblError.Text = oCliente._Error;
            }

            oCliente = null;

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string sNombre, sApellidos, sCedula, sTelefono;
            string sCorreo, sDireccion;

            sCedula = txtCedula.Text;
            sNombre = txtNombre.Text;
            sApellidos = txtApellido.Text;
            sTelefono = txtTelefono.Text;
            sDireccion = txtDireccion.Text;
            sCorreo = txtCorreo.Text;

            ClsCliente oclint = new ClsCliente();
            oclint._Cedula = sCedula;
            oclint._Nombre = sNombre;
            oclint._Apellido = sApellidos;
            oclint._Telefono = sTelefono;
            oclint._Direccion = sDireccion;
            oclint._Correo = sCorreo;

            if (oclint.Insertar())
            {
                lblSql.Text = "Grabó";
                LlenarGrid();
            }
            else
            {
                lblError.Text = oclint._Error;
            }
            oclint = null;

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string sNombre, sApellidos, sCedula, sTelefono;
            string sCorreo, sDireccion;


            sCedula = txtCedula.Text;
            sNombre = txtNombre.Text;
            sApellidos = txtApellido.Text;
            sTelefono = txtTelefono.Text;
            sDireccion = txtDireccion.Text;
            sCorreo = txtCorreo.Text;

            ClsCliente oclint = new ClsCliente();
            oclint._Cedula = sCedula;
            oclint._Nombre = sNombre;
            oclint._Apellido = sApellidos;
            oclint._Telefono = sTelefono;
            oclint._Direccion = sDireccion;
            oclint._Correo = sCorreo;

            if (oclint.Actualizar())
            {
                lblSql.Text = "Actualizó";
                LlenarGrid();
            }
            else
            {
                lblError.Text = oclint._Error;
            }
            oclint = null;

        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            
             string sCedula;

            sCedula = txtCedula.Text;

            ClsCliente oclint = new ClsCliente();
            oclint._Cedula = sCedula;

            if (oclint.Eliminar())
            {
                lblSql.Text = "Borrado";
                LlenarGrid();
            }
            else
            {
                lblError.Text = oclint._Error;
            }
            oclint = null;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            string sCedula;

            sCedula = txtCedula.Text;

            ClsCliente oclint = new ClsCliente();
            oclint._Cedula = sCedula;

            if (oclint.Consultar())
            {
                txtCedula.Text = oclint._Cedula;
                txtNombre.Text = oclint._Nombre;
                txtApellido.Text = oclint._Apellido;
                txtTelefono.Text = oclint._Telefono;
                txtDireccion.Text = oclint._Direccion;
                //cmbTipoId.SelectedValue = oclint;
                               
                lblSql.Text = "Consulto";
            }
            else
            {
                lblError.Text = oclint._Error;
            }
            oclint = null;
            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Formularios/WebPrincipal.aspx");
        }
    }
}