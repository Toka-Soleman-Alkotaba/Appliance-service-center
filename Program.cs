
    public abstract void StartMaintenance();
    public abstract void CompleteMaintenance();
}

// 3. فئة الغسالة - الوراثة
public class WashingMachine : Appliance
{
    private bool needsDrumRepair;

    public WashingMachine(string applianceId, string customerName,
                          string status, decimal baseCost,
                          bool needsDrumRepair)
        : base(applianceId, customerName, status, baseCost)
    {
        this.needsDrumRepair = needsDrumRepair;
    }

    // إعادة تعريف دالة حساب التكلفة
    public override decimal CalculateRepairCost()
    {
        return needsDrumRepair
            ? BaseCost + 150m
            : BaseCost + 50m;
    }

    public override void StartMaintenance()
    {
        Console.WriteLine($"بدأت صيانة الغسالة: {ApplianceId}");
        Status = "قيد الصيانة";
    }

    public override void CompleteMaintenance()
    {
        Console.WriteLine("اكتملت صيانة الغسالة.");
        Status = "تم الإصلاح";
    }
}

// 4. فئة الثلاجة - الوراثة
public class Refrigerator : Appliance
{
    private bool gasLeak;

    public Refrigerator(string applianceId, string customerName,
                        string status, decimal baseCost, bool gasLeak)
        : base(applianceId, customerName, status, baseCost)
    {
        this.gasLeak = gasLeak;
    }

    public override decimal CalculateRepairCost()
    {
        return gasLeak
            ? BaseCost + 200m
            : BaseCost + 70m;
    }

    public override void StartMaintenance()
    {
        Console.WriteLine($"بدأت صيانة الثلاجة: {ApplianceId}");
        Status = "قيد الصيانة";
    }

    public override void CompleteMaintenance()
    {
        Console.WriteLine("اكتملت صيانة الثلاجة.");
        Status = "تم الإصلاح";
    }
}

// 5. فئة المكيف - الوراثة
public class AirConditioner : Appliance
{
    private bool compressorIssue;

    public AirConditioner(string applianceId, string customerName,
                          string status, decimal baseCost,
                          bool compressorIssue)
        : base(applianceId, customerName, status, baseCost)
    {
        this.compressorIssue = compressorIssue;
    }

    public override decimal CalculateRepairCost()
    {
        return compressorIssue
            ? BaseCost + 300m
            : BaseCost + 100m;
    }

    public override void StartMaintenance()
    {
        Console.WriteLine($"بدأت صيانة المكيف: {ApplianceId}");
        Status = "قيد الصيانة";
    }

    public override void CompleteMaintenance()
    {
        Console.WriteLine("اكتملت صيانة المكيف.");
        Status = "تم الإصلاح";
    }
}

// 6. البرنامج الرئيسي
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // إنشاء قائمة رئيسية تحتوي على أنواع مختلفة من الأجهزة
        List<Appliance> workshopList = new List<Appliance>
        {
            new WashingMachine(
                "WM-101", "أحمد محمد", "جديد", 500m, true),

            new Refrigerator(
                "REF-202", "فاطمة علي", "جديد", 800m, false),

            new AirConditioner(
                "AC-303", "خالد عمر", "جديد", 1000m, true)
        };

        decimal totalCost = 0m;

        // تطبيق تعدد الأشكال لمعالجة جميع الأجهزة
        foreach (Appliance app in workshopList)
        {
            Console.WriteLine("-----------------------------------");

            app.StartMaintenance();

            app.DisplayDetails();

            decimal repairCost = app.CalculateRepairCost();

            Console.WriteLine(
                $"تكلفة الإصلاح: {repairCost:N0} ليرة سورية جديدة");

            totalCost += repairCost;

            app.CompleteMaintenance();

            Console.WriteLine($"الحالة النهائية: {app.Status}");
        }

        Console.WriteLine("-----------------------------------");

        Console.WriteLine(
            $"إجمالي تكاليف الصيانة: {totalCost:N0} ليرة سورية جديدة");

        Console.WriteLine("-----------------------------------");

        Console.WriteLine("اضغط أي مفتاح للخروج...");
        Console.ReadKey();
    }
}