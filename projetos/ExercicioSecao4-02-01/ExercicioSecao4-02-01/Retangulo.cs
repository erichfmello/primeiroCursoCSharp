﻿using System;

namespace ExercicioSecao4_02_01 {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return 2 * Largura + 2 * Altura;
        }

        public double Diagonal() {
            return Math.Sqrt((Math.Pow(Largura, 2) + Math.Pow(Altura, 2)));
        }

        public override string ToString() {
            return "Area = " + Area().ToString("F2")
                + "\nPerímetro = " + Perimetro().ToString("F2")
                + "\nDiagonal = " + Diagonal().ToString("F2");
        }
    }
}
