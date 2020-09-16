namespace ds.test.impl
{
    public class Plugins: PluginFactory
    {
        public int PluginsCount { get; }
        public string[] GetPluginNames { get; }
        public IPlugin GetPlugin(string pluginName)
        {
            throw new System.NotImplementedException();
        }
    }
}