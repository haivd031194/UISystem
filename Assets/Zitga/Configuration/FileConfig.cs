using Loxodon.Framework.Data;

namespace Zitga.Configuration
{
    public abstract class FileConfig : IConfig
    {
        private string Path { get; set; }

        private readonly IDataProvider dataProvider;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataProvider"></param>
        /// <param name="path"></param>
        public FileConfig(IDataProvider dataProvider, string path)
        {
            this.dataProvider = dataProvider;
            this.Path = path;
            
            Load();
        }
        
        /// <summary>
        /// Auto fill data to variables
        /// </summary>
        private void Load()
        {
            var data = dataProvider.Load(Path);
            Load(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public virtual void Load(object obj)
        {
            throw new System.NotImplementedException();
        }
    }
}