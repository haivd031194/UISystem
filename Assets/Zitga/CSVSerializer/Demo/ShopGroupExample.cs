using System;
using UnityEditor;
using UnityEngine;

public class ShopGroupExample : ScriptableObject
{
    [System.Serializable]
    public class Reward
    {
        public int res_type;
        public int res_id;
        public int money_type;
        public int money_value;
    }

    [System.Serializable]
    public class RewardStock
    {
        public int id;
        public Reward reward;
        public int rate;
        public int stock;
    }

    [System.Serializable]
    public class Shop
    {
        public int shop_type;
        public int group_rate;
        public RewardStock[] rewardStocks;
    }
    
    [System.Serializable]
    public class ShopGroup
    {
        public int group_id;
        public int stage_min;
        public int stage_max;
        public Shop[] shops;
    }

    public ShopGroup[] shopGroups;
}

#if UNITY_EDITOR
public class GroupPostprocessor : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (string str in importedAssets)
        {
            if (str.IndexOf("/shop_group.csv") != -1)
            {
                TextAsset data = AssetDatabase.LoadAssetAtPath<TextAsset>(str);
                string assetfile = str.Replace(".csv", ".asset");
                ShopGroupExample gm = AssetDatabase.LoadAssetAtPath<ShopGroupExample>(assetfile);
                if (gm == null)
                {
                    gm = ScriptableObject.CreateInstance<ShopGroupExample>();
                    AssetDatabase.CreateAsset(gm, assetfile);
                }
                
                gm.shopGroups = CSVSerializer.Deserialize<ShopGroupExample.ShopGroup>(data.text);

                EditorUtility.SetDirty(gm);
                AssetDatabase.SaveAssets();
#if DEBUG_LOG || UNITY_EDITOR
                Debug.Log("Reimported Asset: " + str);
#endif
            }
        }
    }
}
#endif
