using System.Drawing;

namespace ds.test.impl
{
    public class Adding: IPlugin
    {
        public string PluginName { get; }
        public string Version { get; }
        public Image Image { get; }
        public string Description { get; }
        public int Run(int input1, int input2)
        {
            throw new System.NotImplementedException();
        }
    }
}