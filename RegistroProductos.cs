using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_FP_G12.Clases;

namespace EF_FP_G12
{
    public partial class RegistroProductos : Form
    {
        public RegistroProductos()
        {
            InitializeComponent();
            //Generación de columna del datagridview
            dgvprod.AutoGenerateColumns = false;
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Código", DataPropertyName = "G12_codigo" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "G12_nombre" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "G12_categoria" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "G12_cantidad" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "G12_precio" });

            //Elimina el botón de cerrar, minimizar y maximizar.
            this.ControlBox = false;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo producto con los datos del formulario
                Productos nuevoProducto = new Productos()
                {
                    G12_codigo = txtcodigo.Text,
                    G12_nombre = txtnombre.Text,
                    G12_categoria = txtcategoria.Text,
                    G12_cantidad = Convert.ToInt32(txtcantidad.Text),
                    G12_precio = Convert.ToDouble(txtprecio.Text)
                };

                // Agregar el producto a la lista
                Productos.AgregarProducto(nuevoProducto);

                // Actualizar DataGridView
                ActualizarDataGridView();

                // Limpiar los campos de texto
                txtcodigo.Clear();
                txtnombre.Clear();
                txtcategoria.Clear();
                txtcantidad.Clear();
                txtprecio.Clear();

                // Enfocar el campo de código para ingresar un nuevo producto
                txtcodigo.Focus();

                MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult G12_cerrar = MessageBox.Show("¿Desea cancelar el registro del producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_cerrar == DialogResult.Yes)
            {
                this.Close(); // Cierra la ventana si el usuario confirma la acción
            }
        }

        private void ActualizarDataGridView()
        {
            dgvprod.DataSource = null; // Limpiar el DataGridView
            dgvprod.DataSource = Productos.ObtenerListaProductos(); // Asignar la lista actualizada
        }
        
    }
}
