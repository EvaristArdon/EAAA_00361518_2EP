using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial02.Modelo;

namespace Parcial02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void poblarControles()
        {
            cmbUser.DataSource = null;
            cmbUser.ValueMember = "password";
            cmbUser.DisplayMember = "user";
            cmbUser.DataSource = UserDAO.getLista();
        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedValue.Equals(textBox1.Text))
            {
                User u = (User) cmbUser.SelectedItem;
                    
                MessageBox.Show("¡Bienvenido!");
                
                FrmPrincipal ventana = new FrmPrincipal(u);
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡Contraseña ingresada es incorrecta!");
            }
        }
        

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            FrmChangePassword unaVentana = new FrmChangePassword();
            unaVentana.ShowDialog();
            poblarControles();
        }

        private void textBox1_KeyDown(object sender,  KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnIniciarSesión_Click(sender, e);
        }
    }
}