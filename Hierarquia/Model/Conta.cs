namespace Conta.Model;
public abstract class Conta {

  // Propriedades comuns
  public string NomeCompleto { get; private set; }
  public DateTime DataDeNascimento { get; private set; }
  public string CPF { get; private set; }
  public string Endereco { get; private set; }
  public string Telefone { get; private set; }
  public string Email { get; private set; }
  protected Conta(string nomeCompleto, DateTime dataDeNascimento, string cpf,
                  string endereco, string telefone, string email) {
    NomeCompleto = nomeCompleto;
    DataDeNascimento = dataDeNascimento;
    CPF = cpf;
    Endereco = endereco;
    Telefone = telefone;
    Email = email;
  }
  // Métodos protegidos para serem utilizados apenas pelas classes derivadas
  protected void AtualizarEndereco(string novoEndereco) {
    Endereco = novoEndereco;
  }

  protected void AtualizarTelefone(string novoTelefone) {
    Telefone = novoTelefone;
  }
}