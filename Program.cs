namespace Lab02_RecursivoFibonacci;
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;

        int n, k;

        do
        {
            Console.WriteLine("Introduzca el número de términos: ");
            n = int.Parse(Console.ReadLine()!);
        } while (n <= 1);
        
        Console.WriteLine("\tSerie números de fibonacci recursivo: ");
        var watch = new System.Diagnostics.Stopwatch(); 
        watch.Start();
        for (k = 0; k < n; k++)
        {
            Console.WriteLine(FibonacciRecursivo(k));
        }
        watch.Stop();
        Console.WriteLine($"\nTiempo de ejecución recursivo: {watch.ElapsedMilliseconds} ms");
        Console.WriteLine("\n\tSerie números de fibonacci iterativo: ");
        var watch1 = new System.Diagnostics.Stopwatch(); 
        watch1.Start();
        FibonacciIterativo(n);
        watch1.Stop();
        Console.WriteLine($"\nTiempo de ejecución iterativo: {watch1.ElapsedMilliseconds} ms");



        static long FibonacciRecursivo(int n)
        {
            if (n < 2) { return n; }
            else { return FibonacciRecursivo(n - 2) + FibonacciRecursivo(n - 1); }
            
        }

        static void FibonacciIterativo(int n)
        {
            int i; long ant1, ant2;
            ant1 = ant2 = 1;
            Console.WriteLine("0 \n1 \n1");
            for (i = 1; i < n - 2; i++)
            {
                int actual = (int)(ant1 + ant2);
                Console.WriteLine(actual);
                ant2 = ant1;
                ant1 = actual;
                
            }
        }


    }
}
