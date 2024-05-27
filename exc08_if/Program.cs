using System.Globalization;

namespace exc08_if 
{
    class Program 
    {
        static double wage;

        static void Main(string[] args)
        {
            Console.Write("Digite o valor bruto do salário: ");
            wage = double.Parse(Console.ReadLine());
            
            Console.Write("\n");
            CalcIncomeTax();
        }

        static void CalcIncomeTax()
        {
            string defaultMessage = "Valor do imposto de renda: ";
            double percent = 0;
            string defaultErrorMessage = "Valor inválido";

            if (wage <= 2000)
            {
                Console.Write("Isento");
            } else if (wage > 2000 && wage <= 3000)
            {
                percent = 0.08;                                
            } else if (wage > 3000 && wage <= 4500)
            {
                percent = 0.18;                                
            } else if (wage > 4500)
            {
                percent = 0.28;             
            } else if(wage < 0)
            {
                Console.Write(defaultErrorMessage);
            }

            double result = wage * percent;

            Console.Write(defaultMessage + result.ToString("C", CultureInfo.CurrentCulture));
        }
    }
}