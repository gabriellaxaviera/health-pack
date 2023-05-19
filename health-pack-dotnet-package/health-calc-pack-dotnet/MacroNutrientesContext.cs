
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Model;

namespace health_calc_pack_dotnet
{
    public class MacroNutrientesContext
    {
        private IMacroNutrientesStrategy? strategy;

        public void SetStrategy (IMacroNutrientesStrategy strategy)
        {
            this.strategy = strategy;
        }

        public MacroNutrientesModel ExecuteStrategy(double Peso)
        {
            return strategy!.CalculateMacroNutrientes(Peso);
        }
    }
}
