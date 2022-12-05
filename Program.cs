using bytebank;
using bytebank.Titular;

ContaCorrente conta1 = new ContaCorrente(55, "65847-8");
ContaCorrente conta2 = new ContaCorrente(55, "45844-8");

conta1.Titular.Nome = "Gabriel";
conta1.Titular.Profissao = "Desenvolvedor";
conta1.Saldo = 1000;

Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

Console.ReadKey();
