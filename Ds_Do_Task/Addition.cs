using System.Drawing;

namespace ds.test.impl
{
    internal class Addition: IPlugin
    {
        public string PluginName { get; }
        public string Version { get; }
        public Image Image { get; }
        public string Description { get; }
        
        /// <summary>
        /// Returns the sum of two integer numbers
        /// </summary>
        /// <param name="input1">the first term</param>
        /// <param name="input2">the second term</param>
        /// <returns></returns>
        public int Run(int input1, int input2) => checked(input1 + input2);
    }
}