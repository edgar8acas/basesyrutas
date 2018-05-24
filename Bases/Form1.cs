using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bases
{
    public partial class Form1 : Form
    {
        CrudBases bases = new CrudBases();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bases.AgregarFinal(new Base(txtNombre.Text, Convert.ToInt32(txtTiempo.Text)));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtResult.Text = bases.Buscar(txtNombre.Text).ToString();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtResult.Text = bases.Listar();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            bases.EliminarUltimo();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            bases.EliminarInicio();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            bases.Insertar(new Base(txtNombre.Text, Convert.ToInt32(txtTiempo.Text)), Convert.ToInt32(txtPos.Text));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bases.Eliminar(txtNombre.Text);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {

        }
    }
}
