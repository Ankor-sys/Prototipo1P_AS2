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

namespace Prototipo1p
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
            dgProductos.Columns.Add("cantidad_ventadet", "Cantidad");
            dgProductos.Columns.Add("costo_ventadet", "Costo");
            dgProductos.Columns.Add("precio_ventadet", "Precio");
            dgProductos.Columns.Add("codigo_bodega", "Bodega");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgProductos.Rows.Add(txtCodigoProducto.Text, txtCantidad.Text, txtCosto.Text, txtPrecio.Text, txtCodigoBodega.Text);

            string cadena = "INSERT INTO" +
       " ventas_detalle VALUES (" +
       "'" + txtDocumento.Text + "', '"
        + txtCodigoProducto.Text + "', '"
        + txtCantidad.Text + "', '"
        + txtCosto.Text + "', '"
        + txtPrecio.Text + "', '"
        + txtCodigoBodega.Text + "' ); ";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            MessageBox.Show("Inserción detalle realizada");

            txtCodigoProducto.Text = "";
            txtCantidad.Text = "";
            txtCosto.Text = "";
            txtPrecio.Text = "";
            txtCodigoBodega.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            txtDocumento.Text = "";
            txtDocumentoCliente.Text = "";
            txtFecha.Text = "";
            txtStatus.Text = "";

            //Actualizar el encabezado con el nuevo total
            string cadena = "UPDATE " +
                " ventas_encabezado SET  total_ventaenca ='" +
                " " + float.Parse(txtTotal.Text) + "' WHERE documento_ventaenca = '"
                 + txtDocumento.Text + "' ); ";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            MessageBox.Show("Actualización encabezado realizado");
        }

        private void btnCompletarEncabezado_Click(object sender, EventArgs e)
        {
            txtDocumento.Enabled = false;
            txtDocumentoCliente.Enabled = false;
            txtFecha.Enabled = false;
            txtStatus.Enabled = false;

            string cadena = "INSERT INTO" +
                " ventas_encabezado VALUES (" +
                "'" + txtDocumento.Text + "', '"
                 + txtDocumentoCliente.Text + "', '"
                 + txtFecha.Text + "', "
                 + 0.0 + ", '"
                 + txtStatus.Text + "' ); ";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            MessageBox.Show("Inserción encabezado realizado");
        }
    }
}
