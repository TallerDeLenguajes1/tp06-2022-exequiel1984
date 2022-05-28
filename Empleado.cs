using System;

namespace ejercicio2{
    
    public class Empleado {

        private string nombre;
        private string apellido;        
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private Double sueldoBasico;
        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

        public char Genero { get => genero; set => genero = value; }

        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public enum Cargos{Auxiliar,Administrativo,Ingeniero,Especialista,Investigador}    

        private Cargos cargo;

        public Empleado(string nombreEmpleado, string apellidoEmpleado, DateTime fechaNacimientoEmpleado, char EstadoCivilEmpleado, char generoEmpleado, DateTime fechaIngresoEmpleado, Double sueldoBasicoEmpleado, Cargos cargoEmpleado)
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
            Console.WriteLine("Genero: " + trabajador.Genero);
            Console.WriteLine("Fecha de Ingreso: " + trabajador.FechaIngreso.ToShortDateString());
            Console.WriteLine("Sueldo Basico: $ " + trabajador.SueldoBasico);
            Console.WriteLine(trabajador.Cargo);
            int antiguedad = calcularAntiguedad(trabajador.FechaIngreso);
            Console.WriteLine("Antiguedad: " + antiguedad);
        }

    }
}

