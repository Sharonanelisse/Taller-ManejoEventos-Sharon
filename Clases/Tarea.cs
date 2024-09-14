using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAgo17.Clases
{
    internal class Tarea
    {
        public string nombre { get; set; }
        public readonly DateTime fecha;
        public string? estado { get; set; }

        public Tarea(string nombre, DateTime fecha, string? estado)
        {
            this.nombre = nombre;
            this.fecha = DateTime.Now;
            this.estado = estado;
        }

    }
}