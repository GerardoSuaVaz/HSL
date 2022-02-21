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
    public partial class Form1 : Form
    {
        NEmpleado nEmpleado = new NEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados = nEmpleado.Consultar();
            dgvEmpleados.DataSource = empleados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Consultar cEmpleado = new Consultar();
            cEmpleado.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idEmpleado = (Int32)dgvEmpleados.SelectedCells[0].Value;
            Empleado empleado = nEmpleado.Consultar(idEmpleado);
            Eliminar eEmpleado = new Eliminar();
            eEmpleado.lblidEmpleado.Text = Convert.ToString(empleado.idEmpleado);
            eEmpleado.lblNombre.Text = empleado.Nombre;
            eEmpleado.lblApellido.Text = empleado.Apellido;
            eEmpleado.lblCurp.Text = empleado.Curp;
            eEmpleado.lblRfc.Text = empleado.Rfc;
            eEmpleado.lblFNacimiento.Text = Convert.ToString(empleado.fechaNacimiento);
            eEmpleado.lblPuesto.Text = Convert.ToString(empleado.idPuesto);
            eEmpleado.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar aEmpleado = new Agregar();
            aEmpleado.Show();
            //this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idEmpleado = (Int32)dgvEmpleados.SelectedCells[0].Value;
            Empleado empleado = nEmpleado.Consultar(idEmpleado);
            Consultar cEmpleado = new Consultar();
            cEmpleado.lblidEmpleado.Text = Convert.ToString(empleado.idEmpleado);
            cEmpleado.lblNombre.Text = empleado.Nombre;
            cEmpleado.lblApellido.Text = empleado.Apellido;
            cEmpleado.lblCurp.Text = empleado.Curp;
            cEmpleado.lblRfc.Text = empleado.Rfc;
            cEmpleado.lblFNacimiento.Text = Convert.ToString(empleado.fechaNacimiento);
            cEmpleado.lblPuesto.Text = Convert.ToString(empleado.idPuesto);
            cEmpleado.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idEmpleado = (Int32)dgvEmpleados.SelectedCells[0].Value;
            Empleado empleado = nEmpleado.Consultar(idEmpleado);
            Editar uEmpleado = new Editar();
            uEmpleado.lblidEmpleado.Text = Convert.ToString(empleado.idEmpleado);
            uEmpleado.txtNombre.Text = empleado.Nombre;
            uEmpleado.txtApellido.Text = empleado.Apellido;
            uEmpleado.txtCurp.Text = empleado.Curp;
            uEmpleado.txtRfc.Text = empleado.Rfc;
            uEmpleado.dtFNacimiento.Text = Convert.ToString(empleado.fechaNacimiento);
            uEmpleado.cbxPuesto.DisplayMember = Convert.ToString(empleado.idPuesto);
            uEmpleado.Show();
        }
    }
}
