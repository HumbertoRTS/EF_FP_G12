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
    public partial class StockProductos : Form
    {
        /*Se agrega la lista de productos en stock como parámetro para que pueda ser utilizada
        en este formulario desde el formulario RegistroProductos.*/
        //La lista esta viniendo del formulario RegistroProductos.
        public StockProductos(List<Productos> G12_productosEnStock)
        {
            InitializeComponent();
            // Elimina el botón de cerrar, minimizar y maximizar.
            this.ControlBox = false;
            // Generación de columna del datagridview
            dgvstock.AutoGenerateColumns = false;
            dgvstock.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Código", DataPropertyName = "G12_codigo" });
            dgvstock.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "G12_nombre" });
            dgvstock.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "G12_categoria" });
            dgvstock.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "G12_cantidad" });
            dgvstock.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "G12_precio" });

            // Asignar la lista de productos en stock al DataGridView
            dgvstock.DataSource = G12_productosEnStock;           
            
        }

        private void StockProductos_Load(object sender, EventArgs e)
        {
            // Cargar la lista de productos al iniciar el formulario
            List<Productos> G12_listaProductos = Productos.ObtenerStock();
            dgvstock.DataSource = G12_listaProductos;
            dgvstock.DataSource = Productos.ObtenerStock();

        }

        // Método para buscar productos
        private void txtstockcat_TextChanged(object sender, EventArgs e)
        {
            FiltrarStock(txtbuscar.Text);
        }

        // Método para filtrar productos en stock
        private void FiltrarStock(string criterio)
        {
            try
            {
                List<Productos> G12_productosFiltrados = new List<Productos>();

                // Recorrer la lista y aplicar el filtro manualmente
                foreach (Productos G12_producto in Productos.ObtenerStock())
                {
                    if (G12_producto.G12_nombre.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        G12_productosFiltrados.Add(G12_producto);
                    }
                }

                // Verificar si hay productos filtrados
                if (G12_productosFiltrados.Count > 0)
                {
                    dgvstock.DataSource = null;
                    dgvstock.DataSource = G12_productosFiltrados;
                    dgvstock.Refresh();
                }

                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese nombre.", "Producto No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvstock.DataSource = Productos.ObtenerStock(); // Restaurar lista completa
                    txtbuscar.Clear();
                    txtbuscar.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalirstock_Click(object sender, EventArgs e)
        {
            DialogResult G12_cerrar = MessageBox.Show("¿Desea salir de la interfaz?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_cerrar == DialogResult.Yes)
            {
                this.Close(); // Cierra la ventana si el usuario confirma la acción
            }
        }       
    }
}
