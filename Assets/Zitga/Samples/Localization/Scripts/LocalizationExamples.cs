using Loxodon.Framework.Localizations;
using UnityEngine;

namespace Loxodon.Framework.Tutorials
{
    public class LocalizationExamples : MonoBehaviour
    {
        private Localization localization;

        void Awake ()
        {
            this.localization = Localization.Current;
            this.localization.CultureInfo = Locale.GetCultureInfoByLanguage(SystemLanguage.Vietnamese);

        }
    }
}