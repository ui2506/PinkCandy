using HarmonyLib;
using InventorySystem.Items.Usables.Scp330;

namespace PinkCandy.Patches
{
    [HarmonyPatch(typeof(CandyPink), nameof(CandyPink.SpawnChanceWeight), MethodType.Getter)]
    internal static class PinkCandyPatch
    {
        private static bool Prefix (CandyPink __intance, ref float __result)
        {
            if (__intance.SpawnChanceWeight > 0)
                return true;

            __result = 1;
            return false;
        }
    }
}
