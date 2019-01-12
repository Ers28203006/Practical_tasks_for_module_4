using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double nominalBanknotes;
            int amountBanknotes;

            Console.Write("Введите номинал купюр: ");
            nominalBanknotes = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Введите количество купюр номинала: ");
            amountBanknotes = int.Parse(Console.ReadLine());

            Money money=new Money(nominalBanknotes, amountBanknotes);

            double costOfGoods;

            Console.WriteLine();
            Console.Write("Введите сколько стоит товар: ");
            costOfGoods = double.Parse(Console.ReadLine());

            money.IsThereNoughMoney(costOfGoods);

            money.HowMuchToBuy(costOfGoods);

            Console.ReadLine();
        }
    }
}
