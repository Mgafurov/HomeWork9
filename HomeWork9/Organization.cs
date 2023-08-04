public class Organization
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Organization(string name, string address)
    {
        Name = name;
        Address = address;
    }
    public virtual string GetInfo()
    {
        return $"Организация {Name}, Адрес: {Address}";
    }
}