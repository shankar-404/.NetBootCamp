namespace Assignment4;

public class TempService
{
    public double CTF(double Temperature)
    {
        return Math.Round(1.8 * (Temperature) + 32, 2);
    }

    public double FTC(double Temperature)
    {
        return Math.Round((Temperature - 32) / 1.8, 2);
    }

    public static void Main()
    {
        TempService TempConvert = new TempService();
        Console.WriteLine(TempConvert.CTF(50));
        Console.WriteLine(TempConvert.FTC(52.8));
    }
}