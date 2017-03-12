using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USAP_MATRICULA
{
    public partial class frm_Login : Form
    {
        
        public frm_Login()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        private void txtbx_Cuenta_TextChanged(object sender, EventArgs e)
        {
        
        }
  
        private void btn_Acept_Click(object sender, EventArgs e)
        {
           
          
            try
            {
                //creando la conexion
                SqlConnection miConexion = new SqlConnection("Data Source=SQL5018.Smarterasp.net;Initial Catalog=DB_A19EA8_alexhilsaca;User Id=DB_A19EA8_alexhilsaca_admin;Password=honduras2017;");
                //abriendo conexion
                miConexion.Open();

                SqlCommand comando = new SqlCommand("select num_cuenta,nombre from Alumnos where num_cuenta = '" + txtbx_Cuenta.Text+"'" , miConexion);
                //ejecuta una instruccion de sql devolviendo el numero de las filas afectadas
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                //Llenando el dataAdapter
                da.Fill(ds, "Alumnos");
                //utilizado para representar una fila de la tabla q necesitas en este caso usuario
                DataRow DR;
                DR = ds.Tables["Alumnos"].Rows[0];

                //evaluando que la contraseña y usuario sean correctos
                if (txtbx_Cuenta.Text == DR["num_cuenta"].ToString())
                {
               
                    this.Hide();
                    //esto sirve para ocultar el formulario de login
                }

            }
            catch(Exception ex)
            {
                //en caso que la contraseña sea erronea mostrara un mensaje
                //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en ste caso OK, icono a mostrar en este caso uno de error
                MessageBox.Show("Error! El numero de cuento que ingreso no se encontro en la base de datos"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                SqlConnection miConexion = new SqlConnection("Data Source = SQL5018.Smarterasp.net; Initial Catalog = DB_A19EA8_alexhilsaca; User Id = DB_A19EA8_alexhilsaca_admin; Password = honduras2017; ");
                miConexion.Open();
                string SelectNombre = "Select nombre from Alumnos where num_cuenta='" + txtbx_Cuenta.Text + "'";
                SqlCommand comando = new SqlCommand(SelectNombre, miConexion);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read() == true)
                {
                    frm_Principal frm_princip = new frm_Principal();
                    //((frm_Principal)this.Owner).lbl_Bienv.Visible = false;
                    //((frm_Principal)this.Owner).lbl_Nomb.Visible = false;
                    frm_princip.lbl_Nomb.Visible = true;
                    frm_princip.lbl_Bienv.Visible = true;
                    frm_princip.lbl_Nomb.Text = leer["Nombre"].ToString();
                    frm_princip.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
             
        }
    }
}
