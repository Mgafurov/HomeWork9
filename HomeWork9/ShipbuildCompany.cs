public class ShipbuildCompany : Organization
{
    public int EmpolyeesCount { get; set; }
    public ShipbuildCompany(string name, string address, int empolyeesCount) : base(name, address)
    {
        EmpolyeesCount = empolyeesCount;
    }
    public override string GetInfo()
    {
        return base.GetInfo() + $", Количество сотрудников: {EmpolyeesCount}";
    }
}
