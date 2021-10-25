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
    public partial class FrmPPP : Form
    {
        public FrmPPP()
        {
            InitializeComponent();
        }

        private void FrmPPP_Load(object sender, EventArgs e)
        {

        }
        PPP pPP = new PPP();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer Datos
            string empresa = textEmpresa.Text.Trim();
            string ubicacion = textUbicacion.Text.Trim();
            string horario = textHorario.Text.Trim();
            string requisitos = textRequisitos.Text.Trim();
            string salario = textSalario.Text.Trim();
            string ocupacion = textOcupacion.Text.Trim();
            //Escribir los datos del Alumno en el objeto
            pPP.Empresa = empresa;
            pPP.Ubicacion = ubicacion;
            pPP.Horario = horario;
            pPP.Requisitos = requisitos;
            pPP.Salario = salario;
            pPP.Ocupacion = ocupacion;
            //confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            //Limpiar las cajas de texto
            textEmpresa.Clear();
            textUbicacion.Clear();
            textHorario.Clear();
            textRequisitos.Clear();
            textSalario.Clear();
            textOcupacion.Clear();
            //Hacer que el mouse este en apellidos
            textEmpresa.Focus();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las Propiedades del objeto
            string empresa = pPP.Empresa;
            string ubicacion = pPP.Ubicacion;
            string horario = pPP.Horario;
            string requisitos = pPP.Requisitos;
            string salario = pPP.Salario;
            string ocupacion = pPP.Ocupacion;
            MessageBox.Show("Datos del Alumno" + "\n" + "Empresa: " + empresa + "\n" +
                            "Ubicacion: " + ubicacion + "\n" + "Horario: " + horario + "\n" +
                            "Requisitos: " + requisitos + "\n" + "Salario: " + salario + 
                            "\n" + "Ocupacion: " + ocupacion);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pPP.FormarLaboralmente());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pPP.BrindarExperiencia());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pPP.Remunerar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pPP.Ensenar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pPP.ConocerColegas());
        }
    }
}
