using NET_SDK.Harmony;
using MelonLoader;
using NET_SDK;
using System;

namespace AutoRecenterDisabler
{
    public static class BuildInfo
    {
        public const string Name = "AutoRecenterDisabler"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "Alternity"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class AutoRecenterDisabler : MelonMod
    {
        public static Patch TitleScreen_Update;

        public override void OnApplicationStart()
        {
            Instance instance = Manager.CreateInstance("AutoRecenterDisabler");

            TitleScreen_Update = instance.Patch(SDK.GetClass("TitleScreen").GetMethod("Update"), typeof(AutoRecenterDisabler).GetMethod("TitleScreenUpdate"));
        }

        public static unsafe void TitleScreenUpdate(IntPtr @this)
        {
            TitleScreen_Update.InvokeOriginal(@this);

            if (PlayerCorral.I.rangeShell != 100)
            {
                PlayerCorral.I.rangeShell = 100;
            }
        }

        /*
        public override void OnLevelWasLoaded(int level)
        {
            MelonModLogger.Log("OnLevelWasLoaded: " + level.ToString());
        }

        public override void OnLevelWasInitialized(int level)
        {
            MelonModLogger.Log("OnLevelWasInitialized: " + level.ToString());
        }

        public override void OnUpdate()
        {
            MelonModLogger.Log("OnUpdate");
        }

        public override void OnFixedUpdate()
        {
            MelonModLogger.Log("OnFixedUpdate");
        }

        public override void OnLateUpdate()
        {
            MelonModLogger.Log("OnLateUpdate");
        }

        public override void OnGUI()
        {
            MelonModLogger.Log("OnGUI");
        }

        public override void OnApplicationQuit()
        {
            MelonModLogger.Log("OnApplicationQuit");
        }

        public override void OnModSettingsApplied()
        {
            MelonModLogger.Log("OnModSettingsApplied");
        }

        public override void VRChat_OnUiManagerInit() // Only works in VRChat
        {
            MelonModLogger.Log("VRChat_OnUiManagerInit");
        }
        */
    }
}
