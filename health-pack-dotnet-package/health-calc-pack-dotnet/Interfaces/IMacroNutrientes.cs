using health_calc_pack_dotnet.Model;
using health_calc_pack_dotnet.Enum;

namespace health_calc_pack_dotnet.Interfaces
{
    public interface IMacroNutrientes
    {
        MacroNutrientesModel CalcularMacroNutrientes(ObjetivoFisico ObjetivoFisico, double Peso);
    }
}
