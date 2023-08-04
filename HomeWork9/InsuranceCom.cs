public class InsuranceCompany : Organization
{
    public string InsuranceType { get; set; }
    
    public InsuranceCompany(string name, string address, string insuranceType) : base(name, address)
    {
        InsuranceType = insuranceType;
    }
    public override string GetInfo()
    {
        return base.GetInfo() + $", Вид страхования: {InsuranceType}";
    }
}