int rangeStart;
int rangeEnd=0;

static bool ValidateRangeLimitValues(int rangeStart, int rangeEnd)
{
    return rangeStart >= rangeEnd;
}



string ReadValue(string valueDescription)
{
    Console.WriteLine(valueDescription);
    return Console.ReadLine();
}



bool isRangeValid;
do
{
    isRangeValid = true;

    var rangeStartString = ReadValue("Inceputul intervalului:");

    var rangeEndString = ReadValue("Sfarsitul intervalului:");

    if (!int.TryParse(rangeStartString,out rangeStart)
       || !int.TryParse(rangeEndString, out rangeEnd)
       || !ValidateRangeLimitValues(rangeStart, rangeEnd))
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
    var usr = Int32.TryParse(u, out user);

    if (usr == false)
    {
        Console.WriteLine("Valoarea " + u + " este caracter!");
        continue;
    }
    else
    if (user > rangeEnd || user < rangeStart && usr == false)
        Console.WriteLine("Valoarea " + user + " nu se afla in interval!");
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