﻿namespace LibreriaUnitTest
{
    public class Operacion
    {

        public List<int> NumerosImpares = new();

        public int SumarNumeros(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public bool IsValorPar(int numero)
        {
            return numero % 2 == 0;
        }

        public double SumarDecimal(double decimal1, double decimal2)
        {
            return decimal1 + decimal2;
        }

        public List<int> GetListaNumeroImpares(int intrevaloMinimo, int intervaloMaximo)
        {
            NumerosImpares.Clear();

            for (int i = intrevaloMinimo; i <= intervaloMaximo; i++) 
            {
                if (i % 2 != 0)
                {
                    NumerosImpares.Add(i);
                } 
            }

            return NumerosImpares;
        }
    }
}
