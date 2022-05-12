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

        public static WeldingResult GetWeldingResult(this int[,] table, Materials material1, Materials material2)
        {
            int row = table.GetRow().FindIndex((int)material1)[0];
            int column = table.GetColumn().FindIndex((int)material2)[0];

            if (row == -1 || column == -1)
            {
                throw new CustomApplicationException("Material not found in table.", new CustomApplicationExceptionDetail
                {
                    FieldName = row == -1 ? material1.ToString() : material2.ToString()
                });
            }
            
            return (WeldingResult)table[row, column];
        }
    }
}