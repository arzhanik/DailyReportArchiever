using DailyReportArchiever;

class Program
{
    public static void Main()
    {
        InputOutputClass Instance = new InputOutputClass("""
                                                         Hi there,
                                                         I'm writing this from future!
                                                         """);
        Instance.CreateFileAndWrite();
        Console.WriteLine(Instance.ReadFromFile());
    }
}