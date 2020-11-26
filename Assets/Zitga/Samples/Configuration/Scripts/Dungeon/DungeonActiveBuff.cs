
using UnityEngine;

namespace Zitga.Samples.Configuration.Scripts
{
    public class DungeonActiveBuff : IConfig
    {
        public int id;
        public int limit;
        public int rarity;
        public int buffType;
        public float hpPercent;
        public int power;

        public void Load(object obj)
        {
            Load((string[])obj);
        }

        void Load(string[] data)
        {
            id = int.Parse(data[0]);
            limit = int.Parse(data[1]);
            
            Debug.Log(id);
        }
    }
}