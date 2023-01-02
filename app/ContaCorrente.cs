using bytebank.Titular;

namespace bytebank
{
  public class ContaCorrente
  {
    public Cliente Titular { get; set; } = new Cliente();
    public string NomeAgencia { get; set; } = "";
    // private int _numeroAgencia;
    public int NumeroAgencia { get; }
    private string _conta = "";
    public string Conta
    {
      get
      {
        return _conta;
      }
      set
      {
        if (value == null)
        {
          return;
        }
        else
        {
          _conta = value;
        }
      }
    }
    private double _saldo;
    public double Saldo
    {
      get
      {
        return _saldo;
      }
      set
      {
        if (value < 0)
        {
          return;
        }
        else
        {
          _saldo = value;
        }
      }
    }

    public static double TaxaOperacao { get; private set; }

    public void Sacar(double valor)
    {
      if (valor < 0)
      {
        throw new ArgumentException("Valor de saque não pode ser negativo", nameof(valor));
      }
      if (_saldo < valor)
      {
        throw new SaldoInsuficienteException("Saldo insuficiente para saque no valor de " + valor);
      }
        _saldo = _saldo - valor;
    }

    public void Depositar(double valor)
    {
      _saldo = _saldo + valor;
    }

    public void Transferir(double valor, ContaCorrente destino)
    {
      if (valor < 0)
      {
        throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
      }
      if (_saldo < valor)
      {
        throw new ArgumentException("Saldo inválido para a transferência.", nameof(_saldo));
      }
      else
      {
        _saldo = _saldo - valor;
        destino._saldo = destino._saldo + valor;
      }
    }

    public ContaCorrente(int numeroAgencia, string conta)
    {
      if (numeroAgencia <= 0)
      {
        throw new ArgumentException("O argumento numeroAgencia deve ser maior que 0.", nameof(numeroAgencia));
      }

      NumeroAgencia = numeroAgencia;
      Conta = conta;

      // TaxaOperacao = 30 / TotalDeContasCriadas;
      
      TotalDeContasCriadas += 1;
    }

    public static int TotalDeContasCriadas { get; private set; }
  }
}