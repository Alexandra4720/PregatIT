int rangeStart;

static bool ReadIntValue(out int rangeStart, string intValueDescription)
{
    Console.WriteLine(intValueDescription);
    string i = Console.ReadLine();
    return Int32.TryParse(i, out rangeStart);
}

int rangeEnd;
bool isRangeValid;
do
{
    isRangeValid = true;

    var ok1=ReadIntValue(out rangeStart, "Inceputul intervalului:");

    var ok2 = ReadIntValue(out rangeEnd, "Sfarsitul intervalului:");

    if (rangeStart >= rangeEnd || ok1 == false || ok2 == false)
    {
        isRangeValid = false;
        Console.WriteLine("Interval introdus gresit! Incearca din nou.");
    }
} while (isRangeValid == false);

Random r = new Random();
int nr = new();
nr = r.Next(rangeStart, rangeEnd);

bool guess = false;
do
{
    string u = Console.ReadLine();
    int user;
    var usr=Int32.TryParse(u, out user);

    if (usr == false)
    {
        Console.WriteLine("Valoarea " + u + " este caracter!");
        continue;
    }
    else
    if (user > rangeEnd || user < rangeStart && usr==false)
        Console.WriteLine("Valoarea "+user+" nu se afla in interval!");
    else
        if (nr == user)
        {
            guess = true;
            Console.WriteLine("Valoarea " + user + " este corect!");
        }
        else
            if (user > nr)
                Console.WriteLine("Valoarea " + user + " este prea mare!");
            else
                Console.WriteLine("Valoarea " + user + " este prea mic!");
} while (guess == false);