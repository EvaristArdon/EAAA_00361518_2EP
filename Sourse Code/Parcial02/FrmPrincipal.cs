using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Parcial02.Modelo;

namespace Parcial02
{
    public partial class FrmPrincipal : Form
    {
        private User user;
        public FrmPrincipal(User pUser)
        {
            InitializeComponent();
            user = pUser;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + user.user + " [" + (user.admin ? "Administrador" : "Usuario") + "]";

            if (user.admin)
            {
                admin();
                tabControl1.TabPages[0].Parent = null;
                tabControl1.TabPages[0].Parent = null;
            }
            else
            {
                tabControl1.TabPages[2].Parent = null;
                tabControl1.TabPages[2].Parent = null;
                tabControl1.TabPages[2].Parent = null;
                tabControl1.TabPages[2].Parent = null;
            }
            
            var products = ConnectionDB.ExecuteQuery("SELECT name FROM PRODUCT");
            var productsCombo = new List<string>();

            foreach (DataRow dr in products.Rows)
            {
                productsCombo.Add(dr[0].ToString());  
            }

            cmbProductos.DataSource = productsCombo;

            string user2 = this.user.user;

            try
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT ord.idOrder, use.username, nego.name, pro.name, " +
                                                   $"dir.address " +
                                                   "FROM APPORDER ord, APPUSER use, BUSINESS nego, PRODUCT pro, ADDRESS dir  " +
                                                   $"WHERE use.idUser = dir.idUser " +
                                                   $"AND pro.idProduct = ord.idProduct " +
                                                   $"AND dir.idAddress = ord.idAddress " +
                                                   $"AND use.username = '{user2}'");

