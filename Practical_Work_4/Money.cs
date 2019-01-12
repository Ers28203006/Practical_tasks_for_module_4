using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_4
{
    class Money
    {
        /* Поля:
                * Номинал купюры
                * Количество купюр */

        private double _nominalBanknotes;
        private int _amountBanknotes;
        private double _costOfGoods;


        /* Конструктор */

        public Money(double nominalBanknotes, int amountBanknotes)
        {
            _nominalBanknotes = nominalBanknotes;
            _amountBanknotes = amountBanknotes;
            _costOfGoods = _amountBanknotes * _nominalBanknotes;
        }

        /* Свойства */

        public double GetNominalBanknotes()
        {
            return _nominalBanknotes;
        }

        public void SetNominalBanknotes(double nominalBanknotes)
        {
            _nominalBanknotes = nominalBanknotes;
        }

        public int GetAmountBanknotes()
        {
            return _amountBanknotes;
        }

        public void SetAmountBanknotes(int amountBanknotes)
        {
            _amountBanknotes = amountBanknotes;
        }

        /* Методы */

        public void ShowBankotes()
        {
            Console.Write("Номинал купюр: ");
            Console.WriteLine(_nominalBanknotes);
            Console.Write("Количестов купюр: ");
            Console.WriteLine(_amountBanknotes);
        }

        public void IsThereNoughMoney(double costOfGoods)
        {
            
            if (costOfGoods > _costOfGoods)
            {
                Console.WriteLine("Денежных средств на покупку товара не достаточно.");
            }

            else
            {
                Console.WriteLine("Денежных средств на покупку товара достаточно");
            }
        }

        public void HowMuchToBuy(double costOfGoods)
        {
            int quantityOfGoods = (int)(_costOfGoods / costOfGoods);
            Console.Write("На сумму имеющуюся в кошельке можно купить ");
            Console.Write(quantityOfGoods);
            Console.WriteLine(" штук товара");
        }


    }
}
