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
    public partial class FrmJefePractica : Form
    {
        public FrmJefePractica()
        {
            InitializeComponent();
        }

        private void FrmJefePractica_Load(object sender, EventArgs e)
        {

        }
        // Declarar un objeto a partir de la clase
        JefePractica jefePractica = new JefePractica();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer Datos
            string apellidos = textApellidos.Text.Trim();
            string nombres = textNombres.Text.Trim();
            string correo = textCorreo.Text.Trim();
            string cargo = textCargo.Text.Trim();
            string habilidadPedagogica = textHabilidadPedagogica.Text.Trim();
            //Escribir los datos del Alumno en el objeto
            jefePractica.Apellidos = apellidos;
            jefePractica.Nombres = nombres;
            jefePractica.Correo = correo;
            jefePractica.Cargo = cargo;
            jefePractica.HabilidadPedagogica = habilidadPedagogica;
            //confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            //Limpiar las cajas de texto
            textApellidos.Clear();
            textNombres.Clear();
            textCorreo.Clear();
            textCargo.Clear();
            textHabilidadPedagogica.Clear();
            //Hacer que el mouse este en apellidos
            textApellidos.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las Propiedades del objeto
            string apellidos = jefePractica.Apellidos;
            string nombres = jefePractica.Nombres;
            string correo = jefePractica.Correo;
            string cargo = jefePractica.Cargo;
            string habilidadPedagogica = jefePractica.HabilidadPedagogica;
            MessageBox.Show("Datos del Alumno" + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Nombres: " + nombres + "\n" + "Correo: " + correo + "\n" +
                            "Cargo: " + cargo + "\n" + "HabilidadPedagogica: " + habilidadPedagogica );
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Ensenar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Supervisar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Evaluar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.ReportarNotas());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Orientar());
        }
    }
}
