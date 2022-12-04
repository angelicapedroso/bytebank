using bytebank;
using bytebank.Titular;

// Console.WriteLine("Boas-vindas ao ByteBank");

// ContaCorrente conta1 = new ContaCorrente();
// conta1.titular = "Angélica";
// conta1.conta = "18265-x";
// conta1.numeroAgencia = 55;
// conta1.nomeAgencia = "Agência xyz";
// conta1.saldo = 100;

// ContaCorrente conta2 = new ContaCorrente();
// conta2.titular = "Letícia";
// conta2.conta = "10865-x";
// conta2.numeroAgencia = 55;
// conta2.nomeAgencia = "Agência xyz";
// conta2.saldo = 100;

// Console.WriteLine("Titular: " + conta1.titular);
// Console.WriteLine("Conta: " + conta1.conta);
// Console.WriteLine("Número da agência: " + conta1.numeroAgencia);
// Console.WriteLine("Nome da agência: " + conta1.nomeAgencia);
// Console.WriteLine("Saldo: " + conta1.saldo);

// Console.WriteLine("Saldo da Angélica pré-transferência: " + conta1.saldo);
// Console.WriteLine("Saldo da Letícia pré-transferência: " + conta2.saldo);
// bool transferencia = conta1.Transferir(50, conta2);
// Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
// Console.WriteLine("Saldo da Angélica pós-transferência: " + conta1.saldo);
// Console.WriteLine("Saldo da Letícia pós-transferência: " + conta2.saldo);

Cliente cliente = new Cliente();

// cliente.nome = "Angélica";
// cliente.cpf = "123.456.789-10";
// cliente.profissao = "Desenvolvedora C#";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = new Cliente();
cliente.nome = "Angélica";
cliente.cpf = "123.456.789-10";
cliente.profissao = "Desenvolvedora C#";
conta3.conta = "18265-x";
conta3.numeroAgencia = 55;
conta3.nomeAgencia = "Agência xyz";

conta3.DefinirSaldo(-10);

// Console.WriteLine("Saldo: " + conta3.saldo);

Console.ReadKey();
