using MeLevaAi.Api.Domain;

namespace MeLevaAi.Api.Repositories;

public class PassageiroRepository
{
    private static readonly List<Passageiro> _passageiros = new();

    public IEnumerable<Passageiro> Listar()
        => _passageiros;

    public Passageiro? Obter(Guid id)
        => (from p in _passageiros where p.Id == id select p).FirstOrDefault();

    public Passageiro Cadastrar(Passageiro passageiro)
    {
        _passageiros.Add(passageiro);

        return passageiro;
    }

    public bool Remover(Guid id)
    {
        var passageiro = Obter(id);

        if (passageiro is null)
            return false;

        return _passageiros.Remove(passageiro);
    }
}