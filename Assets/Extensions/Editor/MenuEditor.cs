using UnityEditor;
using System.Linq;
using System.Collections.Generic;

namespace Extensions.Editor
{
    public static class MenuEditor
    {
        private const string UniRxEnable    = "Extensions/UniRx/Enable";
        private const string UniRxDisable   = "Extensions/UniRx/Disable";
        private const string UniRxSymbol    = "EXTENSIONS_UNIRX";
        private const string DOTweenEnable  = "Extensions/DOTween/Enable";
        private const string DOTweenDisable = "Extensions/DOTween/Disable";
        private const string DOTWeenSymbol  = "EXTENSIONS_DOTWEEN";

        [InitializeOnLoadMethod]
        private static void InitializeOnLoadMethod()
        {

        }

        [MenuItem(UniRxEnable)]
        private static void EnableUniRx()
        {
            AddSymbols(UniRxSymbol);
        }

        [MenuItem(UniRxEnable, true)]
        private static bool EnableUniRxValidate()
        {
#if EXTENSIONS_UNIRX
            Menu.SetChecked(UniRxEnable, true);
            return false;
#else
            Menu.SetChecked(UniRxEnable, false);
            return true;
#endif
        }

        [MenuItem(UniRxDisable)]
        private static void DisableUniRx()
        {
            RemoveSymbols(UniRxSymbol);
        }

        [MenuItem(UniRxDisable, true)]
        private static bool DisableUniRxValidate()
        {
#if EXTENSIONS_UNIRX
            Menu.SetChecked(UniRxDisable, false);
            return true;
#else
            Menu.SetChecked(UniRxDisable, true);
            return false;
#endif
        }

        [MenuItem(DOTweenEnable)]
        private static void EnableDOTween()
        {
            AddSymbols(DOTWeenSymbol);
        }

        [MenuItem(DOTweenEnable, true)]
        private static bool EnableDOTweenalidate()
        {
#if EXTENSIONS_DOTWEEN
            Menu.SetChecked(DOTweenEnable, true);
            return false;
#else
            Menu.SetChecked(DOTweenEnable, false);
            return true;
#endif
        }

        [MenuItem(DOTweenDisable)]
        private static void DisableDOTween()
        {
            RemoveSymbols(DOTWeenSymbol);
        }

        [MenuItem(DOTweenDisable, true)]
        private static bool DisableDOTweenValidate()
        {
#if EXTENSIONS_DOTWEEN
            Menu.SetChecked(DOTweenDisable, false);
            return true;
#else
            Menu.SetChecked(DOTweenDisable, true);
            return false;
#endif
        }

        private static void AddSymbols(params string[] args)
        {
            string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
            List<string> allDefines = definesString.Split(';').ToList();
            allDefines.AddRange(args.Except(allDefines));
            PlayerSettings.SetScriptingDefineSymbolsForGroup(
                EditorUserBuildSettings.selectedBuildTargetGroup,
                string.Join(";", allDefines.ToArray()));
        }

        private static void RemoveSymbols(params string[] args)
        {
            string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
            List<string> allDefines = definesString.Split(';').ToList();
            allDefines.Remove(x => args.Any(y => x == y));
            PlayerSettings.SetScriptingDefineSymbolsForGroup(
                EditorUserBuildSettings.selectedBuildTargetGroup,
                string.Join(";", allDefines.ToArray()));
        }
    }
}
