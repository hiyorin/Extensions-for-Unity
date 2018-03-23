using UnityEngine;

namespace Extensions
{
    /// <summary>
    /// Behaviour extensions.
    /// </summary>
    public static class BehaviourExtensions
    {
        public static void SetEnabled(this Behaviour self, bool enabled)
        {
            if (self.enabled != enabled)
            {
                self.enabled = enabled;
            }
        }
    }
}