                dgrPedidos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {

            if (txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar campos vacíos");
            }

            try
            {
                string query = $"SELECT idProduct FROM PRODUCT WHERE name = '{cmbProductos.SelectedItem.ToString()}'";
                var dt = ConnectionDB.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var idProduct = Convert.ToInt32(dr[0].ToString());
            
                string query2 = $"SELECT idAddress FROM ADDRESS WHERE address = '{txtDireccion.Text.ToString()}'";
                var dt2 = ConnectionDB.ExecuteQuery(query2);
                var dr2 = dt2.Rows[0];
                var idAddress = Convert.ToInt32(dr2[0].ToString());

                DateTime date = DateTime.Now;
                //DateTime date = new DateTime(2020, 5, 27);
                string date2 = date.ToString("yy-MM-dd");
            
                string nonQuery = $"INSERT INTO APPORDER(createDate, idProduct, idAddress) VALUES( " +
                                  $"'{date2}', " +
                                  $"{idProduct}, " +
                                  $"{idAddress})";
            
                ConnectionDB.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Ha ordenado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                  string nonQuery = $"DELETE FROM APPORDER WHERE idOrder = {txtOrdenEliminar.Text}";
                            ConnectionDB.ExecuteNonQuery(nonQuery);
                
                            MessageBox.Show("Se ha eliminado su orden");
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
          }
        private void btnDireccionModificar_Click(object sender, EventArgs e)
        {

            try
            {
                string query2 = $"SELECT idAddress FROM ADDRESS WHERE address = '{txtDireccionModificar.Text.ToString()}'";
                var dt2 = ConnectionDB.ExecuteQuery(query2);
                var dr2 = dt2.Rows[0];
                var idAddress = Convert.ToInt32(dr2[0].ToString());
            
                string nonQuery =$"UPDATE ADDRESS SET address = '{txtDireccionNueva.Text}' WHERE idAddress = {idAddress}"; 
                ConnectionDB.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Se ha actualizado su dirección"); 
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {

            try
            {
                string query2 = $"SELECT idAddress FROM ADDRESS WHERE address = '{txtDireccionEliminar.Text.ToString()}'";
                var dt2 = ConnectionDB.ExecuteQuery(query2);
                var dr2 = dt2.Rows[0];
                var idAddress = Convert.ToInt32(dr2[0].ToString());
            
                string nonQuery = $"DELETE FROM ADDRESS WHERE idAddress = {idAddress}";
                ConnectionDB.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Se ha eliminado su dirección");
                
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }
        
        private void btnVerDirecciones_Click(object sender, EventArgs e)
        {
            try
            {
                string query2 = $"SELECT idUser FROM APPUSER WHERE username = '{txtUser.Text.ToString()}'";
                var dt2 = ConnectionDB.ExecuteQuery(query2);
                var dr2 = dt2.Rows[0];
                var idUser = Convert.ToInt32(dr2[0].ToString());
            
                var dt =ConnectionDB.ExecuteQuery($"SELECT * FROM ADDRESS WHERE idUser = {idUser}");
                dgrDireccion.DataSource = dt;
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
         
        }

        private void admin()
        {
            try
            {
                //DATA GRID VIEW APPORDER
                var dt2 = ConnectionDB.ExecuteQuery($"SELECT ord.idOrder, use.fullname, nego.name, pro.name, " +
                                                    $"dir.address " +
                                                    "FROM APPORDER ord, APPUSER use, BUSINESS nego, PRODUCT pro, ADDRESS dir  " +
                                                    $"WHERE use.idUser = dir.idUser " +
                                                    $"AND pro.idProduct = ord.idProduct " +
                                                    $"AND dir.idAddress = ord.idAddress"); 
                                                
                dgrOrdenes.DataSource = dt2;
            
                //DATA GRID WIEW BUSINESS
                var dt = ConnectionDB.ExecuteQuery("SELECT * FROM BUSINESS");

                dgrNegocios.DataSource = dt;
            
                //DATA GRID WIEW PRODUCT
                var dt3 = ConnectionDB.ExecuteQuery("SELECT * FROM PRODUCT");
            
                dgrProductos.DataSource = dt3;
              
                //DATA GRID WIEW APPUSER
                var dt4 = ConnectionDB.ExecuteQuery("SELECT * FROM APPUSER");
            
                dgrUsuarios.DataSource = dt4;
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
         }

        private void btnAgregarNegocio_Click(object sender, EventArgs e)
        {
            try
            {
                string nonQuery = $"INSERT INTO BUSINESS(name, description) VALUES( " +
                                  $"'{txtNegocio.Text}', " +
                                  $"'{richTextBox1.Text}')";
            
                ConnectionDB.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Se agrego el negocio correctamente");
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }    
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT idBusiness FROM BUSINESS WHERE name = '{txtNombreNegocio2.Text.ToString()}'";
                var dt = ConnectionDB.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var idBusiness = Convert.ToInt32(dr[0].ToString());
            
                string nonQuery = $"INSERT INTO PRODUCT(idBusiness, name) VALUES( " +
                                  $"'{idBusiness}', " +
                                  $"'{txtNombreProducto.Text}')";
            
                ConnectionDB.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Se agrego correctamente dicho producto");
            }
            catch (Exception ex)
            {
            MessageBox.Show("Ha ocurrido un error");
            }    
        }
        
        private void btnAgregarUsuari_Click(object sender, EventArgs e)
        {
            try
            {
                string nonQuery = $"INSERT INTO APPUSER(fullname, username, password, userType) VALUES( " +
                                  $"'{txtNombreCompleto.Text}', " +
                                  $"'{txtNombreUsuario.Text}', " +
                                  $"'{txtNombreUsuario.Text}', " +
                                  $"{false})";
            
                ConnectionDB.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Se agrego correctamente al usuario");
                
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }    
            
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                string query = $"SELECT idUser FROM APPUSER WHERE username = '{txtNombreUsuario.Text}'";
                var dt = ConnectionDB.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var idUser = Convert.ToInt32(dr[0].ToString());
        
                string nonQuery = $"DELETE FROM APPUSER WHERE idUser = {idUser}";
                ConnectionDB.ExecuteNonQuery(nonQuery);
            
                MessageBox.Show("Se ha eliminado al usuario correctamente");
            }
            catch (Exception ex)
            {
              MessageBox.Show("Ha ocurrido un error");
            }    
           
        }
        
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + user.user + "?", 
                "Parcial02", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Necesario porque el frmInicioSesion está escondido
            Application.Exit();
        }

        private void btnEliminarNegocio_Click(object sender, EventArgs e)
        {
            try
            {
                string query2 = $"SELECT idBusiness FROM BUSINESS WHERE name = '{txtNegocio.Text.ToString()}'";
                var dt2 = ConnectionDB.ExecuteQuery(query2);
                var dr2 = dt2.Rows[0];
                var idBusiness = Convert.ToInt32(dr2[0].ToString());
            
                string nonQuery = $"DELETE FROM BUSINESS WHERE idBusiness = {idBusiness}";
                ConnectionDB.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Se ha eliminado su negocio");
                
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string query2 = $"SELECT idProduct FROM PRODUCT WHERE name = '{txtNombreProducto.Text.ToString()}'";
                var dt2 = ConnectionDB.ExecuteQuery(query2);
                var dr2 = dt2.Rows[0];
                var idProduct = Convert.ToInt32(dr2[0].ToString());
            
                string nonQuery = $"DELETE FROM PRODUCT WHERE idProduct = {idProduct}";
                ConnectionDB.ExecuteNonQuery(nonQuery);

                MessageBox.Show("Se ha eliminado el producto");
                
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}