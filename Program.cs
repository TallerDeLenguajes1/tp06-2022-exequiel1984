using System;
using punto1;

    int aux = 6;
    
    Console.WriteLine("Ingrese un numero: ");
    Double termino = Convert.ToDouble(Console.ReadLine());

    Calculadora calculadora = new Calculadora(termino);

    while (aux != 0)
    {
        Console.WriteLine("Ingrese la operacion a realizar (Suma 1 - Resta 2 - Multiplicacion 3 - Division 4 - Terminar 5):");
        aux = Convert.ToInt32(Console.ReadLine());
        switch (aux)
        {
            case 1: 
                Console.WriteLine("Ingrese el numero a sumar a " + calculadora.Resultado);
                termino = Convert.ToDouble(Console.ReadLine());
                calculadora.Sumar(termino);
                Console.WriteLine("El resultado de la suma es: " + calculadora.Resultado);
                break;
            case 2: 
                Console.WriteLine("Ingrese el numero a restar a " + calculadora.Resultado);
                termino = Convert.ToDouble(Console.ReadLine());
                calculadora.Restar(termino);
                Console.WriteLine("El resultado de la resta es: " + calculadora.Resultado);

                break;
            case 3: 
                Console.WriteLine("Ingrese el numero a multiplicar a" + calculadora.Resultado);
                termino = Convert.ToDouble(Console.ReadLine());
                calculadora.Multiplicar(termino);
                Console.WriteLine("El resultado de la multiplicacion es: " + calculadora.Resultado);

                break;
            case 4: 
                Console.WriteLine("Ingrese el numero a dividir a " + calculadora.Resultado);
                termino = Convert.ToDouble(Console.ReadLine());
                if (termino == 0)
                {
                    Console.WriteLine("No es posible dividir en 0");
                    break;
                }else
                {
                    calculadora.Dividir(termino);
                    Console.WriteLine("El resultado de la division es: " + calculadora.Resultado);
                    break;
                }
            case 5:
                aux = calculadora.Limpiar();
                break;
        }
    }

