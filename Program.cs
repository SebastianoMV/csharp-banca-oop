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

Console.WriteLine("Cosa vuoi fare? [clienti/prestiti]");
string azione = Console.ReadLine();
if (azione == "clienti")
{
    Console.WriteLine("Cosa vuoi fare? [aggiungere/modificare/cercare]");
    string scelta = Console.ReadLine();
    if (scelta == "aggiungere")
    {
        AddCliente();
    }
    else if (scelta == "modificare")
    {
        ModificaCliente();
    }
    else if (scelta == "cercare")
    {
        CercaCliente();
    }

}



void CercaCliente()
{
    Console.WriteLine("Inserisci il Codice Fiscale del cliente da cercare");
    string cf = Console.ReadLine();
    foreach (Cliente cliente in clienti)
    {
        if (cliente.CodiceFiscale == cf)
        {
            Console.WriteLine("Nome cliente: " + cliente.Nome);
            Console.WriteLine("Cognome cliente: " + cliente.Cognome);

        }
    }
}


void AddCliente()
{
    Console.WriteLine("Inserisci il nome");
    string newNome = Console.ReadLine();

    Console.WriteLine("Inserisci il cognome");
    string newCognome = Console.ReadLine();

    Console.WriteLine("Inserisci il codice fiscale");
    string newcf = Console.ReadLine();

    Console.WriteLine("Inserisci lo stipendio");
    int newStipendio = Int32.Parse(Console.ReadLine());

    Cliente nuovoCliente = new Cliente(newNome, newCognome, newcf, newStipendio);
    BancaPopolare.Clienti.Add(nuovoCliente);
}

void ModificaCliente()
{
    Console.WriteLine("Inserisci il Codice Fiscale del cliente da modificare");
    string cf = Console.ReadLine();
    foreach (Cliente cliente in clienti)
    {
        if (cliente.CodiceFiscale == cf)
        {
            Console.WriteLine("Cosa vuoi modificare? [nome/cognome/cf/stipendio]");
            string scelta = Console.ReadLine();
            switch (scelta)
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
        else
        {
            Console.WriteLine("Cliente non trovato");
        }
    }
}


void SearchPrestito(string cf)
{
    Cliente clienteToSearch;
    foreach (Cliente cliente in clienti)
    {
        if (cliente.CodiceFiscale == cf)
        {
            clienteToSearch = cliente;
        }
    }

    foreach (Prestito prestito in prestiti)
    {
        if (prestito.Cliente.CodiceFiscale == cf)
        {
            Console.WriteLine("Prestito di " + prestito.Cliente.Nome);
            Console.WriteLine("Prestito numero " + prestito.ID);
        }
    }
}

