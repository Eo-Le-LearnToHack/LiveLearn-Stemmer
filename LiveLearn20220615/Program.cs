using LiveLearn20220615;

Område[] stemmer = { new ("Område A"), new ("Område B"), new ("Område C"), new ("Område D"), new ("Område E") };
MethodValidation myMethodValidation = new();

int danskeTotal = 0;
int tyskeTotal = 0;
foreach(Område område in stemmer)
{
    Console.WriteLine($"Indtast antal danske stemmer i {område.Navn}");
    int indtastetDansk;
    string indtastetDanskTest = Console.ReadLine();
    indtastetDansk = myMethodValidation.IsANumber(indtastetDanskTest);
    område.DanskeStemmer = indtastetDansk;
    danskeTotal += område.DanskeStemmer;

    Console.WriteLine($"Indtast antal tyske stemmer i {område.Navn}");
    int indtastetTysk;
    string indtastetTyskTest = Console.ReadLine();
    indtastetTysk = myMethodValidation.IsANumber(indtastetTyskTest);
    område.TyskeStemmer = indtastetTysk;
    tyskeTotal += område.TyskeStemmer;

    Console.WriteLine($"Der er flest {område.Resultat()} stemmer.");
}

Console.WriteLine($"Danske stemmer i alt {danskeTotal}");
Console.WriteLine($"Tyske stemmer i alt {tyskeTotal}");