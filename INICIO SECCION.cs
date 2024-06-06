using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPAPRESENTACIONN
{
    public partial class INICIO_SECCION : Form
    {
        public object Conexion { get; private set; }

        private readonly string usuario = "Jorlenys";
        private readonly string contraseña = "123456";
        public INICIO_SECCION()
        {
            InitializeComponent();
            Conexion = new SqlConnection();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContraseña.Text;

            if (usuarioIngresado == usuario && contrasenaIngresada == contraseña)
            {

                Form1 form1= new Form1();
                form1.Show();
            }
            else
            {

                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
