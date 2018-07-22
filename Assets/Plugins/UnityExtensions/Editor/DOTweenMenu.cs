using UnityEditor;

namespace UnityExtensions.Editor
{
    public static class DOTweenMenu
    {
        private const string EnableItemName     = "Extensions/DOTween/Enable";
        private const string DisableItemName    = "Extensions/DOTween/Disable";
        private const string Symbol             = "EXTENSIONS_DOTWEEN";

        [MenuItem(EnableItemName)]
        private static void EnableDOTween()
        {
            MenuEditor.AddSymbols(Symbol);
        }

        [MenuItem(EnableItemName, true)]
        private static bool EnableDOTweenalidate()
        {
#if EXTENSIONS_DOTWEEN
            Menu.SetChecked(EnableItemName, true);
            return false;
#else
            Menu.SetChecked(EnableItemName, false);
            return true;
#endif
        }

        [MenuItem(DisableItemName)]
        private static void DisableDOTween()
        {
            MenuEditor.RemoveSymbols(Symbol);
        }

        [MenuItem(DisableItemName, true)]
        private static bool DisableDOTweenValidate()
        {
#if EXTENSIONS_DOTWEEN
            Menu.SetChecked(DisableItemName, false);
            return true;
#else
            Menu.SetChecked(DisableItemName, true);
            return false;
#endif
        }
    }
}
