
using Conta.Model;

namespace ContaApp;
class Program {
  static void Main(string[] args) {
    // Criando uma instância de ContaCorrente
    ContaCorrente contaCorrente =
        new("João Silva", new DateTime(1985, 5, 20), "123.456.789-00",
            "Rua A, 123", "99999-9999", "joao@example.com", "RG123456");

    // Atualizando documento de identidade da ContaCorrente
    contaCorrente.AtualizarDocumentoIdentidade("RG654321");
    Console.WriteLine(
        $"Conta Corrente - Documento Identidade Atualizado: {contaCorrente.DocumentoIdentidade}");

    // Criando uma instância de ContaPoupanca
    ContaPoupanca contaPoupanca =
        new("Maria Souza", new DateTime(1990, 3, 15), "987.654.321-00",
            "Rua B, 456", "88888-8888", "maria@example.com",
            "ComprovanteResidencia123");

    // Atualizando comprovante de residência da ContaPoupanca
    contaPoupanca.AtualizarComprovanteResidencia("ComprovanteResidencia456");
    Console.WriteLine(
        $"Conta Poupança - Comprovante Residência Atualizado: {contaPoupanca.ComprovanteResidencia}");

    // Criando uma instância de ContaInvestimento
    ContaInvestimento contaInvestimento =
        new("Carlos Pereira", new DateTime(1975, 7, 10), "321.654.987-00",
            "Rua C, 789", "77777-7777", "carlos@example.com",
            "ComprovanteRenda123", "DeclaracaoImpostoRenda123");

    // Atualizando comprovante de renda e declaração de imposto de renda da
    // ContaInvestimento
    contaInvestimento.AtualizarComprovanteRenda("ComprovanteRenda456");
    contaInvestimento.AtualizarDeclaracaoImpostoRenda(
        "DeclaracaoImpostoRenda456");
    Console.WriteLine(
        $"Conta Investimento - Comprovante Renda Atualizado: {contaInvestimento.ComprovanteRenda}");
    Console.WriteLine(
        $"Conta Investimento - Declaração Imposto Renda Atualizada: {contaInvestimento.DeclaracaoImpostoRenda}");
  }
}
