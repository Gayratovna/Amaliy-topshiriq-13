using Amaliy_topshiriq_13;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        AviyaChiptaTizimi aviaChiptaTizimi = new AviyaChiptaTizimi();

        // 1. Barcha buyurtmalarni daraxt ko’rinishida saqlash
        aviaChiptaTizimi.BuyurtmaQoshish("Toshkent", "UZ123", "John Doe", new DateTime(2024, 1, 20));
        aviaChiptaTizimi.BuyurtmaQoshish("Samarqand", "UZ456", "Alice Smith", new DateTime(2024, 2, 15));
        aviaChiptaTizimi.BuyurtmaQoshish("Buxoro", "UZ789", "Bob Johnson", new DateTime(2024, 3, 10));

        // 2. Buyurtma qo’shish va mavjud buyurtmani o’chirish
        aviaChiptaTizimi.BuyurtmaOchirish("UZ456");

        // Buyurtmalarni chiqarish
        aviaChiptaTizimi.DaraxtChiqarish();
    }
}