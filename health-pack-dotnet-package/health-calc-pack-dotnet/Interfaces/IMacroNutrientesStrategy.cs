using health_calc_pack_dotnet.Model;
using health_calc_pack_dotnet.Enum;

namespace health_calc_pack_dotnet.Interfaces
{
    public interface IMacroNutrientesStrategy
    {
        MacroNutrientesModel CalculateMacroNutrientes(double Peso);
    }
}
