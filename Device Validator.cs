using System;

namespace DeviceEventManager
{
    // 1. إنشاء فئة ثابتة (Static Class) للتحقق والأدوات
    public static class DeviceValidator
    {
        // خاصية ثابتة لحساب أو تتبع إجمالي عدد الأجهزة التي تمت معالجتها
        public static int TotalProcessedDevices { get; set; } = 0;

        // دالة ثابتة للتحقق من صحة الرقم التسلسلي (مثلاً يجب ألا يكون فارغاً وطوله مناسب)
        public static bool IsValidSerialNumber(string serialNumber)
        {
            if (string.IsNullOrWhiteSpace(serialNumber))
            {
                return false;
            }
            // شريطة أن يكون طول الرقم التسلسلي 5 خانات مثلاً كمثال تحقق
            return serialNumber.Length >= 5;
        }

        // دالة ثابتة للتحقق من صحة التاريخ (مثلاً التأكد أنه ليس تاريخاً مستقبلياً)
        public static bool IsValidDate(DateTime maintenanceDate)
        {
            return maintenanceDate <= DateTime.Now;
        }
    }
}