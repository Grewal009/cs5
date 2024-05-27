namespace ConsoleApp9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"sum of a + b: {Sum(10,35)}");
        Program.PrintMsg();
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

}