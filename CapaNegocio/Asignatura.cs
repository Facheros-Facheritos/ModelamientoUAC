using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        // Declaracion de atributos
        private string codigo;
        private string docenteEncargado;
        private string materiales;
        private string silabo;
        private string horario;
        private string nombre;
        private string preRequisitos;
        private string numeroCreditos;
        // Propiedades para los atributos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string DocenteEncargado
        {
            get { return docenteEncargado; }
            set { docenteEncargado = value; }
        }
        public string Materiales
        {
            get { return materiales; }
            set { materiales = value; }
        }
        public string Silabo
        {
            get { return silabo; }
            set { silabo = value; }
        }
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string PreRequisitos
        {
            get { return preRequisitos; }
            set { preRequisitos = value; }
        }
        public string NumeroCreditos
        {
            get { return numeroCreditos; }
            set { numeroCreditos = value; }
        }
        // Declaracion de metodos u operaciones
        public string Informar()
        {
            return "El metodo Informar recien será implementado";
        }
        public string Motivar()
        {
            return "El metodo Motivar recien sera implementado";
        }
        public string Formar()
        {
            return "El metodo formar recien sera implementado";
        }
        public string Orientar()
        {
            return "El metodo Orientar recien sera implementado";
        }
        public string Actualizar()
        {
            return "El metodo actualizar recien sera implementado";
        }
    }
}