namespace ExercicioSecao4_02_03 {
    class Boletim {
        public string Nome;
        public double nota1, nota2, nota3;

        public double NotaFinal() {
            return nota1 + nota2 + nota3;
        }

        public bool Aprovacao() {
            if(NotaFinal() >= 60) {
                return true;
            } else {
                return false;
            }
        }

        public string Situacao() {
            if(Aprovacao() == true) {
                return "Aprovado";
            } else {
                return "Reprovado";
            }
        }

        public double NotaRestante() {
            if(Aprovacao() == false) {
                return 60 - NotaFinal();
            } else {
                return 0;
            }
        }

        public override string ToString() {
            if(Aprovacao() == true) {
                return "Nota final = " + NotaFinal()
                    + "\n" + Situacao();
            } else {
                return "Nota final = " + NotaFinal()
                    + "\n" + Situacao()
                    + "\nFaltaram " + NotaRestante() + " Pontos";
            }
        }
    }
}
