﻿using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Utils;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double Calculate(double Height, double Weight)
        {
            if (!IsValidData(Height, Weight))
            {
                return 0;
            }

            double calculo = Weight / Math.Pow(Height, 2);
            return Math.Round(calculo, 2);
        }

        //IMC                 CLASSIFICAÇÃO   OBESIDADE(GRAU)
        //MENOR QUE 18,5	    MAGREZA	            0
        //ENTRE 18,5 E 24,9	    NORMAL	            0
        //ENTRE 25,0 E 29,9	    SOBREPESO           I
        //ENTRE 30,0 E 39,9 	OBESIDADE           II
        //MAIOR QUE 40,0	    OBESIDADE GRAVE     III
        public string GetIMCCategory(double IMC)
        {
            var Result = string.Empty;
            if (IMC < 18.5)
                Result = Constants.MAGREZA;
            else if (IMC >= 18.5 && IMC < 25)
                Result = Constants.NORMAL;
            else if (IMC >= 25 && IMC < 30)
                Result = Constants.SOBREPESO;
            else if (IMC >= 30 && IMC < 40)
                Result = Constants.OBESIDADE;
            else if (IMC >= 40)
                Result = Constants.OBESIDADE_GRAVE;

            return Result;
        }

        public bool IsValidData(double Height, double Weight)
        {
            return (Height > 0 && Height < 3.0 && Weight > 0 && Weight <= 300);
        }
    }
}
