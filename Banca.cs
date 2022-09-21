// See https://aka.ms/new-console-template for more information
public class Banca
{
    

    public Banca(string nome, List<Cliente> clienti, List<Prestito> prestit)
    {
        this.nome = nome;
        this.Clienti = clienti;
        this.Prestiti = prestit;
    }


    string nome;
    public List<Cliente> Clienti { get; set; }
    public List<Prestito> Prestiti { get; set; }





}


