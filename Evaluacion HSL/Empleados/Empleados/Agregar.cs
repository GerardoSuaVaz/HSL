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
    public partial class Agregar : Form
    {
        NEmpleado nEmpleado = new NEmpleado();
        NPuesto nPuesto = new NPuesto();
        public Agregar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nomEmpleado = txtNombre.Text;
            string apEmpleado = txtApellido.Text;
            string curp = txtCurp.Text;
            string rfc = txtRfc.Text;
            DateTime fNacimiento = dtFNacimiento.Value;
            int puesto = Convert.ToInt32(cbPuesto.SelectedValue);
            
            Empleado empleado = new Empleado
            {
                Nombre = nomEmpleado,
                Apellido = apEmpleado,
                Curp = curp,
                Rfc = rfc,
                fechaNacimiento = fNacimiento,
                idPuesto = puesto
            };
            
            nEmpleado.Agregar(empleado);
            Form1 rForm1 = new Form1();
            //List<Empleado> empleados = new List<Empleado>();
            //empleados = nEmpleado.Consultar();
            rForm1.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 rForm1 = new Form1();
            //rForm1.Show();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            List<Puesto> lstPuesto = new List<Puesto>();
            lstPuesto = nPuesto.Consultar();
            cbPuesto.DataSource = lstPuesto;
            cbPuesto.DisplayMember = "nomPuesto";
            cbPuesto.ValueMember = "idPuesto";
        }
    }
}
