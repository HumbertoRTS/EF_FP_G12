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
            //Productos.CargarLista();// Cargar la lista de productos al iniciar el formulario
            //Generación de columna del datagridview
            dgvprod.AutoGenerateColumns = false;
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Código", DataPropertyName = "G12_codigo" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "G12_nombre" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "G12_categoria" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "G12_cantidad" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "G12_precio" });

            //Elimina el botón de cerrar, minimizar y maximizar.
            this.ControlBox = false;
            // Actualizar DataGridView solo si se guarda en archivo
            //ActualizarDataGridView();           
        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {
            //Se agrega el método para que, cuando se vuelva abrir el formulario, se cargue la lista de productos.
            //Cuando se cierre totalmente el programa, ya no se mostrará los productos hasta que se vuelva a registrar nuevos productos.
            ActualizarDataGridView();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Enfocar el campo de código para ingresar un nuevo producto
                txtcodigo.Focus();

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    string.IsNullOrWhiteSpace(txtcategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtcantidad.Text) ||
                    string.IsNullOrWhiteSpace(txtprecio.Text))
                {
                    MessageBox.Show("Todos los campos deben estar rellenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que Cantidad sea un número mayor o igual a 0
                if (!int.TryParse(txtcantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Debe ingresar un número mayor o igual a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que Precio sea un número decimal mayor que 0
                if (!double.TryParse(txtprecio.Text, out double precio) || precio < 0)
                {
                    MessageBox.Show("Debe ingresar un número mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                MessageBox.Show("Producto registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de texto
                txtcodigo.Clear();
                txtnombre.Clear();
                txtcategoria.Clear();
                txtcantidad.Clear();
                txtprecio.Clear();

                // Actualizar DataGridView
                ActualizarDataGridView();
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



        private void btnstock_Click(object sender, EventArgs e)
        {
            List<Productos> G12_productosEnStock = Productos.ObtenerStock(); // Filtra productos con stock

            if (G12_productosEnStock.Count > 0)
            {
                StockProductos formStock = new StockProductos(G12_productosEnStock);
                formStock.Show(); // Abre el formulario de stock
            }
            else
            {
                MessageBox.Show("No hay productos en stock.", "Stock Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /* private void btnborrar_Click(object sender, EventArgs e)
         {
             /* try
              {                
                  if (dgvprod.SelectedRows.Count > 0)
                  {
                      string codigo = dgvprod.SelectedRows[0].Cells["G12_codigo"].Value.ToString();

                      // Confirmación antes de eliminar
                      DialogResult resultado = MessageBox.Show($"¿Seguro que desea eliminar el producto {codigo}?",
                                                               "Confirmar Eliminación",
                                                               MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Warning);

                      if (resultado == DialogResult.Yes)
                      {
                          Productos.EliminarProducto(codigo);
                          ActualizarDataGridView(); // Refresca el DataGridView
                      }
                  }
                  else
                  {
                      MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show($"Error en la eliminación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
        }*/
        
    }
}


