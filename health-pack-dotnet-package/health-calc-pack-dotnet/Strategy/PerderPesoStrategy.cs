using health_calc_pack_dotnet.Model;
using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet.Strategy
{
    public class PerderPesoStrategy : IMacroNutrientesStrategy
    {
        public MacroNutrientesModel CalculateMacroNutrientes(double Peso)
        {
            return new MacroNutrientesModel()
            {
                Carboidratos = 3.0 * Peso,
                Gorduras = 3.0 * Peso,
                Proteinas = 4.0 * Peso,
            };
        }
    }
}
