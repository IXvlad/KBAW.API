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
            [Display(ResourceType = typeof(Resources), Name = "wr_quality_connection_lbl")]
            QualityСonnection = 1,
            [Display(ResourceType = typeof(Resources), Name = "wr_poor_quality_connection_lbl")]
            PoorQualityConnections,
            [Display(ResourceType = typeof(Resources), Name = "wr_not_data_lbl")]
            NotData
        }

        public static string GetWeldingResult(this int[,] table, int material1, int material2)
        {
            ValuesIsDefined(material1, material2);

            int row = table.GetRow().FindIndex(material1)[0];
            int column = table.GetColumn().FindIndex(material2)[0];

            if (row == -1 || column == -1)
            {
                throw new CustomApplicationException(Resources.material_not_found_msg, new CustomApplicationExceptionDetail
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
                    throw new CustomApplicationException(string.Format(Resources.material_does_not_exist_msg, value));
                }
            }
        }
    }
}