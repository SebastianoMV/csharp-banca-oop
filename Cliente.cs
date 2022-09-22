// See https://aka.ms/new-console-template for more information

public class Cliente
{
    public Cliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {
        Nome = nome;
        Cognome = cognome;
        CodiceFiscale = codiceFiscale;
        Stipendio = stipendio;
    }

    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string CodiceFiscale { get; set; }
    public int Stipendio { get; set; }

    public override string ToString()
    {
        return $"{Nome}  {Cognome}  {CodiceFiscale}  {Stipendio}";
    }

}
