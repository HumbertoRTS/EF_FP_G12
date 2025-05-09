using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        // Método para listar todos los productos
        public static List<Productos> ObtenerListaProductos()
        {
            return G12_listaProductos;
        }

    }
}
