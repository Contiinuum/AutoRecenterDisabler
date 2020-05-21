using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(AutoRecenterDisabler.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(AutoRecenterDisabler.BuildInfo.Company)]
[assembly: AssemblyProduct(AutoRecenterDisabler.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + AutoRecenterDisabler.BuildInfo.Author)]
[assembly: AssemblyTrademark(AutoRecenterDisabler.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(AutoRecenterDisabler.BuildInfo.Version)]
[assembly: AssemblyFileVersion(AutoRecenterDisabler.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(AutoRecenterDisabler.AutoRecenterDisabler), AutoRecenterDisabler.BuildInfo.Name, AutoRecenterDisabler.BuildInfo.Version, AutoRecenterDisabler.BuildInfo.Author, AutoRecenterDisabler.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonModGame(null, null)]