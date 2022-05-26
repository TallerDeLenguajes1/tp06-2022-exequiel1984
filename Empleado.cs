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

        public enum cargos{Auxiliar,Administrativo,Ingeniero,Especialista,Investigador}    

        private cargos cargo;

        public cargos Cargo { get => cargo; set => cargo = value; }


        public Empleado(string nombreEmpleado, string apellidoEmpleado, DateTime fechaNacimientoEmpleado, char EstadoCivilEmpleado, char generoEmpleado, DateTime fechaIngresoEmpleado, Double sueldoBasicoEmpleado, cargos cargoEmpleado)
        {   
            if(!string.IsNullOrEmpty(nombreEmpleado)) nombre = nombreEmpleado; else nombre = "";
            if(!string.IsNullOrEmpty(apellidoEmpleado)) apellido = apellidoEmpleado; else apellido = "";
            FechaNacimiento = fechaNacimientoEmpleado;
            EstadoCivil = EstadoCivilEmpleado;
            Genero = generoEmpleado;
            FechaIngreso = fechaIngresoEmpleado;
            SueldoBasico = sueldoBasicoEmpleado;
            Cargo = cargoEmpleado;
        }


        public int calcularAntiguedad(DateTime FechaIngreso){

            int antiguedad = DateTime.Now.Year - FechaIngreso.Year;

            return antiguedad;      
        }

        public void mostrarInfoEmpleado(Empleado trabajador){
            Console.WriteLine(trabajador.Nombre);
            Console.WriteLine(trabajador.Apellido);
            Console.WriteLine("Fecha de nacimiento: " + trabajador.FechaNacimiento.ToShortDateString());
            Console.WriteLine("Estado civil: " + trabajador.EstadoCivil);
            System.Console.WriteLine("Genero: " + trabajador.Genero);
            System.Console.WriteLine("Fecha de Ingreso: " + trabajador.FechaIngreso.ToShortDateString());
            System.Console.WriteLine("Sueldo Basico: $ " + trabajador.SueldoBasico);
            System.Console.WriteLine(trabajador.Cargo);
            int antiguedad = calcularAntiguedad(trabajador.FechaIngreso);
            System.Console.WriteLine("Antiguedad: " + antiguedad);
        }

    }
}

