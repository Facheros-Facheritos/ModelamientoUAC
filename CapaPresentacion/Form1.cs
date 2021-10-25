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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Declarar un objeto a partir de la clase
        Alumno alumno = new Alumno();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer Datos
            string apellidos = textApellidos.Text.Trim();
            string nombres = textNombres.Text.Trim();
            string celular = textCelular.Text.Trim();
            string codigo = textCodigo.Text.Trim();
            string correo = textCorreo.Text.Trim();
            string semestreInicio = textSemestreInicio.Text.Trim();
            string escuelaProfesional = textEscuelaProfesional.Text.Trim();
            //Escribir los datos del Alumno en el objeto
            alumno.Apellidos = apellidos;
            alumno.Nombres = nombres;
            alumno.Celular = celular;
            alumno.Codigo = codigo;
            alumno.Correo = correo;
            alumno.SemestreInicio = semestreInicio;
            alumno.EscuelaProfesional = escuelaProfesional;
            //confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            //Limpiar las cajas de texto
            textApellidos.Clear();
            textNombres.Clear();
            textCelular.Clear();
            textCodigo.Clear();
            textCorreo.Clear();
            textSemestreInicio.Clear();
            textEscuelaProfesional.Clear();
            //Hacer que el mouse este en apellidos
            textApellidos.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las Propiedades del objeto
            string apellidos = alumno.Apellidos;
            string nombres = alumno.Nombres;
            string celular = alumno.Celular;
            string codigo = alumno.Codigo;
            string correo = alumno.Correo;
            string semestreInicio = alumno.SemestreInicio;
            string escuelaProfesional = alumno.EscuelaProfesional;
            MessageBox.Show("Datos del Alumno" + "\n" + "Apellidos: " + apellidos + "\n" + 
                            "Nombres: " + nombres + "\n" + "Celular: " + celular + "\n" +
                            "Codigo: " + codigo + "\n" + "Correo: " + correo + "\n" + 
                            "SemestreInicio: " + semestreInicio + "\n" + "EscuelaProfesional: " + escuelaProfesional);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // Llamar al metodo
            MessageBox.Show(alumno.Matricular());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Estudiar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Aprobar());
        }
        
        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Desaprobar());
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Atender());
        }

        private void btnRendirExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.RendirExamen());
        }

        private void btnTrabajarEquipo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.TrabajarEquipo());
        }

    }
}
