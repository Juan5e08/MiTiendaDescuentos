using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaDescuentos.Models
{
    public class Tecnologia : Producto
    {
        public Tecnologia(string nombre, double precio)
            : base(nombre, precio)
        {
        }

        public override double CalcularPrecioConDescuento()
        {
            return Precio * 0.90; // 10% descuento
        }
    }
}