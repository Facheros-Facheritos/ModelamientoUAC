using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del alumno
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del docennte
            FrmDocente frmDocente = new FrmDocente();
            frmDocente.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del laboratorio
            FrmLaboratorio frmLaboratorio = new FrmLaboratorio();
            frmLaboratorio.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del asignatura
            FrmAsignatura frmAsignatura = new FrmAsignatura();
            frmAsignatura.Show();
        }

        private void jefePracticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del jefePracticas
            FrmJefePractica frmJefePractica = new FrmJefePractica();
            frmJefePractica.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del notas
            FrmNotas frmNotas = new FrmNotas();
            frmNotas.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del rector
            FrmRector frmRector = new FrmRector();
            frmRector.Show();
        }

        private void pPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del PPP
            FrmPPP frmPPP = new FrmPPP();
            frmPPP.Show();
        }
    }
}
