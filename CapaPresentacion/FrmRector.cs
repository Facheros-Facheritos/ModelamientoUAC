using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRector : Form
    {
        public FrmRector()
        {
            InitializeComponent();
        }

        private void FrmRector_Load(object sender, EventArgs e)
        {

        }
        Rector rector = new Rector();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer Datos
            string apellidos = textApellidos.Text.Trim();
            string nombres = textNombres.Text.Trim();
            string profesion = textProfesion.Text.Trim();
            string grado = textGrado.Text.Trim();
            string habilidades = textHabilidades.Text.Trim();
            string correo = textCorreo.Text.Trim();
            string celular = textCelular.Text.Trim();
            string inicioDocencia = textInicioDocencia.Text.Trim();
            //Escribir los datos del Alumno en el objeto
            rector.Apellidos = apellidos;
            rector.Nombres = nombres;
            rector.Profesion = profesion;
            rector.Grado = grado;
            rector.Habilidades = habilidades;
            rector.Correo = correo;
            rector.Celular = celular;
            rector.InicioDocencia = inicioDocencia;
            //confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            //Limpiar las cajas de texto
            textApellidos.Clear();
            textNombres.Clear();
            textProfesion.Clear();
            textGrado.Clear();
            textHabilidades.Clear();
            textCorreo.Clear();
            textCelular.Clear();
            textInicioDocencia.Clear();
            //Hacer que el mouse este en apellidos
            textApellidos.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las Propiedades del objeto
            string apellidos = rector.Apellidos;
            string nombres = rector.Nombres;
            string profesion = rector.Profesion;
            string grado = rector.Grado;
            string habilidades = rector.Habilidades;
            string correo = rector.Correo;
            string celular = rector.Celular;
            string inicioDocencia = rector.InicioDocencia;
            MessageBox.Show("Datos del Alumno" + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Nombres: " + nombres + "\n" + "Profesion: " + profesion + "\n" +
                            "Grado: " + grado + "\n" + "Habilidades: " + habilidades + "\n" +
                            "Correo: " + correo + "\n" + "Celular: " + celular + "\n" +
                            "InicioDocencia: " + inicioDocencia);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Dirigir());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Organizar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Representar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.ActualizarConocimientos());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.TomarDesiciones());
        }
    }
}
