using GuessTheNumber;

int rangeStart;
int rangeEnd = 0;
int userValue;




// Easier to understand the entire logic if in first place is the code that calls the main logic, and at the bottom the methods that are called
static bool ValidateRangeLimitValues(int rangeStart, int rangeEnd)
{
    return rangeStart <= rangeEnd;
}

string ReadValue(string valueDescription)
{
    Console.WriteLine(valueDescription);
    return Console.ReadLine();
}

static bool ValidateEquality(int randomNumber, int userValue)
{
    return randomNumber == userValue;
}

bool isInRange(int userValue)
{
    return (userValue <= rangeEnd) && (userValue >= rangeStart);
}

bool ValidateInequality(int randomNumber)
{
    return userValue > randomNumber;
}



bool isRangeValid;
// The following while block worths to be extracted in another method
do
{
    isRangeValid = true;

    var rangeStartString = ReadValue("Inceputul intervalului:");

    var rangeEndString = ReadValue("Sfarsitul intervalului:");

    if (!int.TryParse(rangeStartString, out rangeStart)
       || !int.TryParse(rangeEndString, out rangeEnd)
       || !ValidateRangeLimitValues(rangeStart, rangeEnd))
    {
        isRangeValid = false;
        Console.WriteLine("Interval introdus gresit! Incearca din nou.");
    }
} while (isRangeValid == false);



Random random = new Random();
int randomNumber = random.Next(rangeStart, rangeEnd);



var isGuessed = false;
// The following while block worths to be extracted in another method
do
{
    var userValueString = ReadValue("Introduceti valoarea:");

    if (!Int32.TryParse(userValueString, out userValue))
    {
        // Message could be improved
        Console.WriteLine("Valoarea " + userValueString + " este caracter!");
    }
    else
    {
        // Nice validation case
        if (!isInRange(userValue))
        {
            Console.WriteLine("Valoarea " + userValue + " nu se afla in interval!");
        }
        else
        {
            if (ValidateEquality(randomNumber, userValue))
            {
                isGuessed = true;
                Console.WriteLine("Valoarea " + userValue + " este corecta!");
                
            }
            else
            {
                if (ValidateInequality(randomNumber))
                {
                    Console.WriteLine("Valoarea " + userValue + " este prea mare!");
                }
                else
                {
                    Console.WriteLine("Valoarea " + userValue + " este prea mica!");
                }
            }
        }
    }
} while (!isGuessed);
