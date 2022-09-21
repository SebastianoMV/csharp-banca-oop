// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("BANCA");

List<Cliente> clienti = new List<Cliente>();

List<Prestito> prestiti = new List<Prestito>();

Banca BancaPopolare = new Banca("BancaPopolare", clienti, prestiti);
BancaPopolare.Clienti.Add(new Cliente("Pippo", "de Pippi", "pppdppp", 20000));
BancaPopolare.Clienti.Add(new Cliente("Ugo", "de Ugi", "gdgdgdgd", 30000));
BancaPopolare.Clienti.Add(new Cliente("John", "Doe", "jhndoe", 10000));

BancaPopolare.Prestiti.Add(new Prestito(BancaPopolare.Clienti[0], 5000, 500, DateTime.Today , DateTime.Today.AddMonths(5)));

Console.WriteLine(BancaPopolare.Prestiti[0].DataFine);


void AddCliente(string nome, string cognome, string codiceFiscale, int stipendio)
{
    Cliente nuovoCliente = new Cliente(nome, cognome, codiceFiscale, stipendio);
    BancaPopolare.Clienti.Add(nuovoCliente);
}

void ModificaCliente(Cliente cliente)
{
    Console.WriteLine("Cosa vuoi modificare? [nome/cognome/cf/stipendio]" );
    string scelta = Console.ReadLine();
    switch(scelta)
    {
        case "nome":
            Console.WriteLine("Inserisci nome modificato");
            cliente.Nome = Console.ReadLine();
            break;
        case "cognome":
            Console.WriteLine("Inserisci cognome modificato");
            cliente.Cognome = Console.ReadLine();
            break;
        case "cf":
            Console.WriteLine("Inserisci Codice Fiscale modificato");
            cliente.CodiceFiscale = Console.ReadLine();
            break;
        case "stipendio":
            Console.WriteLine("Inserisci Stipendio modificato");
            cliente.Stipendio = Int32.Parse(Console.ReadLine());
            break;
        default:
            Console.WriteLine("Non hai scelto niente");
            break;

    }
}