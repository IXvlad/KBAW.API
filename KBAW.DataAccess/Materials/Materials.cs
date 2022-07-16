﻿using System.ComponentModel.DataAnnotations;

namespace KBAW.DataAccess.Materials;

public enum Materials
{
    [Display(Name = "Aluminum")] Al = 4,
    [Display(Name = "Aluminum alloys")] AlAlloys = 5,
    [Display(Name = "Brass")] CuZn = 6,
    [Display(Name = "Bronze")] Bronze = 7,
    [Display(Name = "Bronze alloys")] BronzeAlloys = 8,
    [Display(Name = "Copper")] Cu = 9,
    [Display(Name = "Copper alloys")] CuAlloys = 10,
    [Display(Name = "Copper nickel")] CuNi = 11,
    [Display(Name = "Cobalt")] Co = 12,
    [Display(Name = "Cobalt Alloys")] CoAlloys = 13,
    [Display(Name = "Lead")] Pb = 14,
    [Display(Name = "Nickel")] Ni = 15,
    [Display(Name = "Nickel alloys")] NiAlloys = 16,
    [Display(Name = "Ceramics")] Ceramics = 17,
    [Display(Name = "Titanium")] Ti = 18,
    [Display(Name = "Titanium alloys")] TiAlloys = 19,
    [Display(Name = "Tantalum")] Ta = 20,
    [Display(Name = "Tantalum alloys")] TaAlloys = 21,
    [Display(Name = "Molybdenum")] Mo = 22,
    [Display(Name = "Molybdenum alloys")] MoAlloys = 23,
    [Display(Name = "Tungsten")] W = 24,
    [Display(Name = "Tungsten Alloys")] WAlloys = 25,
    [Display(Name = "Zirconium")] Zr = 26,
    [Display(Name = "Zirconium alloys")] ZrAlloys = 27,
    [Display(Name = "Niobium")] Nb = 28,
    [Display(Name = "Niobium alloys")] NbAlloys = 29,
    [Display(Name = "Iron")] Fe = 30,
    [Display(Name = "Iron alloys")] FeAlloys = 31,
    [Display(Name = "Sintered iron")] FeSintered = 32,
    [Display(Name = "Invar")] FeNi = 33,
    [Display(Name = "Magnesium")] Mg = 34,
    [Display(Name = "Magnesium alloys")] MgAlloys = 35,
    [Display(Name = "Carbon steel")] SteelCarbon = 36,
    [Display(Name = "Steel alloys")] SteelAlloy = 37,
    [Display(Name = "Maraging steel")] SteelMaraging = 38,
    [Display(Name = "Stainless steel")] SteelStainless = 39,
    [Display(Name = "Sintered steel")] SteelSintered = 40,
    [Display(Name = "Steel tool")] SteelTool = 41,
    [Display(Name = "Silver")] Ag = 43,
    [Display(Name = "Silver alloys")] AgAlloys = 44,
    [Display(Name = "Thorium")] Th = 45,
    [Display(Name = "Uranus")] U = 46,
    [Display(Name = "Vanadium")] V = 47,
    [Display(Name = "Superhard materials")] SuperhardMaterial = 48,
    [Display(Name = "Wolfram carbide")] Ws = 49,
    [Display(Name = "Nimonic")] Nimonic = 50,
    [Display(Name = "Monel")] Monel = 51,
    [Display(Name = "Valve materials")] ValveMaterials = 52,
    [Display(Name = "Cadmium oxide")] CdO = 53,
    [Display(Name = "Cast iron")] CastIron = 54,
    [Display(Name = "Cemented carbide")] CarbidesCemented = 55,
    [Display(Name = "Columbium")] Columbium = 56,
    [Display(Name = "???")] SteelFreeMachG = -1,
}
