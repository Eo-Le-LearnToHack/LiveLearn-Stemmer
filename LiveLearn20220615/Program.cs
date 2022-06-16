using LiveLearn20220615;

Område[] stemmer = { new ("Område A"), new ("Område B"), new ("Område C"), new ("Område D"), new ("Område E") };

int danskeTotal = 0;
int tyskeTotal = 0;
foreach(Område område in stemmer)
{
    Console.WriteLine($"Indtast antal danske stemmer i {område.Navn}");


    int indtastetDansk = SikkerIndtastning();
    område.DanskeStemmer = indtastetDansk;
    danskeTotal += område.DanskeStemmer;

    Console.WriteLine($"Indtast antal tyske stemmer i {område.Navn}");
    område.TyskeStemmer = SikkerIndtastning();
    tyskeTotal += område.TyskeStemmer;

    Console.WriteLine(område.Resultat());
}

Console.WriteLine($"Danske i alt {danskeTotal}");
Console.WriteLine($"Tyske i alt {tyskeTotal}");

int SikkerIndtastning()
{
    
    int indtastetTal;
    bool varDetEtTal;
    do
    {
        string? indtastetString = Console.ReadLine();
        varDetEtTal = Int32.TryParse(indtastetString, out indtastetTal);
        if (!varDetEtTal)
        {
            Console.WriteLine("Det skulle have været et tal");
        }
    } while (!varDetEtTal);
    return indtastetTal;
}