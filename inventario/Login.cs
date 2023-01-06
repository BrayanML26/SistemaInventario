using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using utilidades;

namespace inventario
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            try
            {
                String cmd = string.Format("SELECT * FROM Usuarios WHERE Usuario = '{0}' AND Password = '{1}'", 
                    txtUsuario.Text.Trim(), txtPassword.Text.Trim());

                DataSet ds = utilidades.utilidad.ejecuta(cmd);

                String Cuenta = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                String Contra = ds.Tables[0].Rows[0]["Password"].ToString().Trim();

                if(Cuenta == txtUsuario.Text.Trim() && Contra == txtPassword.Text.Trim())
                {
                    MessageBox.Show("Bienvenido " + Cuenta );

                    Menu m = new Menu();
                    this.Hide();
                    m.Show();

                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Usuario / Password Incorrectos.");
            }

        }

        //CONVERT(nvarchar(100),DECRYPTBYPASSPHRASE('Password',Password));

        // conectar a sql validacion
        //DialogResult = DialogResult.OK;
        //Close();

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
