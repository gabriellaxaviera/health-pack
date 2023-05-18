﻿using health_calc_pack_dotnet.Enum;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Model;


namespace health_calc_pack_dotnet
{
    public class MacroNutrientes : IMacroNutrientes
    {
        public MacroNutrientesModel CalcularMacroNutrientes(ObjetivoFisico ObjetivoFisico, double Peso)
        {
            if (ObjetivoFisico == ObjetivoFisico.PerderPeso)
            {
                return new MacroNutrientesModel()
                {
                    Carboidratos = 3.0 * Peso,
                    Gorduras = 3.0 * Peso,
                    Proteinas = 4.0 * Peso,
                };
            }
            else if (ObjetivoFisico == ObjetivoFisico.ManterPeso)
            {
                return new MacroNutrientesModel()
                {
                    Carboidratos = 4.0 * Peso,
                    Gorduras = 2.0 * Peso,
                    Proteinas = 4.0 * Peso,
                };
            }
            else if (ObjetivoFisico == ObjetivoFisico.GanharPeso)
            {
                return new MacroNutrientesModel()
                {
                    Carboidratos = 4.0 * Peso,
                    Gorduras = 1.0 * Peso,
                    Proteinas = 2.0 * Peso,
                };
            }
            else
            {
                return new MacroNutrientesModel();
            }

        }
    }
}
