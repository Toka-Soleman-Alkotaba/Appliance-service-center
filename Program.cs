using System;
using System.Collections.Generic;

namespace maintenancesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== نظام إدارة صيانة الأجهزة المنزلية ===");

            // 2. استخدام قائمة لمعالجة الكائنات بشكل متعدد الأشكال (Polymorphism)
            List<Device> devices = new List<Device>
            {
                new Refrigerator("REF-101", 100, true),
                new WashingMachine("WM-202", 120, 8)
            };

            foreach (var device in devices)
            {
                Console.WriteLine("\n--------------------------------");
                device.StartMaintenance();
                double cost = device.CalculateRepairCost();
                Console.WriteLine($"التكلفة الإجمالية للإصلاح: {cost} ليرة");

                // تجربة الحدث (Event)
                device.OnRepairCompleted += (message) => {
                    Console.WriteLine($"[إشعار الحدث]: {message}");
                };

                device.CompleteRepair();
            }

            Console.WriteLine("\nاضغط على أي مفتاح للخروج...");
            Console.ReadKey();
        }
    }
}