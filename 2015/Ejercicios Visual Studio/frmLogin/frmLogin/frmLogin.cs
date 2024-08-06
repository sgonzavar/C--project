using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// referenciar para poder usar sql
//using System.Data.SqlClient;

namespace frmLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            claUsuarios UsuariosOb = new claUsuarios();
            UsuariosOb.UserName = this.txtUser.Text;
            UsuariosOb.Pass = this.txtPass.Text;

            if (UsuariosOb.Buscar() == true)
            {
                MessageBox.Show(UsuariosOb.Mensaje, "Login");
            }
            else
            {
                MessageBox.Show(UsuariosOb.Mensaje, "Error");
            }

        }

       
    }
}
