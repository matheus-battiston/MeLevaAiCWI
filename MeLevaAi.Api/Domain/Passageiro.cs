using static System.Guid;

namespace MeLevaAi.Api.Domain;

public class Passageiro
{
    public Passageiro(string nome, DateOnly dataNascimento, string cpf, string email)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Cpf = cpf;
        Email = email;
    }

    public string Email { get; set; }

    public Guid Id { get; init; } = NewGuid();
    public string Nome { get; set; }
    public DateOnly DataNascimento { get; set; }
    public string Cpf { get; set; }
    public float SaldoEmConta { get; set; } = 0;
    public int QuantidadeAvaliacoes { get; set; } = 0;
    public int SomaDasNotas { get; set; } = 0;
    public double MediaDasAvaliacoes { get; set; } = 5;
    public int NumeroDeCorridas { get; set; } = 0;
}