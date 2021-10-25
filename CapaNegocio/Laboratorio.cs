using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        // Declaracion de atributos
        private string ubicacion;
        private string tipo;
        private string numeroEstudiantes;
        private string nombre;
        private string dimensiones;
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string NumeroEstudiantes
        {
            get { return numeroEstudiantes; }
            set { numeroEstudiantes = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Dimensiones
        {
            get { return dimensiones; }
            set { dimensiones = value; }
        }

        // Declaracion de metodos u operaciones
        public string ObtenerDatos()
        {
            return "El metodo obtenerDatos recien será implementado";
        }
        public string Experimentar()
        {
            return "El metodo experimentar recien sera implementado";
        }
        public string ProporcionarMateriales()
        {
            return "El metodo proporcionarMateriales recien sera implementado";
        }
        public string AnalizarDatos()
        {
            return "El metodo analizarDatos recien sera implementado";
        }
        public string Investigar()
        {
            return "El metodo investigar recien sera implementado";
        }
    }
}
