using System;

namespace maintenancesystem
{
    public class WashingMachine : Device
    {
        public int DrumCapacity { get; set; } // سعة الحلة

        public WashingMachine(string serialNumber, double baseCost, int drumCapacity)
            : base(serialNumber, "غسالة", baseCost)
        {
            DrumCapacity = drumCapacity;
        }

        public override double CalculateRepairCost()
        {
            return BaseCost + (DrumCapacity * 2); // تكلفة إضافية حسب السعة
        }

        public override void StartMaintenance()
        {
            base.StartMaintenance();
            Console.WriteLine("جاري فحص مضخة الماء والمحرك...");
        }
    }
}