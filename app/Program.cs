using bytebank;
using bytebank.Titular;

ContaCorrente conta1 = new ContaCorrente(55, "65847-8");
// ContaCorrente conta2 = new ContaCorrente(55, "45844-8");

try
{
  ContaCorrente conta = new ContaCorrente(1, "475");
    conta.Depositar(100);
    Console.WriteLine(conta.Saldo);
    conta.Sacar(-500);
    Console.WriteLine(conta.Saldo);
} 
catch (ArgumentException e)
{
  Console.WriteLine(e.Message);
}
catch (SaldoInsuficienteException ex)
{
  Console.WriteLine(ex.Message);
  Console.WriteLine("Saldo insuficiente");
}

conta1.Titular.Nome = "Gabriel";
conta1.Titular.Profissao = "Desenvolvedor";
conta1.Saldo = 1000;

// Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);
// Console.WriteLine("Taxa de operacação: " + ContaCorrente.TaxaOperacao);

Console.ReadKey();
