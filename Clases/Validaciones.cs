using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_FP_G12.Clases
{
    public class Validaciones
    {
        
        public static int SolicitarNuevoDNI(TextBox txtdni)
        {
            int G12_nuevoDNI = 0;

            while (true) // Se repite hasta que el usuario ingrese un número válido
            {
                string nuevoDNITexto = txtdni.Text.Trim(); // Obtener el nuevo valor ingresado

                if (int.TryParse(nuevoDNITexto, out G12_nuevoDNI) && nuevoDNITexto.Length == 8)
                {
                    return G12_nuevoDNI; // Si es válido, salir del bucle y retornar el DNI correcto
                }
                else
                {
                    MessageBox.Show("Ingrese un DNI de 8 dígitos válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdni.Clear();
                    txtdni.Focus();

                    return 0; // Retornar `0` para que el usuario ingrese un nuevo valor antes de volver a ejecutar la validación
                }
            }
        }

        public static int SolicitarNuevoCelular(TextBox txtCelular)
        {
            int G12_nuevoCelular = 0;

            while (true) // Se repite hasta que el usuario ingrese un número válido
            {
                string nuevoCelularTexto = txtCelular.Text.Trim(); // Obtener el nuevo valor ingresado

                if (int.TryParse(nuevoCelularTexto, out G12_nuevoCelular) && nuevoCelularTexto.Length == 9)
                {
                    return G12_nuevoCelular; // Si es válido, salir del bucle y retornar el celular correcto
                }
                else
                {
                    MessageBox.Show("Ingrese un número de celular de 9 dígitos válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Clear();
                    txtCelular.Focus();

                    return 0; // Retornar `0` para que el usuario ingrese un nuevo valor antes de volver a ejecutar la validación
                }
            }
        }
    }
}
