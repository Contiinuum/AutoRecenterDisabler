using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using System.Reflection;
using MelonLoader;

namespace AudicaModding
{
    internal static class Hooks
    {
        public static void ApplyHooks(HarmonyInstance instance)
        {
            instance.PatchAll(Assembly.GetExecutingAssembly());
        }


        [HarmonyPatch(typeof(KataConfig), "SetupGuns")]
        private static class PatchKataSetupGuns
        {
            private static void Postfix()
            {
                if (PlayerCorral.I.rangeShell != 100)
                    PlayerCorral.I.rangeShell = 100;
            }
        }
    }
}
