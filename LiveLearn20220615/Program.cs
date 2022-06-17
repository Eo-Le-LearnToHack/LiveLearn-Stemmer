using LiveLearn20220615;
MethodValidation myMethodValidation = new();

Console.Write("Indtast hvor stort dit array skal være:\t");
int indtastetArrayStr;
string indtastetArrayStrTest = Console.ReadLine();
indtastetArrayStr = myMethodValidation.IsAnInt(indtastetArrayStrTest);
Område[] stemmer = new Område[indtastetArrayStr];
Console.WriteLine();
for (int i = 0; i < stemmer.Length; i++)
{
    Console.Write($"Navngiv dit array for område nr. {i+1}:\t");
    string områdeNavn = Console.ReadLine();
    stemmer[i] = new Område(områdeNavn);
    Console.WriteLine();
}

//Område[] stemmer = { new ("Område A"), new ("Område B"), new ("Område C"), new ("Område D"), new ("Område E") };


int danskeTotal = 0;
int tyskeTotal = 0;
foreach(Område område in stemmer)
{
    Console.Write($"Indtast antal danske stemmer i {område.Navn}:\t\t");
    int indtastetDansk;
    string indtastetDanskTest = Console.ReadLine();
    indtastetDansk = myMethodValidation.IsAnInt(indtastetDanskTest);
    område.DanskeStemmer = indtastetDansk;
    danskeTotal += område.DanskeStemmer;

    Console.Write($"Indtast antal tyske stemmer i {område.Navn}:\t\t\t");
    int indtastetTysk;
    string indtastetTyskTest = Console.ReadLine();
    indtastetTysk = myMethodValidation.IsAnInt(indtastetTyskTest);
    område.TyskeStemmer = indtastetTysk;
    tyskeTotal += område.TyskeStemmer;

    Console.WriteLine($"Resultater \t\t\t\t\t\t= {område.Resultat()}");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine($"Danske stemmer i alt {danskeTotal}");
Console.WriteLine($"Tyske stemmer i alt {tyskeTotal}");
Console.ReadLine();