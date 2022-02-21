using Entidades;
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
    public partial class Editar : Form
    {
        NEmpleado nEmpleado = new NEmpleado();
        NPuesto nPuesto = new NPuesto();
        
        public Editar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(lblidEmpleado.Text);
            string nomEmpleado = txtNombre.Text;
            string apEmpleado = txtApellido.Text;
            string curp = txtCurp.Text;
            string rfc = txtRfc.Text;
            DateTime fNacimiento = dtFNacimiento.Value;
            int puesto = Convert.ToInt32(cbxPuesto.SelectedValue);
            Empleado empleado = new Empleado
            {
                idEmpleado = idEmpleado,
                Nombre = nomEmpleado,
                Apellido = apEmpleado,
                Curp = curp,
                Rfc = rfc,
                fechaNacimiento = fNacimiento,
                idPuesto = puesto
            };
            nEmpleado.Actualizar(empleado);
            Form1 rForm1 = new Form1();
            rForm1.Show();
            this.Close();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            List<Puesto> lstPuesto = new List<Puesto>();
            lstPuesto = nPuesto.Consultar();
            cbxPuesto.DataSource = lstPuesto;
            cbxPuesto.DisplayMember = "nomPuesto";
            cbxPuesto.ValueMember = "idPuesto";
        }
    }
}
