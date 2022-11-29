using bytebank;

Console.WriteLine("Boas-vindas ao ByteBank");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Angélica";
conta1.conta = "18265-x";
conta1.numeroAgencia = 55;
conta1.nomeAgencia = "Agência xyz";
conta1.saldo = 323;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número da agência: " + conta1.numeroAgencia);
Console.WriteLine("Nome da agência: " + conta1.nomeAgencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Pessoa pessoa1 = new Pessoa();

Console.WriteLine(pessoa1.nome);
Console.WriteLine(pessoa1.idade);
Console.WriteLine(pessoa1.altura);
Console.WriteLine(pessoa1.peso);

Console.ReadKey();
