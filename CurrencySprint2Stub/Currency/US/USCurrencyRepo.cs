using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.US
{
    public class USCurrencyRepo : CurrencyRepo
    {

        public ICurrencyRepo CreateChange(decimal amount)
        {
            decimal leftOver = amount;
            USCurrencyRepo changeRepo = new USCurrencyRepo();

            while (leftOver > 0)
            {
                decimal change = DetermineChange(leftOver, changeRepo);
                leftOver -= change;
            }

            return changeRepo;
        }

        public decimal DetermineChange(decimal amount, USCurrencyRepo repo)
        {
            decimal leftOver = amount;
            CurrencyRepo changeRepo = new CurrencyRepo();

            if (leftOver < 0.05M)
            {
                for (int i = 0; i < leftOver * 100; i++)
                {
                    changeRepo.AddCoin(new Penny());
                }
            }

            if (leftOver > 1)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new DollarCoin());
                }

                leftOver -= timesint;
            }

            if (leftOver > 0.5M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.5m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new HalfDollar());
                }
                leftOver -= timesint * 0.5m;
            }


            if (leftOver > 0.25M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.25m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new Quarter());
                }
                leftOver -= timesint * 0.25m;
            }

            if (leftOver > 0.1M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.1m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new Dime());
                }
                leftOver -= timesint * 0.1m;
            }

            if (leftOver > 0.05M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.05m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new Nickel());
                }
                leftOver -= timesint * 0.05m;
            }

            if (leftOver > 0.01M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.01m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new Penny());
                }
                leftOver -= timesint * 0.01m;
            }

            return leftOver;
        }

        public USCurrencyRepo CreateChange(decimal amountTendered, double totalCost)
        {
            return null;

        }
    }
}
