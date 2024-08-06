namespace Conta.Model;
public class ContaCorrente : Conta {
  public ContaCorrente(string nomeCompleto, DateTime dataDeNascimento,
                       string cpf, string endereco, string telefone,
                       string email, string documentoIdentidade)
      : base(nomeCompleto, dataDeNascimento, cpf, endereco, telefone, email) {
    DocumentoIdentidade = documentoIdentidade;
  }

  // Propriedade específica da ContaCorrente
  public string DocumentoIdentidade { get; private set; }

  // Método específico da ContaCorrente
  public void AtualizarDocumentoIdentidade(string novoDocumentoIdentidade) {
    DocumentoIdentidade = novoDocumentoIdentidade;
  }
}
