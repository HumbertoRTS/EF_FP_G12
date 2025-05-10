using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EF_FP_G12.Clases
{
    public class Productos
    {
        public string G12_codigo { get; set; }
        public string G12_nombre { get; set; }
        public string G12_categoria { get; set; }
        public double G12_precio { get; set; }
        public int G12_cantidad { get; set; }

        public Productos()
        {
            this.G12_codigo = G12_codigo;
            this.G12_nombre = G12_nombre;
            this.G12_categoria = G12_categoria;
            this.G12_precio = G12_precio;
            this.G12_cantidad = G12_cantidad;
        }     

        // Lista de productos
        public static List<Productos> G12_listaProductos = new List<Productos>();

        // Método para agregar un producto a la lista
        public static void AgregarProducto(Productos producto)
        {
            G12_listaProductos.Add(producto);
            //GuardarLista(); // Guardar automáticamente
        }

        // Método para listar todos los productos
        public static List<Productos> ObtenerListaProductos()
        {
            return G12_listaProductos;
        }

        public static List<Productos> ObtenerStock()
        {
            List<Productos> G12_productosEnStock = new List<Productos>();

            // Recorre la lista y agrega productos con cantidad mayor a 0
            foreach (Productos producto in G12_listaProductos)
            {
                if (producto.G12_cantidad > 0)
                {
                    G12_productosEnStock.Add(producto);
                }
            }

            return G12_productosEnStock;
        }       

        /*private static string rutaArchivo = "productos.txt";    

        // Método para guardar la lista en Texto plano
        public static void GuardarLista()
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (var producto in G12_listaProductos)
                {
                    sw.WriteLine($"{producto.G12_codigo},{producto.G12_nombre},{producto.G12_categoria},{producto.G12_precio},{producto.G12_cantidad}");
                }
            }

        }*/

        // Método para cargar la lista desde JSON
        /*public static void CargarLista()
        {
            if (File.Exists(rutaArchivo))
            {
                G12_listaProductos.Clear();
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] G12_datos = linea.Split(',');
                        // Validar que la línea tenga el número correcto de columnas
                        if (G12_datos.Length < 5)
                        {
                            Console.WriteLine($"Línea inválida: {linea}");
                            continue; // Saltar a la siguiente línea
                        }

                        // Validar y convertir los valores numéricos
                        if (!int.TryParse(G12_datos[3], out int cantidad))
                        {
                            Console.WriteLine($"Cantidad inválida en la línea: {linea}");
                            continue;
                        }

                        if (!int.TryParse(G12_datos[4], out int precio))
                        {
                            Console.WriteLine($"Precio inválido en la línea: {linea}");
                            continue;
                        }

                        G12_listaProductos.Add(new Productos
                        {
                            G12_codigo = G12_datos[0],
                            G12_nombre = G12_datos[1],
                            G12_categoria = G12_datos[2],
                            G12_cantidad = int.Parse(G12_datos[3]), 
                            G12_precio = int.Parse(G12_datos[4])
                        });
                    }
                }
            }

        }*/

        /*public static void EliminarProducto(string codigo)
        {
            try
            {
                Productos productoAEliminar = null;

                // Buscar el producto manualmente en la lista
                foreach (Productos producto in G12_listaProductos)
                {
                    if (producto.G12_codigo == codigo)
                    {
                        productoAEliminar = producto;
                        break; // Salir del bucle cuando lo encuentre
                    }
                }

                // Si se encontró el producto, lo eliminamos
                if (productoAEliminar != null)
                {
                    G12_listaProductos.Remove(productoAEliminar);
                    GuardarLista(); // Guarda la lista actualizada en archivo
                    MessageBox.Show("Producto eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("El producto no existe en la lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/

    }
}
