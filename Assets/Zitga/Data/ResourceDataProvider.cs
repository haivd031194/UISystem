using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Loxodon.Framework.Data
{
    public class ResourceDataProvider : IDataProvider
    {
        public List<string[]> Load(string path,  char separator = ',')
        {
            try
            {
                var content = Resources.Load<TextAsset>(path).text;
                return CSVSerializer.ParseCSV(content, separator);
            }
            catch
            {
                throw new InvalidOperationException("Asset not found: " + path);
            }
        }

        public async UniTask<List<string[]>> LoadAsync(string path,  char separator = ',')
        {
            var asset = await Resources.LoadAsync<TextAsset>(path).ToUniTask();
            
            var content = (asset as TextAsset)?.text ?? throw new InvalidOperationException("Asset not found: " + path);
            
            return CSVSerializer.ParseCSV(content, separator);
        }
    }
}