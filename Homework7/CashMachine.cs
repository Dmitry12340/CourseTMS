﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class CashMachine
    {
        int Nominalbanknote20 = 20;
        int Nominalbanknote50 = 50;
        int Nominalbanknote100 = 100;

        public int Banknote20 { get; private set; }
        public int Banknote50 { get; private set; }
        public int Banknote100 { get; private set; }
        public CashMachine(int banknote20, int banknote50, int banknote100)
        {
            if (banknote20 < 0)
            {
                Banknote20 = 0;
            }
            else
            {
                Banknote20 = banknote20;
            }

            if (banknote50 < 0)
            {
                Banknote50 = 0;
            }
            else
            {
                Banknote50 = banknote50;
            }

            if (banknote100 < 0)
            {
                Banknote100 = 0;
            }
            else
            {
                Banknote100 = banknote100;
            }
        }

        public void AddBanknoteToCashMachine(int banknote20, int banknote50, int banknote100)
        {
            if (banknote20 > 0)
            {
                Banknote20 += banknote20;
            }
            if (banknote50 > 0)
            {
                Banknote50 += banknote50;
            }
            if (banknote100 > 0)
            {
                Banknote100 += banknote100;
            }
        }

        public bool WithdrawCash(int sum)
        {
            int remainderSum = 0;
            bool OperationCompleted = false;

            int count100 = 0;
            int count50 = 0;
            int count20 = 0;

            count100 = sum / Nominalbanknote100;
            if(count100 > Banknote100)
            {
                count100 = Banknote100;
                remainderSum = sum - (Nominalbanknote100 * count100);
                OperationCompleted = false;
            }
            else
            {
                remainderSum = sum % Nominalbanknote100;
            }




            if (count100 > 0 && remainderSum == 0)
            {
                OperationCompleted = true;
            }
            else
            {
                count50 = remainderSum / Nominalbanknote50;

                if (count50 > Banknote50)
                {
                    count50 = Banknote50;
                    remainderSum = remainderSum - (Nominalbanknote50 * count50);
                }
                else
                {
                    remainderSum = remainderSum % Nominalbanknote50;
                }

                if (count50 > 0 && remainderSum == 0)
                {
                    OperationCompleted = true;
                }
                else
                {
                    count20 = remainderSum / Nominalbanknote20;
                    if (count20 > Banknote20)
                    {
                        count20 = Banknote20;
                        remainderSum = remainderSum - (Nominalbanknote20 * count50);
                    }
                    else
                    {
                        remainderSum = remainderSum % Nominalbanknote20;
                    }

                    if (count20 > 0 && remainderSum == 0)
                    {
                        OperationCompleted = true;
                    }
                    else
                    {
                        OperationCompleted = false;
                    }
                }
            }

            if (OperationCompleted)
            {
                Console.WriteLine($"Cash Withdrawal\nBanknote100:{count100}\nBanknote50:{count50}\nBanknote20:{count20}\n");
                Banknote20 -= count20;
                Banknote50 -= count50;
                Banknote100 -= count100;
            }
            return OperationCompleted;
        }
    }
}
