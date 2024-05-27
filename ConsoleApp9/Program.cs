namespace ConsoleApp9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"sum of a + b: {Sum(10,35)}");
        Program.PrintMsg();
        Console.WriteLine($"both values equal: {IsValuesEqual(10,10)}");
        Console.WriteLine($"result sum or mul: {ReturnSumOrMul(123,124)}");
        Console.WriteLine($"Is value of a, b or a+b equal to 30: {IsValueEqualTo30(30,202)}");

        Console.WriteLine("\n\t***** Random Hobby Generator *****");
        string[] hobbies = ["reading books","listening to music","watching movies","playing football","cooking"];
        while (true)
        {
            int randomHobby = RandomHobby();
            DisplayHobby(hobbies[randomHobby] );
        }
        
    }
    
    //Lag en metode som tar inn og returnerer summen av to tall
    public static int Sum(int a,int b)
    {
        return a + b;
    }
    
    //Lag en metode som skal printe setningen "Denne metoden returnerer ingenting" til konsollen
    public static void PrintMsg()
    {
        Console.WriteLine("Denne metoden returnerer ingenting");
    }
    
    //Lag en metode som tar imot to tall og returnerer true dersom tallene er like
    public static bool IsValuesEqual(int a, int b)
    {
        if (a == b)
        {
            return true;
        }
        return false;
    }
    
    //Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike
    // og returnerer tallene multiplisert med hverandre dersom de er like
    public static int ReturnSumOrMul(int a, int b)
    {
        if (a == b) 
        {
            return a * b;
        }
        else
        {
            return a + b;
        }
    }
    
    //Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
    // skal metoden returnere true. Ellers returnerer metoden false
    public static bool IsValueEqualTo30(int a, int b)
    {
        if (a == 30 || b == 30 || a + b == 30)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    //lag en konsollapplikasjon som tildeler en person en random hobby
    public static int RandomHobby()
    {
        Random random = new Random();
        return random.Next(0, 5);
    }

    public static void DisplayHobby(string hobby)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"{name} try this hobby: {hobby}");
    }


}