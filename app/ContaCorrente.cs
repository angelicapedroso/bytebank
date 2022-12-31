using bytebank.Titular;

namespace bytebank
{
  public class ContaCorrente
  {
    public Cliente Titular { get; set; } = new Cliente();
    public string NomeAgencia { get; set; } = "";
    private int _numeroAgencia;
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

    public bool Sacar(double valor)
    {
      if (_saldo < valor)
      {
        return false;
      }
      if (valor < 0)
      {
        return false;
      }
      else
      {
        _saldo = _saldo - valor;
        return true;
      }
    }

    public void Depositar(double valor)
    {
      _saldo = _saldo + valor;
    }

    public bool Transferir(double valor, ContaCorrente destino)
    {
      if (_saldo < valor)
      {
        return false;
      }
      if (valor < 0)
      {
        return false;
      }
      else
      {
        _saldo = _saldo - valor;
        destino._saldo = destino._saldo + valor;
        return true;
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