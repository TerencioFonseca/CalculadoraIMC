using CalculadoraIMC.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;


namespace CalculadoraIMC.Services
{

    public enum CategoriaImc
    {
        AbaixoDoPeso,
        PesoNormal,
        Sobrepeso,
        ObesidadeGrau1,
        ObesidadeGrau2,
        ObesidadeGrau3
    }
    public class CalculadoraImc
    {
        public double CalcularImc(Pessoa pessoa)
        {
            // Convertendo altura de cm para metros
            double alturaEmMetros = pessoa.Altura / 100;
            // Fórmula do IMC: peso / (altura^2)
            double imc = pessoa.Peso / (alturaEmMetros * alturaEmMetros); 
            return Math.Round(imc, 2);
        }

        public CategoriaImc ObterCategoria(double imc)
        {
            return imc switch
            {
                < 18.5 => CategoriaImc.AbaixoDoPeso,
                >= 18.5 and < 25 => CategoriaImc.PesoNormal,
                >= 25 and < 30 => CategoriaImc.Sobrepeso,
                >= 30 and < 35 => CategoriaImc.ObesidadeGrau1,
                >= 35 and < 40 => CategoriaImc.ObesidadeGrau2,
                _ => CategoriaImc.ObesidadeGrau3
            };
        }
    }
}