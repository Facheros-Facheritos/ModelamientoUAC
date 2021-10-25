using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        // Declaracion de atributos
        private string apellidos;
        private string nombres;
        private string profesion;
        private string grado;
        private string habilidades;
        private string correo;
        private string celular;
        private string inicioDocencia;
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
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public string Grado
        {
            get { return grado; }
            set { grado = value; }
        }
        public string Habilidades
        {
            get { return habilidades; }
            set { habilidades = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string InicioDocencia
        {
            get { return inicioDocencia; }
            set { inicioDocencia = value; }
        }
        // Declaracion de metodos u operaciones
        public string Dirigir()
        {
            return "El metodo dirigir recien será implementado";
        }
        public string Organizar()
        {
            return "El metodo organizar recien sera implementado";
        }
        public string Representar()
        {
            return "El metodo representar recien sera implementado";
        }
        public string ActualizarConocimientos()
        {
            return "El metodo ActualizarConocimientos recien sera implementado";
        }
        public string TomarDesiciones()
        {
            return "El metodo TomarDesiciones recien sera implementado";
        }
    }
}