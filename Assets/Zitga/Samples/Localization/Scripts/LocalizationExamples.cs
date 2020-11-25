using System;
using Cysharp.Threading.Tasks;
using Loxodon.Framework.Localizations;
using UnityEngine;
using UnityEngine.UI;

namespace Loxodon.Framework.Tutorials
{
    public class LocalizationExamples : MonoBehaviour
    {
        [SerializeField]
        private Button english;
        [SerializeField]
        private Button indonesia;
        [SerializeField]
        private Text content;

        private int score = 0;

        private Localization localization;

        private EventHandler languageChanged;

        void Awake ()
        {
            this.localization = Localization.Current;
            
            this.localization.CultureInfo = Locale.GetCultureInfoByLanguage(SystemLanguage.English);
            
            InitButton();

            InitListener();
        }

        private void InitListener()
        {
            languageChanged = (sender, e) =>
            {
                UpdateText(sender, e).Forget();
            };

            this.localization.CultureInfoChanged += languageChanged;
        }

        private void InitButton()
        {
            english.onClick.AddListener(OnClickEn);
            indonesia.onClick.AddListener(OnClickId);
        }

        private void OnClickEn()
        {
            this.localization.CultureInfo = Locale.GetCultureInfoByLanguage(SystemLanguage.English);
        }

        private void OnClickId()
        {
            this.localization.CultureInfo = Locale.GetCultureInfoByLanguage(SystemLanguage.Indonesian);
        }
        
        private async UniTaskVoid UpdateText(object sender, EventArgs e)
        {
            var value = await R.common.accept;
            score++;
            content.text = value + " " + score;
        }
    }
}