using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        // Declaracion de atributos
        private string apellidos;
        private string nombres;
        private string celular;
        private string correo;
        private string fechaNacimiento;
        private string cargo;
        private string gradoAcademico;
        private string fechaIngresoDocencia;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string GradoAcademico
        {
            get { return gradoAcademico ; }
            set { gradoAcademico = value; }
        }
        public string FechaIngresoDocencia
        {
            get { return fechaIngresoDocencia; }
            set { fechaIngresoDocencia = value; }
        }

        // Declaracion de metodos u operaciones
        public string Ensenar()
        {
            return "El metodo ensenar recien será implementado";
        }
        public string Motivar()
        {
            return "El metodo motivar recien sera implementado";
        }
        public string Evaluar()
        {
            return "El metodo evaluar recien sera implementado";
        }
        public string Aconsejar()
        {
            return "El metodo aconsejar recien sera implementado";
        }
        public string SubirNotas()
        {
            return "El metodo SubirNotas recien sera implementado";
        }
    }
}