using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    public partial class frmVentas : Form
    {
        Conexion cn = new Conexion();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgProductos.Columns.Add("codigo_producto", "Codigo");
            dgProductos.Columns.Add("cantidad_producto", "Cantidad");
            dgProductos.Columns.Add("costo_ventadet", "Costo");
            dgProductos.Columns.Add("precio_ventadet", "Precio");
            dgProductos.Columns.Add("codigo_bodega", "Bodega");

        }

        public void llenarGrid()
        {
            string cadena = "";/*INSERT INTO" +
                " empleado (id_empleado, cui_empleado, nit_empleado, nombre_empleado, apellido_empleado," +
                " genero_empleado, edad_empleado, telefono_empleado, direccion_empleado, email_empleado," +
                " status_empleado, id_puesto, colegiado_empleado, id_sede) VALUES (" +
                "'" + txtIdEmpleado.Text + "', '"
                 + txtCui.Text + "', '"
                 + txtNit.Text + "', '"
                 + txtNombre.Text + "', '"
                 + txtApellido.Text + "', '"
                 + txtGenero.Text + "', "
                 + int.Parse(txtEdad.Text) + " , '"
                 + txtTelefono.Text + "', '"
                 + txtDireccion.Text + "', '"
                 + txtEmail.Text + "', '"
                 + txtStatus.Text + "', '"
                 + lblIdPuesto.Content + "', '"
                 + txtColegiado.Text + "', '"
                 + lblIdSede.Content + "' ); ";*/

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            MessageBox.Show("Inserción realizada");
        }
    }
}
