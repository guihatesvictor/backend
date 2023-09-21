namespace banco {

    class contaCorrente {
        private string titular { get; set; }
        private double saldo { get; set; }

        public contaCorrente(string titular, double saldo) {
            this.titular = titular;
            this.saldo = saldo;
        }

        public void consultarSaldo() {
            Console.WriteLine($"O saldo diponível para {titular} é de R${saldo}");
        }

        public void depositar(double valor) {
            if (valor > 0) {
                saldo += valor;
                Console.WriteLine($"Um depósito de R${valor} foi feito!");
            }
            else {
                Console.WriteLine("Esse valor é inválido para o depósito.");
            }
        }

        public void sacar(double valor) {
            if (valor > 0 && valor <= saldo) {
                saldo -= valor;
                Console.WriteLine($"Você realizou um saque de R${valor}");
            }
            else {
                Console.WriteLine($"O saldo é inválido ou insuficiente.");
            }
        }
    }
}