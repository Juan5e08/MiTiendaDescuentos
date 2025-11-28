using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaDescuentos.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        // Método virtual — polimorfismo
        public virtual double CalcularPrecioConDescuento()
        {
            // Por defecto: descuento general del 5%
            return Precio * 0.95;
        }
    }
}