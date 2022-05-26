using System;

namespace punto1{
    
    public class Calculadora {

        private Double resultado;

        public double Resultado { get => resultado; set => resultado = value; }

        public Calculadora(double numero)
        {
            Resultado = numero;
        }

        public void Sumar(Double termino){
            Resultado += termino;
        }

        public void Restar(Double termino){
            Resultado -= termino;
        }
        
        public void Multiplicar(Double termino){
            Resultado *= termino;
        }

        public void Dividir(Double termino){
            
            Resultado /= termino;
        }

        public int Limpiar(){
            return 0;
        }
    }
}

