using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Consultar : Form
    {
        NEmpleado dEmpleado = new NEmpleado();
        public Consultar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
          
        }
    }
}
