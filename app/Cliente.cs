namespace bytebank.Titular
{
  public class Cliente
  {
    public string Nome { get; set; } = "";
    public string Cpf { get; set; } = "";
    public string Profissao { get; set; } = "";

    public static int TotalClientesCadastrados { get; private set; }

    public Cliente()
    {
      TotalClientesCadastrados = TotalClientesCadastrados + 1;
    }
  }
}