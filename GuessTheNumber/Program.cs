// variable names could be improved
int inc;
int fin;
bool ok,ok1,ok2;

// nice to cover these validations
// the do while block is hard to understand what it does on a first look
do
{
    ok = true;
    string i = Console.ReadLine();
    //int inc;
    ok1=Int32.TryParse(i, out inc);

    string f = Console.ReadLine();
    //int fin;
    ok2=Int32.TryParse(f, out fin);

    if (inc >= fin || ok1==false || ok2==false)
    {
        ok = false;
        Console.WriteLine("Interval introdus gresit! Incearca din nou.");
    }
} while (ok == false);

// a bit hard to understand what it does on a first look
Random r = new Random();
int nr = new();
nr = r.Next(inc, fin);
//Console.WriteLine(nr);

bool guess = false;
// the do while block is hard to understand what it does on a first look
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
    if (user > fin || user < inc && usr==false)
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