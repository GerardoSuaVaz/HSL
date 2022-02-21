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
    public partial class Eliminar : Form
    {
        NEmpleado nEmpleado = new NEmpleado();
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(lblidEmpleado.Text);
            nEmpleado.Eliminar(idEmpleado);
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
