using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiTiendaDescuentos.Models;


namespace MiTiendaDescuentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Validar nombre del producto
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del producto.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            // 2. Validar precio
            string textoPrecio = txtCosto.Text.Trim();
            if (string.IsNullOrEmpty(textoPrecio))
            {
                MessageBox.Show("Ingrese el precio del producto.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                return;
            }

            // Convertir precio
            if (!double.TryParse(textoPrecio, out double precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser numérico y mayor que cero.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCosto.Focus();
                return;
            }

            // 3. Obtener el tipo (tecnologia/alimento/general)
            string tipoTexto = txtTipo.Text.Trim().ToLower();

            // 4. Crear producto adecuado (polimorfismo)
            Producto producto;

            switch (tipoTexto)
            {
                case "tecnologia":
                case "tecnología":
                    producto = new Tecnologia(nombre, precio);
                    break;

                case "alimento":
                    producto = new Alimento(nombre, precio);
                    break;

                default:
                    producto = new Producto(nombre, precio); // GENERAL
                    break;
            }

            // 5. Calcular precio final
            double precioFinal = producto.CalcularPrecioConDescuento();

            // 6. Mostrar resultado en el TextBox final
            txtPrecioFinal.Text = precioFinal.ToString("C");

            // 7. Mostrar resumen
            MessageBox.Show(
                $"Producto: {producto.Nombre}\n" +
                $"Tipo: {tipoTexto}\n" +
                $"Precio original: {producto.Precio:C}\n" +
                $"Precio con descuento: {precioFinal:C}",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprecioFinal_Click(object sender, EventArgs e)
        {

        }
    }
}