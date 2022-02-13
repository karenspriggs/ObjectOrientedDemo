using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Japan
{
    public class YenCurrencyRepo : CurrencyRepo
    {
        public static ICurrencyRepo CreateChange(decimal amount)
        {
            decimal leftOver = amount;
            YenCurrencyRepo changeRepo = new YenCurrencyRepo();

            while (leftOver > 0)
            {
                decimal change = DetermineChange(leftOver, changeRepo);
                leftOver -= change;
            }

            return changeRepo;
        }

        public static decimal DetermineChange(decimal amount, YenCurrencyRepo repo)
        {
            decimal leftOver = amount;
            CurrencyRepo changeRepo = new CurrencyRepo();

            if (leftOver < 5M)
            {
                for (int i = 0; i < leftOver; i++)
                {
                    changeRepo.AddCoin(new OneYenCoin());
                }
            }

            if (leftOver > 500m)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 500m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new FiveHundredYenCoin());
                }

                leftOver -= timesint * 500m;
            }

            if (leftOver > 100M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 100m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new HundredYenCoin());
                }
                leftOver -= timesint * 100m;
            }


            if (leftOver > 50M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 50m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new FiftyYenCoin());
                }
                leftOver -= timesint * 50m;
            }

            if (leftOver > 10M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 10m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new TenYenCoin());
                }
                leftOver -= timesint * 10m;
            }

            if (leftOver > 5M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver / 5m));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new FiveYenCoin());
                }
                leftOver -= timesint * 5m;
            }

            if (leftOver > 1M)
            {
                int timesint = Convert.ToInt32(Math.Floor(leftOver));

                for (int i = 0; i < timesint; i++)
                {
                    changeRepo.AddCoin(new OneYenCoin());
                }
                leftOver -= timesint;
            }

            return leftOver;
        }
        public ICurrencyRepo MakeChange(decimal amount)
        {
            ICurrencyRepo changeRepo = CreateChange(amount);
            return changeRepo;
        }
    }
}
