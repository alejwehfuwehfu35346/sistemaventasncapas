﻿using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProductoVIstas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleingVistas
{
    public partial class DetalleingInterfaz : Form
    {
        public DetalleingInterfaz()
        {
            InitializeComponent();
        }
        public static int IdIngresoSeleccionado = 0;

        public static int IdProductoSeleccionado = 0;

        DetalleingBSS bss = new DetalleingBSS();
        IngresoBSS bssuser = new IngresoBSS();
        ProductoBSS bssuser2 = new ProductoBSS();
        private void DetalleingInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleingBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!int.TryParse(textBox3.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
            }
            else if (!decimal.TryParse(textBox4.Text, out decimal precioCosto))
            {
                MessageBox.Show("El precio de costo debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox5.Text, out decimal precioVenta))
            {
                MessageBox.Show("El precio de venta debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox6.Text, out decimal subTotal))
            {
                MessageBox.Show("El subtotal debe ser un valor numérico válido.");
            }
            else
            {
                Detalleing d = new Detalleing();
                d.IdIngreso = IdIngresoSeleccionado;
                d.IdProducto = IdProductoSeleccionado;
                d.FechaVenc = dateTimePicker1.Value;
                d.Cantidad = Convert.ToInt32(textBox3.Text);
                d.PrecioCosto = Convert.ToDecimal(textBox4.Text);
                d.PrecioVenta = Convert.ToDecimal(textBox5.Text);
                d.SubTotal = Convert.ToDecimal(textBox6.Text);

                bss.InsertarDetalleingBss(d);
                MessageBox.Show("Se guardo correctamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!int.TryParse(textBox3.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
            }
            else if (!decimal.TryParse(textBox4.Text, out decimal precioCosto))
            {
                MessageBox.Show("El precio de costo debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox5.Text, out decimal precioVenta))
            {
                MessageBox.Show("El precio de venta debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox6.Text, out decimal subTotal))
            {
                MessageBox.Show("El subtotal debe ser un valor numérico válido.");
            }
            else
            {
                int IdDetalleingSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Detalleing editarDetalleing = bss.ObtenerDetalleIngIdBss(IdDetalleingSeleccionada);
                editarDetalleing.IdIngreso = IdIngresoSeleccionado;
                editarDetalleing.IdProducto = IdProductoSeleccionado;
                editarDetalleing.FechaVenc = dateTimePicker1.Value;
                editarDetalleing.Cantidad = Convert.ToInt32(textBox3.Text);
                editarDetalleing.PrecioCosto = Convert.ToDecimal(textBox4.Text);
                editarDetalleing.PrecioVenta = Convert.ToDecimal(textBox5.Text);
                editarDetalleing.SubTotal = Convert.ToDecimal(textBox6.Text);
                bss.EditarDetalleIngBss(editarDetalleing);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarDetalleingBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdDetalleingSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que lo desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleIngBss(IdDetalleingSeleccionada);
                dataGridView1.DataSource = bss.ListarDetalleingBss();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IngresoSeleccionar fr = new IngresoSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso i = bssuser.ObtenerIngresoIdBss(IdIngresoSeleccionado);
                textBox1.Text = i.Estado;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductoSeleccionar fr = new ProductoSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto p = bssuser2.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = p.Descripcion;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            IngresoSeleccionar fr = new IngresoSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso i = bssuser.ObtenerIngresoIdBss(IdIngresoSeleccionado);
                textBox1.Text = i.Estado;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ProductoSeleccionar fr = new ProductoSeleccionar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto p = bssuser2.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = p.Descripcion;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!int.TryParse(textBox3.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
            }
            else if (!decimal.TryParse(textBox4.Text, out decimal precioCosto))
            {
                MessageBox.Show("El precio de costo debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox5.Text, out decimal precioVenta))
            {
                MessageBox.Show("El precio de venta debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox6.Text, out decimal subTotal))
            {
                MessageBox.Show("El subtotal debe ser un valor numérico válido.");
            }
            else
            {
                Detalleing d = new Detalleing();
                d.IdIngreso = IdIngresoSeleccionado;
                d.IdProducto = IdProductoSeleccionado;
                d.FechaVenc = dateTimePicker1.Value;
                d.Cantidad = Convert.ToInt32(textBox3.Text);
                d.PrecioCosto = Convert.ToDecimal(textBox4.Text);
                d.PrecioVenta = Convert.ToDecimal(textBox5.Text);
                d.SubTotal = Convert.ToDecimal(textBox6.Text);

                bss.InsertarDetalleingBss(d);
                MessageBox.Show("Se guardo correctamente");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!int.TryParse(textBox3.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
            }
            else if (!decimal.TryParse(textBox4.Text, out decimal precioCosto))
            {
                MessageBox.Show("El precio de costo debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox5.Text, out decimal precioVenta))
            {
                MessageBox.Show("El precio de venta debe ser un valor numérico válido.");
            }
            else if (!decimal.TryParse(textBox6.Text, out decimal subTotal))
            {
                MessageBox.Show("El subtotal debe ser un valor numérico válido.");
            }
            else
            {
                int IdDetalleingSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Detalleing editarDetalleing = bss.ObtenerDetalleIngIdBss(IdDetalleingSeleccionada);
                editarDetalleing.IdIngreso = IdIngresoSeleccionado;
                editarDetalleing.IdProducto = IdProductoSeleccionado;
                editarDetalleing.FechaVenc = dateTimePicker1.Value;
                editarDetalleing.Cantidad = Convert.ToInt32(textBox3.Text);
                editarDetalleing.PrecioCosto = Convert.ToDecimal(textBox4.Text);
                editarDetalleing.PrecioVenta = Convert.ToDecimal(textBox5.Text);
                editarDetalleing.SubTotal = Convert.ToDecimal(textBox6.Text);
                bss.EditarDetalleIngBss(editarDetalleing);
                MessageBox.Show("Datos Actualizados");


                dataGridView1.DataSource = bss.ListarDetalleingBss();
            }
        }
    }
}
