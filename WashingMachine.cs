using System;

namespace maintenancesystem
{
    public abstract class Device : IDeviceOperations
    {
        // Encapsulation: الحقول الخاصة بالبيانات
        private string serialNumber;
        private string deviceType;
        private double baseCost;

        // خصائص للوصول المقيد للبيانات (Properties)
        public string SerialNumber
        {
            get { return serialNumber; }
            init { serialNumber = value; } // للقراءة فقط بعد الإنشاء
        }

        public string DeviceType
        {
            get { return deviceType; }
            set { deviceType = value; }
        }

        public double BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }

        // المُنشئ (Constructor) لتمرير البيانات عند إنشاء الكائن
        protected Device(string serialNumber, string deviceType, double baseCost)
        {
            SerialNumber = serialNumber;
            DeviceType = deviceType;
            BaseCost = baseCost;
        }

        // دالة افتراضية لبدء الصيانة
        public virtual void StartMaintenance()
        {
            Console.WriteLine($"بدء صيانة الجهاز ذو الرقم التسلسلي: {SerialNumber}");
        }

        // دالة مجردة (يجب تطبيقها في الفئات الفرعية لاحقاً)
        public abstract double CalculateRepairCost();
    }
}