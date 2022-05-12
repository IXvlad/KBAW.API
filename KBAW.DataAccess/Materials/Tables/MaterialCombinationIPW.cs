namespace KBAW.DataAccess.Materials.Tables
{
    public static class MaterialCombinationIPW
    {
        // 1 - Quality connection
        // 2 - Poor quality connections
        // 3 - Not data or not explored

        private static readonly int[,] Table = {
            {
                -1, (int)Materials.AlAlloys, (int)Materials.CuZn, (int)Materials.Bronze, (int)Materials.CarbidesCemented, (int)Materials.CoAlloys,
                (int)Materials.Columbium, (int)Materials.Cu, (int)Materials.CuNi, (int)Materials.Pb, (int)Materials.MgAlloys, (int)Materials.Mo,
                (int)Materials.NiAlloys, (int)Materials.SteelAlloy, (int)Materials.SteelCarbon, (int)Materials.SteelFreeMachG, (int)Materials.SteelMaraging,
                (int)Materials.SteelSintered, (int)Materials.SteelStainless, (int)Materials.SteelTool, (int)Materials.Ta, (int)Materials.TiAlloys,
                (int)Materials.W, (int)Materials.ValveMaterials, (int)Materials.ZrAlloys,
            },
            { (int)Materials.AlAlloys,         1, 2, 2, 3, 2, 3, 2, 2, 3, 3, 3, 2, 2, 2, 3, 3, 3, 2, 3, 3, 2, 3, 3, 2 },
            { (int)Materials.CuZn,             2, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Bronze,           2, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.CarbidesCemented, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3 },
            { (int)Materials.CoAlloys,         2, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Columbium,        3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Cu,               2, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 2, 3, 3, 1, 3, 3, 1 },
            { (int)Materials.CuNi,             2, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 1, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Pb,               3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.MgAlloys,         3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
            { (int)Materials.Mo,               3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
            { (int)Materials.NiAlloys,         2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 2, 1, 1, 1, 1, 3, 3, 3, 2, 3 },
            { (int)Materials.SteelAlloy,       2, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 1, 1, 1, 2, 1, 1, 1, 1, 3, 1, 3, 1, 3 },
            { (int)Materials.SteelCarbon,      2, 3, 1, 1, 1, 3, 1, 1, 3, 3, 3, 1, 1, 1, 2, 1, 1, 1, 1, 3, 1, 3, 1, 3 },
            { (int)Materials.SteelFreeMachG,   3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 2, 2, 3, 3, 3, 2, 3 },
            { (int)Materials.SteelMaraging,    3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 2, 3, 1, 1, 1, 3, 3, 3, 1, 3 },
            { (int)Materials.SteelSintered,    3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 1, 3 },
            { (int)Materials.SteelStainless,   2, 3, 3, 3, 3, 3, 2, 1, 3, 3, 3, 1, 1, 1, 2, 1, 1, 2, 1, 3, 3, 1, 1, 3 },
            { (int)Materials.SteelTool,        3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 2, 1, 1, 1, 2, 3, 3, 3, 1, 3 },
            { (int)Materials.Ta,               3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3 },
            { (int)Materials.TiAlloys,         2, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 1, 1, 3, 3, 3, 1, 3, 3, 1, 3, 3, 3 },
            { (int)Materials.W,                3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3 },
            { (int)Materials.ValveMaterials,   3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 1, 1, 2, 1, 1, 1, 1, 3, 3, 3, 1, 3 },
            { (int)Materials.ZrAlloys,         2, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1 },
        };
        
        public static WeldabilityCheck.WeldingResult GetWeldingResult(Materials material1, Materials material2)
        {
            return Table.GetWeldingResult(material1, material2);
        }
    }
}