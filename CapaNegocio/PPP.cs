using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        // Declaracion de atributos
        private string empresa;
        private string ubicacion;
        private string horario;
        private string requisitos;
        private string salario;
        private string ocupacion;
        // Propiedades para los atributos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Requisitos
        {
            get { return requisitos; }
            set { requisitos = value; }
        }
        public string Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public string Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }
        // Declaracion de metodos u operaciones
        public string FormarLaboralmente()
        {
            return "El metodo FormarLaboralmente recien será implementado";
        }
        public string BrindarExperiencia()
        {
            return "El metodo BrindarExperiencia recien sera implementado";
        }
        public string Remunerar()
        {
            return "El metodo remunerar recien sera implementado";
        }
        public string Ensenar()
        {
            return "El metodo ensenar recien sera implementado";
        }
        public string ConocerColegas()
        {
            return "El metodo ConocerColegas recien sera implementado";
        }
    }
}
