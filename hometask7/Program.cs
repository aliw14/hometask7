namespace hometask7;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("ededi daxil et:");
        double number = double.Parse(Console.ReadLine());
        decimal kesr, tam;
        tam = (int)number;
        kesr = (decimal)number - tam;
        number = number * 1000;
        int count = (int)Math.Log10(number);
        decimal reverseNumber = 0;
        int r;
        while (number != 0) 
        {
            r = (int)number % 10;
            number = number / 10;
            reverseNumber += r * (int)Math.Pow(10, count);

            count--;



        }
        reverseNumber = reverseNumber / 1000;
        Console.WriteLine(reverseNumber);
    }
}

