using UnityEditor;

namespace Extensions.Editor
{
    public static class UniRxMenu
    {
        private const string EnableItemName     = "Extensions/UniRx/Enable";
        private const string DisableItemName    = "Extensions/UniRx/Disable";
        private const string Symbol             = "EXTENSIONS_UNIRX";

        [MenuItem(EnableItemName)]
        private static void Enable()
        {
            MenuEditor.AddSymbols(Symbol);
        }

        [MenuItem(EnableItemName, true)]
        private static bool EnableValidate()
        {
#if EXTENSIONS_UNIRX
            Menu.SetChecked(EnableItemName, true);
            return false;
#else
            Menu.SetChecked(EnableItemName, false);
            return true;
#endif
        }

        [MenuItem(DisableItemName)]
        private static void Disable()
        {
            MenuEditor.RemoveSymbols(Symbol);
        }

        [MenuItem(DisableItemName, true)]
        private static bool DisableValidate()
        {
#if EXTENSIONS_UNIRX
            Menu.SetChecked(DisableItemName, false);
            return true;
#else
            Menu.SetChecked(DisableItemName, true);
            return false;
#endif
        }
    }
}
