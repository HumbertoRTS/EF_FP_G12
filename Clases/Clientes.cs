using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Para usar Interaction.InputBox

namespace EF_FP_G12.Clases
{
    public class Clientes
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int dni { get; set; }
        public int celular { get; set; }

        public Clientes(string nombres, string apellidos, int dni, int celular)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dni = dni;
            this.celular = celular;
        }    

    }
}
