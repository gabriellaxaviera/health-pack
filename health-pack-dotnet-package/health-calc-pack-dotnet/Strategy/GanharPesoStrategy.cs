using health_calc_pack_dotnet.Model;
using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet.Strategy
{
    public class GanharPesoStrategy : IMacroNutrientesStrategy
    {
        public MacroNutrientesModel CalculateMacroNutrientes(double Peso)
        {
            return new MacroNutrientesModel()
            {
                Carboidratos = 4.0 * Peso,
                Gorduras = 1.0 * Peso,
                Proteinas = 2.0 * Peso,
            };
        }
    }
}
