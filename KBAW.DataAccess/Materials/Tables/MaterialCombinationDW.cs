namespace KBAW.DataAccess.Materials.Tables
{
    public static class MaterialCombinationDW
    {
        // 1 - Quality connection
        // 2 - Poor quality connections
        // 3 - Not data or not explored

        private static readonly int[,] Table = {
            {
                -1, (int)Materials.Al, (int)Materials.AlAlloys, (int)Materials.Bronze, (int)Materials.BronzeAlloys, (int)Materials.Cu, (int)Materials.CuAlloys,
                (int)Materials.Co, (int)Materials.CoAlloys, (int)Materials.Fe, (int)Materials.FeAlloys,
                (int)Materials.Mo, (int)Materials.MoAlloys, (int)Materials.Ni, (int)Materials.NiAlloys, (int)Materials.Nb, (int)Materials.NbAlloys,
                (int)Materials.Ta, (int)Materials.TaAlloys, (int)Materials.Ti, (int)Materials.TiAlloys,
                (int)Materials.W, (int)Materials.WAlloys, (int)Materials.Zr, (int)Materials.ZrAlloys, (int)Materials.Ceramics,
            },
            { (int)Materials.Al,           1, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 1, 1, 3, 3, 1, 3, 3 },
            { (int)Materials.AlAlloys,     1, 1, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Bronze,       3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.BronzeAlloys, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Cu,           1, 3, 3, 3, 2, 3, 3, 3, 1, 1, 1, 3, 1, 3, 3, 1, 3, 3, 1, 1, 1, 3, 3, 3, 1 },
            { (int)Materials.CuAlloys,     3, 3, 3, 3, 3, 2, 3, 3, 3, 1, 3, 3, 3, 3, 3, 1, 3, 3, 3, 1, 3, 3, 3, 3, 3 },
            { (int)Materials.Co,           3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.CoAlloys,     3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Fe,           3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 3, 1, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3 },
            { (int)Materials.FeAlloys,     3, 1, 3, 3, 3, 3, 3, 3, 1, 1, 1, 3, 1, 3, 1, 3, 3, 3, 3, 1, 3, 1, 3, 1, 1 },
            { (int)Materials.Mo,           3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 3, 3, 3, 1, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3 },
            { (int)Materials.MoAlloys,     3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Ni,           3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 3, 3, 2, 3, 3, 3, 3, 3, 3, 1, 1, 3, 3, 3, 3 },
            { (int)Materials.NiAlloys,     3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Nb,           3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1 },
            { (int)Materials.NbAlloys,     3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Ta,           3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 1, 3, 3, 3, 3, 3, 3, 3, 1 },
            { (int)Materials.TaAlloys,     3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Ti,           3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 1 },
            { (int)Materials.TiAlloys,     1, 3, 3, 3, 1, 1, 3, 3, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3 },
            { (int)Materials.W,            3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3 },
            { (int)Materials.WAlloys,      3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Zr,           3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
            { (int)Materials.ZrAlloys,     3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1 },
            { (int)Materials.Ceramics,     3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3 },
        };

        public static WeldabilityCheck.WeldingResult GetWeldingResult(Materials material1, Materials material2)
        {
            return Table.GetWeldingResult(material1, material2);
        }
    }
}