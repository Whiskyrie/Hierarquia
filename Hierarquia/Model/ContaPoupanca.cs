namespace Conta.Model;

public class ContaPoupanca : Conta {
  public ContaPoupanca(string nomeCompleto, DateTime dataDeNascimento,
                       string cpf, string endereco, string telefone,
                       string email, string comprovanteResidencia)
      : base(nomeCompleto, dataDeNascimento, cpf, endereco, telefone, email) {
    ComprovanteResidencia = comprovanteResidencia;
  }

  // Propriedade específica da ContaPoupanca
  public string ComprovanteResidencia { get; private set; }

  // Método específico da ContaPoupanca
  public void AtualizarComprovanteResidencia(string novoComprovanteResidencia) {
    ComprovanteResidencia = novoComprovanteResidencia;
  }
}
