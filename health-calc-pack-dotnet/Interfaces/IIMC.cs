namespace health_calc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        double Calc(Double height, Double weight);
        string GetIMCCategory(double IMC);
        bool IsValidData(double height, double weight);
    }
}
