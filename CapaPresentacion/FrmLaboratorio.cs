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
    public partial class FrmLaboratorio : Form
    {
        public FrmLaboratorio()
        {
            InitializeComponent();
        }

        private void FrmLaboratorio_Load(object sender, EventArgs e)
        {

        }

        // Declarar un objeto a partir de la clase
        Laboratorio laboratorio = new Laboratorio();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer Datos
            string ubicacion = textUbicacion.Text.Trim();
            string tipo = textTipo.Text.Trim();
            string numeroEstudiantes = textNumeroEstudiantes.Text.Trim();
            string nombre = textNombre.Text.Trim();
            string dimensiones = textDimensiones.Text.Trim();
            //Escribir los datos del Alumno en el objeto
            laboratorio.Ubicacion = ubicacion;
            laboratorio.Tipo = tipo;
            laboratorio.NumeroEstudiantes = numeroEstudiantes;
            laboratorio.Nombre = nombre;
            laboratorio.Dimensiones = dimensiones;
            //confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            //Limpiar las cajas de texto
            textUbicacion.Clear();
            textTipo.Clear();
            textNumeroEstudiantes.Clear();
            textNombre.Clear();
            textDimensiones.Clear();
            //Hacer que el mouse este en apellidos
            textUbicacion.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las Propiedades del objeto
            string ubicacion = laboratorio.Ubicacion;
            string tipo = laboratorio.Tipo;
            string numeroEstudiantes = laboratorio.NumeroEstudiantes;
            string nombre = laboratorio.Nombre;
            string dimensiones = laboratorio.Dimensiones;
            MessageBox.Show("Datos del Laboratorio" + "\n" + "Ubicacion: " + ubicacion + "\n" +
                            "Tipo: " + tipo + "\n" + "NumeroEstudiantes: " + numeroEstudiantes + "\n" +
                            "Nombre: " + nombre + "\n" + "Dimensiones: " + dimensiones);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // Llamar al metodo
            MessageBox.Show(laboratorio.ObtenerDatos());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Experimentar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.ProporcionarMateriales());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.AnalizarDatos());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Investigar());
        }
    }
}
