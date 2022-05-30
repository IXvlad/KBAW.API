using System;
using System.ComponentModel.DataAnnotations;
using KBAW.ErrorHandler;
using KBAW.Utils;

namespace KBAW.DataAccess.Materials
{
    public static class WeldabilityCheck
    {
        public enum WeldingResult
        {
            [Display(Name = "Quality connection")]
            QualityСonnection = 1,
            [Display(Name = "Poor quality connections")]
            PoorQualityConnections,
            [Display(Name = "Not data or not explored")]
            NotData
        }

        public static string GetWeldingResult(this int[,] table, int material1, int material2)
        {
            ValuesIsDefined(material1, material2);

            int row = table.GetRow().FindIndex(material1)[0];
            int column = table.GetColumn().FindIndex(material2)[0];

            if (row == -1 || column == -1)
            {
                throw new CustomApplicationException("Material not found in table.", new CustomApplicationExceptionDetail
                {
                    FieldName = row == -1 ? Enum.GetName(typeof(Materials), material1) : Enum.GetName(typeof(Materials), material2)
                });
            }

            return ((WeldingResult)table[row, column]).DisplayName();
        }

        private static void ValuesIsDefined(params int[] values)
        {
            foreach (int value in values)
            {
                if (!Enum.IsDefined(typeof(Materials), value))
                {
                    throw new CustomApplicationException($"No material found with this key: {value}");
                }
            }
        }
    }
}