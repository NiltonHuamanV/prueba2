using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;

namespace lab2_ej4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            negocio cn = new negocio();

            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = cn.ConsultaProveedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            negocio cn = new negocio();
            cn.InsertarProveedor(txtCódigoProveedor.Text, txtRazonproveedor.Text, txtDireccionProveedor.Text, txtTelefonoProveedor.Text);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = cn.ConsultaProveedor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            negocio cn = new negocio();
            cn.ActualizarProveedor(txtCódigoProveedor.Text, txtRazonproveedor.Text, txtDireccionProveedor.Text, txtTelefonoProveedor.Text);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = cn.ConsultaProveedor();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            negocio cn = new negocio();
            cn.EliminarProveedor(TxtCodigoProveedor2.Text);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = cn.ConsultaProveedor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            negocio cn = new negocio();
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = cn.FiltroConsulta(txtfiltrar.Text);
        }
    }
}
