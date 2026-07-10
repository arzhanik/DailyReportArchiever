namespace DailyReportArchiever;

using System;
using System.IO;

public class InputOutputClass
{
    public string Content { get; set; }

    public InputOutputClass(string content)
    {
        Content = content;
    }

    public void CreateFileAndWrite()
    {
        try
        {
            File.WriteAllText("/home/arzhanik/RiderProjects/DailyReportArchiever/DailyReportArchiever/log.txt", Content);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex}");
        }
    }

    public string ReadFromFile()
    {
        string Text = "";
        try
        {
            Text = File.ReadAllText("/home/arzhanik/RiderProjects/DailyReportArchiever/DailyReportArchiever/log.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex}");
        }

        return Text;
    }
}