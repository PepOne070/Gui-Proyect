using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Helados
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmLista_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form menuDD = new frmDescuentos();
            menuDD.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cc = new frmClientes();
            cc.Show();

        }

        private void proveedores_Click(object sender, EventArgs e)
        {
            Form p = new frmProveedores();
            p.Show();

        }

        private void productos_Click(object sender, EventArgs e)
        {
            Form pr = new frmProductos();
            pr.Show();

        }

        private void ventas_Click(object sender, EventArgs e)
        {
            Form v = new frmVentas();
            v.Show();

        }

        private void compras_Click(object sender, EventArgs e)
        {
            Form c = new frmCompras();
            c.Show();

        }

        private void descuento_Click(object sender, EventArgs e)
        {
            Form d = new frmDescuentos();
            d.Show();

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form menuclientes = new frmClientes();
            menuclientes.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form menuP = new frmProveedores();
            menuP.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form menuPro = new frmProductos();
            menuPro.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form menuV = new frmVentas();
            menuV.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form menuC = new frmCompras();
            menuC.Show();

        }
    }
}
