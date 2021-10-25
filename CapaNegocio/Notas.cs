using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        // Declaracion de atributos
        private string cursoEvaluado;
        private string maximaCalificacion;
        private string tipo;
        private string aprobado;
        private string desaprobado;
        // Propiedades para los atributos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string CursoEvaluado
        {
            get { return cursoEvaluado; }
            set { cursoEvaluado = value; }
        }
        public string MaximaCalificacion
        {
            get { return maximaCalificacion; }
            set { maximaCalificacion = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Aprobado
        {
            get { return aprobado; }
            set { aprobado = value; }
        }
        public string Desaprobado
        {
            get { return desaprobado; }
            set { desaprobado = value; }
        }
        
        // Declaracion de metodos u operaciones
        public string DescribirProgreso()
        {
            return "El metodo DescribirProgreso recien será implementado";
        }
        public string Motivar()
        {
            return "El metodo motivar recien sera implementado";
        }
        public string Desmotivar()
        {
            return "El metodo desmotivar recien sera implementado";
        }
        public string InformarDocentes()
        {
            return "El metodo InformarDocentes recien sera implementado";
        }
        public string DeterminarAprobacion()
        {
            return "El metodo DeterminarAprobacion recien sera implementado";
        }
    }
}