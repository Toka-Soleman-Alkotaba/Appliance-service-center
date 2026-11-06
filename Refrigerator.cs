using System;

namespace maintenancesystem
{
    // Inheritance: توريث من الفئة الأساسية Device
    public class Refrigerator : Device
    {
        public bool HasFreezer { get; set; }

        // المُنشئ (Constructor)
        public Refrigerator(string serialNumber, double baseCost, bool hasFreezer)
            : base(serialNumber, "ثلاجة", baseCost)
        {
            HasFreezer = hasFreezer;
        }

        // Polymorphism (تعدد الأشكال): تطبيق الدالة المجردة بطريقة خاصة بالثلاجة
        public override double CalculateRepairCost()
        {
            double totalCost = BaseCost;
            if (HasFreezer)
            {
                totalCost += 50; // تكلفة إضافية لصيانة الفريزر
            }
            return totalCost;
        }

        public override void StartMaintenance()
        {
            base.StartMaintenance();
            Console.WriteLine("جاري فحص نظام التبريد وغاز الثلاجة...");
        }
    }
}