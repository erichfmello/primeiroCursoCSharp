namespace ExercicioSecao5_01_01 {
    class Banco {
        public int NumetoConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Banco(int numeroConta, string nome) {
            NumetoConta = numeroConta;
            Nome = nome;
        }

        public Banco(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome) {
            Saldo = depositoInicial;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= (saque + 5);
        }

        public override string ToString() {
            return "\nDados da conta:"
                + "\nConta " + NumetoConta + ", Titular: " + Nome + ", Saldo: R$" + Saldo.ToString("F2") + "\n";
        }
    }
}
