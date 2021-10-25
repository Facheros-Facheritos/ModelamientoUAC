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
    public partial class FrmAsignatura : Form
    {
        public FrmAsignatura()
        {
            InitializeComponent();
        }

        private void FrmAsignatura_Load(object sender, EventArgs e)
        {

        }

        //Declarar un objeto a partir de la clase
        Asignatura asignatura = new Asignatura();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer Datos
            string codigo = textCodigo.Text.Trim();
            string docenteEncargado = textDocenteEncargado.Text.Trim();
            string materiales = textMateriales.Text.Trim();
            string silabo = textSilabo.Text.Trim();
            string horario = textHorario.Text.Trim();
            string nombre = textNombre.Text.Trim();
            string preRequisitos = textPreRequisitos.Text.Trim();
            string numeroCreditos = textNumeroCreditos.Text.Trim();
            //Escribir los datos del Alumno en el objeto
            asignatura.Codigo = codigo;
            asignatura.DocenteEncargado = docenteEncargado;
            asignatura.Materiales = materiales;
            asignatura.Silabo = silabo;
            asignatura.Horario = horario;
            asignatura.Nombre = nombre;
            asignatura.PreRequisitos = preRequisitos;
            asignatura.NumeroCreditos = numeroCreditos;
            //confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            //Limpiar las cajas de texto
            textCodigo.Clear();
            textDocenteEncargado.Clear();
            textMateriales.Clear();
            textSilabo.Clear();
            textHorario.Clear();
            textNombre.Clear();
            textPreRequisitos.Clear();
            textNumeroCreditos.Clear();
            //Hacer que el mouse este en apellidos
            textCodigo.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las Propiedades del objeto
            string codigo = asignatura.Codigo;
            string docenteEncargado = asignatura.DocenteEncargado;
            string materiales = asignatura.Materiales;
            string silabo = asignatura.Codigo;
            string horario = asignatura.Horario;
            string nombre = asignatura.Nombre;
            string preRequisitos = asignatura.PreRequisitos;
            string numeroCreditos = asignatura.NumeroCreditos;
            MessageBox.Show("Datos de la Asignatura" + "\n" + "Codigo: " + codigo + "\n" +
                            "DocenteEncargado: " + docenteEncargado + "\n" + "Materiales: " + materiales + 
                            "\n" + "Silabo: " + silabo + "\n" + "Horario: " + horario + "\n" +
                            "Nombre: " + nombre + "\n" + "PreRequisitos: " + 
                            preRequisitos + "\n" + "NumeroCreditos: " + numeroCreditos);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Informar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Motivar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Formar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Orientar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Actualizar());
        }
    }
}
