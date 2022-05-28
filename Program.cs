using ejercicio2;

int antiguedad;
int edad;
int aniosParaJubilarse;
double salario;
double totalSalarios = 0;

Empleado[] empleados = new Empleado[3]; 

empleados[0] = new Empleado("Exequiel", "Carrizo", new DateTime(1984,10,13), 'S', 'H', new DateTime(2000,3,1), 100000, Empleado.Cargos.Administrativo);
empleados[1] = new Empleado("Natalia", "Soria", new DateTime(1982,9,14), 'C', 'M', new DateTime(2012,10,1), 100000, Empleado.Cargos.Auxiliar);
empleados[2] = new Empleado("Mini", "CarriSoria", new DateTime(1982,9,14), 'C', 'M', new DateTime(2012,10,1), 100000, Empleado.Cargos.Especialista);

for (int i = 0; i <= 2; i++)
{
    antiguedad = empleados[i].calcularAntiguedad(empleados[i].FechaIngreso);
    edad = empleados[i].calcularEdad(empleados[i].FechaNacimiento);
    aniosParaJubilarse = empleados[i].calcularAniosParaJubilarse(empleados[i].Genero, edad);
    salario = empleados[i].calcularSalario(empleados[i].SueldoBasico, antiguedad, empleados[i].Cargo, empleados[i].EstadoCivil);
    totalSalarios += salario;
    empleados[i].mostrarInfoEmpleado(antiguedad, edad, aniosParaJubilarse, salario);
}

Console.WriteLine("---------------------------------");
Console.WriteLine("Total de salarios: $ " + totalSalarios);
