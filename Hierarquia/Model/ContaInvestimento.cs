namespace Conta.Model;

public class ContaInvestimento : Conta {
  public ContaInvestimento(string nomeCompleto, DateTime dataDeNascimento,
                           string cpf, string endereco, string telefone,
                           string email, string comprovanteRenda,
                           string declaracaoImpostoRenda)
      : base(nomeCompleto, dataDeNascimento, cpf, endereco, telefone, email) {
    ComprovanteRenda = comprovanteRenda;
    DeclaracaoImpostoRenda = declaracaoImpostoRenda;
  }

  // Propriedades específicas da ContaInvestimento
  public string ComprovanteRenda { get; private set; }
  public string DeclaracaoImpostoRenda { get; private set; }

  // Métodos específicos da ContaInvestimento
  public void AtualizarComprovanteRenda(string novoComprovanteRenda) {
    ComprovanteRenda = novoComprovanteRenda;
  }

  public void
  AtualizarDeclaracaoImpostoRenda(string novaDeclaracaoImpostoRenda) {
    DeclaracaoImpostoRenda = novaDeclaracaoImpostoRenda;
  }
}
