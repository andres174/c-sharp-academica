using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocioLogroC;

namespace PresentacionLogroC
{
    public partial class Alumno : Form
    {
        CatalogoAlumno cAlumno = new CatalogoAlumno();
        LogicaNegocioLogroC.Alumno _alumno = null;

        public Alumno()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtApellidos.Clear();
            txtDNI.Clear();
            txtNombre.Clear();
            txtSexo.Clear();
            
        }

        public void ingresar_alumno()
        {
            cAlumno.ingresar_alumno(new LogicaNegocioLogroC.Alumno(txtDNI.Text, txtApellidos.Text,  txtNombre.Text, txtSexo.Text, dtpFechaNaci.Value.Date));
            
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar_alumno();
            limpiar();
        }

        public void mostrar_alumno()
        {
            dgvAlumno.DataSource = null;
            dgvAlumno.DataSource = cAlumno.obtenerAlumno();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar_alumno();
        }

        public void eliminar_alumno()
        {
            cAlumno.eliminar_alumno(_alumno);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar_alumno();
        }
         public void buscar()
        {
            _alumno = cAlumno.obtener_alumno(txtDNI.Text);
            txtNombre.Text = _alumno.Nombre;
            txtApellidos.Text = _alumno.Apellido;
            txtSexo.Text = _alumno.Sexo;
            dtpFechaNaci.Value = _alumno.FechaNacimiento;
        }
        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            buscar();
        }

        public void modificar()
        {
            _alumno.DNI = txtDNI.Text;
            _alumno.Nombre  = txtNombre.Text;
            _alumno.Apellido = txtApellidos.Text;
            _alumno.Sexo = txtSexo.Text;
            _alumno.FechaNacimiento = dtpFechaNaci.Value;
            cAlumno.modificar_alumno(_alumno);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }
    }
}
