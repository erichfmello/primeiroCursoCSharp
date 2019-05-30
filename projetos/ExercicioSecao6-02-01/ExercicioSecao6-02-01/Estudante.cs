namespace ExercicioSecao6_02_01 {
    class Estudante {
        public int NumeroQuarto { get; set; }
        public string NomeEstudante { get; set; }
        public string EmailEstudante { get; set; }

        public Estudante (int numeroQuarto, string nomeEstudante, string emailEstudante) {
            NumeroQuarto = numeroQuarto;
            NomeEstudante = nomeEstudante;
            EmailEstudante = emailEstudante;
        }

        public override string ToString() {
            return NumeroQuarto + ": " + NomeEstudante + ", " + EmailEstudante;
        }
    }
}
