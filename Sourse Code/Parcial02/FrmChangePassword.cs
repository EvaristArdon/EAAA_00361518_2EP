using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            cmbUser.DataSource = null;
            cmbUser.ValueMember = "password";
            cmbUser.DisplayMember = "user";
            cmbUser.DataSource = UserDAO.getLista();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            bool actualpass = cmbUser.SelectedValue.Equals(txtContractual.Text);
            bool newpass = txtNuevaContra.Text.Equals(txtRepetirContra.Text);
            bool newvalid = txtNuevaContra.Text.Length > 0;

            if (actualpass && newpass && newvalid)
            {
                try
                {
                    UserDAO.actualizarContra(cmbUser.Text, txtNuevaContra.Text);
                    MessageBox.Show("Contraseña actualizada exitosamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contraseña no se ha podido actualizar, favor intente nuevamente");
                }
            }
            else
            {
                MessageBox.Show("¡Favor de verificar que los datos no sean erroneos");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}