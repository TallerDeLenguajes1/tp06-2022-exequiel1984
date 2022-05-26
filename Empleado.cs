using System;

namespace ejercicio2{
    
    public class Empleado {

        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        private string apellido;        

        public string Apellido { get => apellido; set => apellido = value; }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        private char estadoCivil;

        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

        private char genero;

        public char Genero { get => genero; set => genero = value; }

        private DateTime fechaIngreso;

        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        private Double sueldoBasico;

        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

        enum cargos{Auxiliar,Administrativo,Ingeniero,Especialista,Investigador}    

        private cargos cargo;

        private cargos Cargo { get => cargo; set => cargo = value; }


        public Empleado()
        {   
            Nombre = "";
            Apellido = "";
            FechaNacimiento = 1 1 1;
            EstadoCivil = ' ';
            Genero = ' ';
            FechaIngreso = ;
            SueldoBasico = 0;
            Cargo = 0;
        }


        public int calcularAntiguedad(DateTime FechaIngreso){

            int antiguedad = DateTime.Now.Year - FechaIngreso.Year;

            return antiguedad;      
        }



        public void mostrarInfoEmpleados()

    }
}

