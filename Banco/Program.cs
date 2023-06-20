// criando uma conta, criando objetos

/*
using Banco;
// criando um objeto da classe
ContaCorrente contaDoGlauber =  new ContaCorrente();

// acessando e adicionando valores aos campos

contaDoGlauber.titular = "Glauber Roque";
contaDoGlauber.conta = "1010-x";
contaDoGlauber.numeroAgencia = 15;
contaDoGlauber.saldo = 1000;

// criando outra conta
ContaCorrente contaDaTayga = new ContaCorrente();
contaDaTayga.titular = "Tayga Rayanne";
contaDaTayga.conta = "1011-x";
contaDaTayga.numeroAgencia = 15;
contaDaTayga.saldo = 1000;

// exibindo dados
Console.WriteLine("O saldo da conta do " + contaDoGlauber.titular + " é: " + contaDoGlauber.saldo + " reais.");

// usando o metodo DEPOSTAR para adicionar saldo a conta

contaDoGlauber.Depositar(300);

// exibindo dados após o deposito
Console.WriteLine("O saldo da conta do "+ contaDoGlauber.titular + " pós deposito é de: " + contaDoGlauber.saldo + " reais.");

// usando o metodo SACAR cara retirar saldo da conta
if (contaDoGlauber.Sacar(500) == true)
{
    // exibindo dados após o saque
    Console.WriteLine("O saldo da conta do " + contaDoGlauber.titular + " pós saque é de: " + contaDoGlauber.saldo + " reais.");
} else
{
    // Exibindo mensagem caso saldo seja insulficiente
    Console.WriteLine("Saldo insulficiente!");
}

Console.WriteLine("-----------------------------------------------------------------------------------------------------");


// exibindo dados
Console.WriteLine("O saldo da conta do " + contaDaTayga.titular + " é: " + contaDaTayga.saldo + " reais.");

// usando o metodo TRANSFERIR
contaDoGlauber.Transferir(100, contaDaTayga);
Console.WriteLine("O saldo da conta do " + contaDoGlauber.titular + " é: " + contaDoGlauber.saldo + " reais.");
Console.WriteLine("O saldo da conta do " + contaDaTayga.titular + " é: " + contaDaTayga.saldo + " reais.");
*/



using Banco;
// cliando um novo cliente
Cliente cliente = new Cliente();
cliente.nome = "Glauber Roque";
cliente.Cpf = "175326985-74";
cliente.profissao = "Desenvolvedor";

// ligando a conta ao cliente novo
ContaCorrente conta = new ContaCorrente(15, "1010-x");
conta.titular = cliente;
conta.conta = "1010-x";
conta.SetSaldo(500);

Console.WriteLine("------------------------------ Dados Clientes --------------------------------");
Console.WriteLine("Titular: " + conta.titular.nome);
Console.WriteLine("Cpf: " + conta.titular.Cpf);
Console.WriteLine("Profissão: " + conta.titular.profissao);
Console.WriteLine("Nª da Conta: " + conta.conta);
Console.WriteLine("Agencia: " + conta.NumeroAgencia);
Console.WriteLine("Saldo em Conta: " + conta.GetSaldo());