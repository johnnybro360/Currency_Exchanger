using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Exchanger
{
    class CurrencyManager
    {
        public int DollarQty { get; set; }
        public int FiftyCentQty { get; set; }
        public int TenCentQty { get; set; }
        public int FiveCentQty { get; set; }

        public CurrencyManager()
        {
            DollarQty = 1;
            FiftyCentQty = 1;
            TenCentQty = 1;
            FiveCentQty = 1;
        }

        public double TotalCash ()
        {
            return Convert.ToDouble(DollarQty + (FiftyCentQty * 0.50) + (TenCentQty * 0.10) + (FiveCentQty * 0.05));
        }
        public void AddCurrency(string currency)
        {
            switch (currency)
            {
                case "dollar":
                    DollarQty += 1;
                    break;

                case "fiftyCent":
                    FiftyCentQty += 1;
                    break;

                case "tenCent":
                    TenCentQty += 1;
                    break;

                case "fiveCent":
                    FiveCentQty += 1;
                    break;
            }
        }

        public void TakeCurrency(string currency)
        {
            switch (currency)
            {
                case "dollar":
                    DollarQty -= 1;
                    break;

                case "fiftyCent":
                    FiftyCentQty -= 1;
                    break;

                case "tenCent":
                    TenCentQty -= 1;
                    break;

                case "fiveCent":
                    FiveCentQty -= 1;
                    break;
            }
        }

        public void DollarTransferDown()
        {
            if (DollarQty > 0)
            {
                DollarQty -= 1;
                FiftyCentQty += 2; 
            }
            else { return; }
        }

        public void FiftyTransfer(string direction)
        {
            if (direction == "up" && FiftyCentQty >= 2)
            {
                FiftyCentQty -= 2;
                DollarQty += 1;
            }
            if (direction == "down" && FiftyCentQty >= 1)
            {
                FiftyCentQty -= 1;
                TenCentQty += 5;
            }
            else { return; }
        }


        public void TenTransfer(string direction)
        {
            if (direction == "up" && TenCentQty >= 5)
            {
                TenCentQty -= 5;
                FiftyCentQty += 1;
            }
            if (direction == "down" && TenCentQty >= 1)
            {
                TenCentQty -= 1;
                FiveCentQty += 2;
            }
            else { return; }
        }

        public void FiveTransferUp()
        {
            if (FiveCentQty >= 2)
            {
                FiveCentQty -= 2;
                TenCentQty += 1;
            }
            else { return; }
        }
    }
}
