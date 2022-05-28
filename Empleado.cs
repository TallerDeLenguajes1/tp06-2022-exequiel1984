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

        public int calcularEdad(DateTime FechaNacimiento){

            int edad = DateTime.Now.Year - FechaNacimiento.Year;

            return edad;      
        }

        public int calcularAniosParaJubilarse( char genero, int edad){

            int aniosParaJubilarse;

            if (genero == 'H')
            {
                aniosParaJubilarse = 65 - edad;
            }else{
                aniosParaJubilarse = 60 - edad;
            }
            return aniosParaJubilarse;      
        }

        public double calcularSalario(double sueldoBasico, int antiguedad, Cargos cargo, char estadoCivil){
            double adicional;
            if (antiguedad <= 20)
            {
                adicional = sueldoBasico * antiguedad / 100;
                
            }else{
                adicional = sueldoBasico * 0.25;
            }

            if (cargo == Cargos.Especialista || cargo == Cargos.Ingeniero)
            {
                adicional *= 1.5;
            }

            if (estadoCivil == 'C')
            {
                adicional += 15000;
            }

            double salario = sueldoBasico + adicional;
            return salario;
        }

        public void mostrarInfoEmpleado(int antiguedad, int edad, int aniosParaJubilarse, double salario){
            Console.WriteLine("");
            Console.WriteLine(Apellido + " " + Nombre);
            Console.WriteLine("Fecha de nacimiento: " + FechaNacimiento.ToShortDateString());
            Console.WriteLine("Estado civil: " + EstadoCivil);
            Console.WriteLine("Genero: " + Genero);
            Console.WriteLine("Fecha de Ingreso: " + FechaIngreso.ToShortDateString());
            Console.WriteLine("Sueldo Basico: $ " + SueldoBasico);
            Console.WriteLine(Cargo);
            Console.WriteLine("Antiguedad: " + antiguedad);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Cantidad de años para jubilarse: " + aniosParaJubilarse);
            Console.WriteLine("Salario: $ " + salario);
            Console.WriteLine("");
        }

    }
}

