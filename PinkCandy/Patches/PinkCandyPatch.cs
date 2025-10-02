using HarmonyLib;
using InventorySystem.Items.Usables.Scp330;

namespace PinkCandy.Patches
{
    [HarmonyPatch(typeof(CandyPink), nameof(CandyPink.SpawnChanceWeight), MethodType.Getter)]
    internal static class PinkCandyPatch
    {
        private static void Postfix(ref float __result)
        {
            if (__result <= 0)
                __result = 1;
        }
    }
}
