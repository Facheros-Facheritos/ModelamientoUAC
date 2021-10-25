using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Llamar a la capa negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmDocente : Form
    {
        public FrmDocente()
        {
            InitializeComponent();
        }

        private void FrmDocente_Load(object sender, EventArgs e)
        {

        }

        // Declarar un objeto a partir de la clase
        Docente docente = new Docente();
        private void btnEscribir_Click_1(object sender, EventArgs e)
        {
            //Leer Datos
            string apellidos = textApellidos.Text.Trim();
            string nombres = textNombres.Text.Trim();
            string correo = textCorreo.Text.Trim();
            string celular = textCelular.Text.Trim();
            string fechaNacimiento = textFechaNacimiento.Text.Trim();
            string cargo = textCargo.Text.Trim();
            string gradoAcademico = textGradoAcademico.Text.Trim();
            string fechaIngresoDocencia = textFechaIngresoDocencia.Text.Trim();
            //Escribir los datos del Alumno en el objeto
            docente.Apellidos = apellidos;
            docente.Nombres = nombres;
            docente.Correo = correo;
            docente.Celular = celular;
            docente.FechaNacimiento = fechaNacimiento;
            docente.Cargo = cargo;
            docente.GradoAcademico = gradoAcademico;
            docente.FechaIngresoDocencia = fechaIngresoDocencia;
            //confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            //Limpiar las cajas de texto
            textApellidos.Clear();
            textNombres.Clear();
            textCorreo.Clear();
            textCelular.Clear();
            textFechaNacimiento.Clear();
            textCargo.Clear();
            textGradoAcademico.Clear();
            textFechaIngresoDocencia.Clear();
            //Hacer que el mouse este en apellidos
            textApellidos.Focus();
        }
        private void btnLeer_Click_1(object sender, EventArgs e)
        {
            //Leer las Propiedades del objeto
            string apellidos = docente.Apellidos;
            string nombres = docente.Nombres;
            string correo = docente.Correo;
            string celular = docente.Celular;
            string fechaNacimiento = docente.FechaNacimiento;
            string cargo = docente.Cargo;
            string gradoAcademico = docente.GradoAcademico;
            string fechaIngresoDocencia = docente.FechaIngresoDocencia;
            MessageBox.Show("Datos del Docente" + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Nombres: " + nombres + "\n" + "Correo: " + correo + "\n" +
                            "Celular: " + celular + "\n" + "FechaNacimiento: " + fechaNacimiento + "\n" +
                            "Cargo: " + cargo + "\n" + "GradoAcademico: " + gradoAcademico + "\n" +
                            "FechaIngresoDocencia: " + fechaIngresoDocencia);
        }

        private void btnMetodo1_Click_1(object sender, EventArgs e)
        {
            // Llamar al metodo
            MessageBox.Show(docente.Ensenar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Motivar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Evaluar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Aconsejar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.SubirNotas());
        }

        
    }
}
