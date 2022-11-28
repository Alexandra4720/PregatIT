using GuessTheNumber;

int userValue;

RangeLimitsReader rangeLimitsReader= new();


string ReadValue(string valueDescription)
{
    Console.WriteLine(valueDescription);
    return Console.ReadLine();
}

static bool ValidateEquality(int randomNumber, int userValue)
{
    return randomNumber == userValue;
}

bool IsInRange(int userValue)
{
    return (userValue <= rangeLimitsReader.GetRangeEnd()) 
        && (userValue >= rangeLimitsReader.GetRangeStart());
}

bool ValidateInequality(int randomNumber)
{
    return userValue > randomNumber;
}

Random random = new Random();
int randomNumber = random.Next(rangeLimitsReader.GetRangeStart(), rangeLimitsReader.GetRangeEnd());



var isGuessed = false;
do
{
    var userValueString = ReadValue("Introduceti valoarea:");

    if (!Int32.TryParse(userValueString, out userValue))
    {
        Console.WriteLine("Valoarea " + userValueString + " este caracter!");
    }
    else
    {
        if (!IsInRange(userValue))
        {
            Console.WriteLine("Valoarea " + userValue + " nu se afla in interval!");
        }
        else
        {
            if (ValidateEquality(randomNumber, userValue))
            {
                isGuessed = true;
                Console.WriteLine("Valoarea " + userValue + " este corecta!");
                Console.ReadLine();

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

