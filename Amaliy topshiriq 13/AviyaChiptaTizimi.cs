using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliy_topshiriq_13
{
    public class AviyaChiptaTizimi
    {
        private List<Buyurtma> buyurtmalar = new List<Buyurtma>();

        public void BuyurtmaQoshish(string borishManzili, string parvozRaqami, string yolovchiIsmi, DateTime parvozQilishSanasi)
        {
            Buyurtma buyurtma = new Buyurtma { BorishManzili = borishManzili, ParvozRaqami = parvozRaqami, YolovchiIsmi = yolovchiIsmi, ParvozQilishSanasi = parvozQilishSanasi };
            buyurtmalar.Add(buyurtma);
        }

        public void BuyurtmaOchirish(string parvozRaqami)
        {
            Buyurtma? buyurtma = buyurtmalar.Find(b => b.ParvozRaqami == parvozRaqami);
            if (buyurtma != null)
            {
                buyurtmalar.Remove(buyurtma);
                Console.WriteLine($"{parvozRaqami} raqamli buyurtma o'chirildi.");
            }
            else
            {
                Console.WriteLine($"{parvozRaqami} raqamli buyurtma topilmadi.");
            }
        }

        public void DaraxtChiqarish()
        {
            foreach (var buyurtma in buyurtmalar)
            {
                Console.WriteLine($"Borish manzili: {buyurtma.BorishManzili}, Parvoz raqami: {buyurtma.ParvozRaqami}, Yolovchi ismi: {buyurtma.YolovchiIsmi}, Parvoz qilish sanasi: {buyurtma.ParvozQilishSanasi.ToShortDateString()}");
            }
        }
    }
}
