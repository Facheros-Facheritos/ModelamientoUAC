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
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {

        }
        // Declarar un objeto a partir de la clase
        Notas notas = new Notas();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer Datos
            string cursoEvaluado = textCursoEvaluado.Text.Trim();
            string maximaCalificacion = textMaximaCalificacion.Text.Trim();
            string tipo = textTipo.Text.Trim();
            string aprobado = textAprobado.Text.Trim();
            string desaprobado = textDesaprobado.Text.Trim();
            //Escribir los datos del Alumno en el objeto
            notas.CursoEvaluado = cursoEvaluado;
            notas.MaximaCalificacion = maximaCalificacion;
            notas.Tipo = tipo;
            notas.Aprobado = aprobado;
            notas.Desaprobado = desaprobado;
            //confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            //Limpiar las cajas de texto
            textCursoEvaluado.Clear();
            textMaximaCalificacion.Clear();
            textTipo.Clear();
            textAprobado.Clear();
            textDesaprobado.Clear();
            //Hacer que el mouse este en apellidos
            textCursoEvaluado.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las Propiedades del objeto
            string cursoEvaluado = notas.CursoEvaluado;
            string maximaCalificacion = notas.MaximaCalificacion;
            string tipo = notas.Tipo;
            string aprobado = notas.Aprobado;
            string desaprobado = notas.Desaprobado;
            MessageBox.Show("Datos de la Nota" + "\n" + "CursoEvaluado: " + cursoEvaluado + "\n" +
                            "MaximaCalificacion: " + maximaCalificacion + "\n" + "Tipo: " + tipo + "\n" +
                            "Aprobado: " + aprobado + "\n" + "Desaprobado: " + desaprobado);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.DescribirProgreso());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Motivar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Desmotivar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.InformarDocentes());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.DeterminarAprobacion());
        }
    }
}
