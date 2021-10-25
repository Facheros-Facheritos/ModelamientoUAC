using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        // Declaracion de atributos
        private string apellidos;
        private string nombres;
        private string correo;
        private string cargo;
        private string habilidadPedagogica;
        // Propiedades para los atributos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
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
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string HabilidadPedagogica
        {
            get { return habilidadPedagogica; }
            set { habilidadPedagogica = value; }
        }
        
        // Declaracion de metodos u operaciones
        public string Ensenar()
        {
            return "El metodo ensenar recien será implementado";
        }
        public string Supervisar()
        {
            return "El metodo supervisar recien sera implementado";
        }
        public string Evaluar()
        {
            return "El metodo evaluar recien sera implementado";
        }
        public string ReportarNotas()
        {
            return "El metodo reportarNotas recien sera implementado";
        }
        public string Orientar()
        {
            return "El metodo orientar recien sera implementado";
        }
    }
}