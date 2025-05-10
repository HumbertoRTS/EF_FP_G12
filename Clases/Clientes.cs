using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static EF_FP_G12.RegistroClientes; // Para usar Interaction.InputBox

namespace EF_FP_G12.Clases
{
    public class Clientes
    {
        public string G12_nombres { get; set; }
        public string G12_apellidos { get; set; }
        public int G12_dni { get; set; }
        public int G12_celular { get; set; }

        public Clientes()
        {
            this.G12_nombres = G12_nombres;
            this.G12_apellidos = G12_apellidos;
            this.G12_dni = G12_dni;
            this.G12_celular = G12_celular;
        }

        // Lista estática para almacenar los clientes
        public static List<Clientes> G12_ListaClientes = new List<Clientes>();

        public static void AgregarCliente(Clientes nuevoCliente)
        {
            G12_ListaClientes.Add(nuevoCliente);            
        }

        public static List<Clientes> ObtenerListaClientes()
        {
            return G12_ListaClientes;
        }

        public bool ValidarDNIRecursivo(TextBox txtdni)
        {
            string dniTexto = txtdni.Text.Trim();

            if (dniTexto.Length == 8 && int.TryParse(dniTexto, out int nuevoDNI))
            {
                G12_dni = nuevoDNI;
                return true; // Validación exitosa
            }
            else
            {
                MessageBox.Show("El DNI debe tener exactamente 8 números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                G12_dni = Validaciones.SolicitarNuevoDNI(txtdni);

                // Si el usuario ingresó `0`, detenemos la recursión y esperamos su corrección manual
                if (G12_dni == 0)
                {
                    return false; // Detener aquí y esperar nueva entrada antes de repetir la validación
                }
                else
                {
                    return ValidarDNIRecursivo(txtdni); // Llamada recursiva si aún es incorrecto
                }
            }
        }

        public bool ValidarCelularRecursivo(TextBox txtCelular)
        {
            string celularTexto = txtCelular.Text.Trim();

            if (celularTexto.Length == 9 && int.TryParse(celularTexto, out int nuevoCelular))
            {
                G12_celular = nuevoCelular;
                return true; // Validación exitosa
            }
            else
            {
                MessageBox.Show("El número de celular debe tener exactamente 9 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                G12_celular = Validaciones.SolicitarNuevoCelular(txtCelular);

                // Si el usuario ingresó `0`, detenemos la recursión y esperamos su corrección manual
                if (G12_celular == 0)
                {
                    return false; // Detener aquí y esperar nueva entrada antes de repetir la validación
                }
                else
                {
                    return ValidarCelularRecursivo(txtCelular); // Llamada recursiva si sigue siendo incorrecto
                }
            }
        }

        /*public static void ModificarCliente(Clientes clienteAModificar, string nuevoNombre, string nuevoApellido, int nuevoDNI, int nuevoCelular)
        {
            if (G12_ListaClientes.Contains(clienteAModificar))
            {
                clienteAModificar.nombres = nuevoNombre;
                clienteAModificar.apellidos = nuevoApellido;
                clienteAModificar.dni = nuevoDNI;
                clienteAModificar.celular = nuevoCelular;
                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        /*public static void EliminarCliente(Clientes clienteAEliminar)
        {
            if (G12_ListaClientes.Contains(clienteAEliminar))
            {
                G12_ListaClientes.Remove(clienteAEliminar);
                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

    }
}
