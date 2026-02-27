using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraIMC.Models
{

    public enum Sexo { Masculino, Feminino }
    public class Pessoa
    {

        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }
        public Sexo Sexo { get; set; }

        // Construtor para inicializar os dados da pessoa(a altura deve ser colocada em cm)
        public Pessoa(string nome, double altura, int idade, double peso, Sexo sexo) 
        {
            Nome = nome;
            Altura = altura;
            Idade = idade;
            Peso = peso;
            Sexo = sexo;
        }
    }
}