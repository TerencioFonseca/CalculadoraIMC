using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraIMC.Models
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Idade { get; set; }
        public double Peso { get; set; }
        public char Sexo { get; set; }

        public Pessoa()
        {
                     
        }

        public Pessoa(string nome, double altura, double idade, double peso, char sexo)
        {
            Nome = nome;
            Altura = altura;
            Idade = idade;
            Peso = peso;
            Sexo = sexo;
        }
    }
}
