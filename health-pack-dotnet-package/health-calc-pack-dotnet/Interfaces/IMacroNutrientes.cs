using health_calc_pack_dotnet.Model;

namespace health_calc_pack_dotnet.Interfaces
{
    public interface IMacroNutrientes
    {
        MacroNutrientesModel CalcularMacroNutrientes(ObjetivoFisicoEnum ObjetivoFisico, double Peso);
    }
}
