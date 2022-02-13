using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency.US;

namespace Currency
{
    [Serializable]
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public string About()
        {
            string message = "";

            foreach (Coin c in Coins)
            {
                message += c.About();
            }

            return message;
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public static ICurrencyRepo CreateChange(decimal amount)
        {
            decimal leftOver = amount;
            CurrencyRepo changeRepo = new CurrencyRepo();

            if (leftOver < 0.05M)
            {
                int times = Convert.ToInt32(Math.Floor(leftOver * 10));
                for (int i = 0; i < times; i++)
                {
                    changeRepo.AddCoin(new Penny());
                }
            }

            if (leftOver >= 1)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new DollarCoin());
                }

                leftOver -= timesint;
            }

            if (leftOver >= 0.5M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.5m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new HalfDollar());
                }
                leftOver -= timesint * 0.5m;
            }


            if (leftOver >= 0.25M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.25m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new Quarter());
                }
                leftOver -= timesint * 0.25m;
            }

            if (leftOver >= 0.1M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.1m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new Dime());
                }
                leftOver -= timesint * 0.1m;
            }

            if (leftOver >= 0.05M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.05m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new Nickel());
                }
                leftOver -= timesint * 0.05m;
            }

            if (leftOver >= 0.01M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 0.01m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new Penny());
                }
                leftOver -= timesint * 0.01m;
            }

            return changeRepo;
        }

        public ICurrencyRepo CreateChange(decimal amountTendered, double totalCost)
        {
            return null;

        }

        public int GetCoinCount()
        {
            int count = Coins.Count();

            return count;
        }

        public ICurrencyRepo MakeChange(decimal amount)
        {
            ICurrencyRepo changeRepo = CreateChange(amount);
            return changeRepo;
        }

        public ICurrencyRepo MakeChange(decimal amountTendered, decimal totalCost)
        {
            return null;
        }

        public ICoin RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
            return c;
        }

        public decimal TotalValue()
        {
            decimal amount = 0;

            foreach (ICoin c in Coins)
            {
                amount += c.MonetaryValue;
            }

            return amount;
        }
    }
}
