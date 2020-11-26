using System.Collections.Generic;
using Loxodon.Framework.Data;

namespace Zitga.Samples.Configuration.Scripts
{
    public class DungeonActiveBuffConfig : ListConfig<DungeonActiveBuff>
    {
        private static string PATH = "dungeon/active_buff";

        private IDataProvider dataProvider;

        public DungeonActiveBuffConfig() : this(new ResourceDataProvider())
        {
            
        }
        
        public DungeonActiveBuffConfig(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
            
            Load(this.dataProvider.Load(PATH));
        }
    }
}