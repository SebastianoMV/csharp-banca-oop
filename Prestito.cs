// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;

public class Prestito
{
    public Prestito(Cliente cliente, int totale, int rata, DateTime dataInizio)
    {
        
        ID = generaId();
        Cliente = cliente;
        Totale = totale;
        Rata = rata;
        DataInizio = dataInizio;
        DataFine = Fine();
    }

    public static int countId = 0;
    public int ID { get; set; }
    
    public Cliente Cliente { get; }
    public int Totale { get; }
    public int Rata { get; }
    public DateTime DataInizio { get; }
    public DateTime DataFine { get; set; }

    public int generaId()
    {
        countId++;
        
        return ID = countId;
    }

    public DateTime Fine()
    {
        DataFine = DataInizio.AddMonths(Totale / Rata);
        return DataFine;
    }

}