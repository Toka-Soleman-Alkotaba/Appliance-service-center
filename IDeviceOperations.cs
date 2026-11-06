namespace maintenancesystem
{
    public interface IDeviceOperations
    {
        void StartMaintenance();
        double CalculateRepairCost();
    }
}