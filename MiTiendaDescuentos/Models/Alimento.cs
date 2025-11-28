using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaDescuentos.Models
{
    public class Alimento : Producto
    {
        public Alimento(string nombre, double precio)
            : base(nombre, precio)
        {
        }

        public override double CalcularPrecioConDescuento()
        {
            return Precio * 0.98; // 2% descuento
        }
    }
}