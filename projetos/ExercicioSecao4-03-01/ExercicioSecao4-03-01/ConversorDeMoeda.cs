namespace ExercicioSecao4_03_01 {
    class ConversorDeMoeda {
        public static double IOF = 0.06;

        public static double ValorASerPago(double CotacaoDoDolar, double QuantidadeDeDolares) {
            return CotacaoDoDolar * QuantidadeDeDolares * (1 + IOF);
        }
    }
}
