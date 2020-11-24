using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Loxodon.Framework.Localizations;
using UnityEngine;

namespace Loxodon.Framework.Data
{
    public class LocalizeDataProvider
    {
        private const string Format = "Localization/{0}/{1}";

        private readonly IDataProvider dataProvider;

        private readonly Localization localization;

        private readonly Dictionary<string, Dictionary<string, string>> data;

        public LocalizeDataProvider(IDataProvider dataProvider, Localization localization)
        {
            this.dataProvider = dataProvider;

            this.localization = localization;

            this.data = new Dictionary<string, Dictionary<string, string>>();
        }

        public void ClearData()
        {
            this.data.Clear();
        }

        public async UniTask<string> Get(string category, string key)
        {
            if (data.TryGetValue(category, out var content) == false)
            {
                await UniTask.SwitchToMainThread();
                
                content = await LoadAsync(string.Format(Format, localization.CultureInfo.Name, category));

                data.Add(category, content);
            }

            try
            {
                return content[key];
            }
            catch
            {
                Debug.LogWarningFormat($"Missing {key}");
                return key;
            }
        }

        private async UniTask<Dictionary<string, string>> LoadAsync(string path)
        {
            var content = await dataProvider.LoadAsync(path, '~');

            return Parse(content);
        }

        private Dictionary<string, string> Parse(List<string[]> content)
        {
            var dict = new Dictionary<string, string>();

            foreach (var line in content)
            {
                var key = line[0];
                var value = line[1];
                if (dict.ContainsKey(key))
                {
                    throw new Exception("Key is exist: " + key);
                }

                dict.Add(key, value);
            }

            return dict;
        }
    }
}