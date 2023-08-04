public class Factory : Organization
{
    public string Industry { get; set; }
    public Factory(string name, string address, string industry) : base(name, address)
    {
        Industry = industry;
    }
    public override string GetInfo()
    {
        return base.GetInfo() + $", Отрасль: {Industry}";
    }
}