using Cysharp.Threading.Tasks;
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
            this.localization.CultureInfo = Locale.GetCultureInfoByLanguage(SystemLanguage.English);
            UniTask.Run(async () =>
            {
                var value = await R.common.accept;
                Debug.Log("Do something: " + value);
                
                this.localization.CultureInfo = Locale.GetCultureInfoByLanguage(SystemLanguage.Indonesian);
                
                value = await R.common.accept;
                Debug.Log("Do something: " + value);
            });
        }
    }
}