using BepInEx;
using HarmonyLib;
using NoSkillLoss;

namespace NoSkillLoss {
    [BepInPlugin(ModInfo.GUID, ModInfo.MODNAME, ModInfo.VERSION)]
    public class Main : BaseUnityPlugin {
        private void Awake() {
            Harmony harmony = new Harmony(ModInfo.GUID);
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(Skills), nameof(Skills.Clear))]
    public static class PatchSkillsClear {
        static bool Prefix() {
            return false;
        }
    }

    [HarmonyPatch(typeof(Skills), nameof(Skills.OnDeath))]
    public static class PatchSkillsOnDeath {
        static bool Prefix() {
            return false;
        }
    }

    [HarmonyPatch(typeof(Skills), nameof(Skills.LowerAllSkills))]
    public static class PatchSkillsLowerAllSkills {
        static bool Prefix() {
            return false;
        }
    }
}
