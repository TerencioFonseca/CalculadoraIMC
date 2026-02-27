using System;
using System.Threading.Channels;
using CalculadoraIMC.Models;
using CalculadoraIMC.Services;


Console.WriteLine("CALCULADORA DE IMC");
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine("Digite sua altura em centímetros:");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a idade:");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso em kg:");
double peso = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o sexo (M ou F):");
Sexo sexo = Console.ReadLine().ToUpper() switch
{
    "M" => Sexo.Masculino,
    "F" => Sexo.Feminino,
    _ => throw new ArgumentException("Sexo inválido. Digite 'Masculino' ou 'Feminino'.")
};
Pessoa pessoa = new Pessoa(nome, altura, idade, peso, sexo);

CalculadoraImc calculadora = new CalculadoraImc();
double imc = calculadora.CalcularImc(pessoa);
CategoriaImc categoria = calculadora.ObterCategoria(imc);
Console.WriteLine($"Seu imc é: {imc} e sua classificação é: {categoria}");
