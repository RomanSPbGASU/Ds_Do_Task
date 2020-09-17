using System;
using System.Drawing;

namespace ds.test.impl
{
    internal class Addition: PluginAbstract, IPlugin
    {
        public string PluginName => "Addition";
        public Image Image => Image.FromFile("Assets/Plus.png");
        public string Description => "The object that implements the addition";
        
        /// <summary>
        /// Returns the sum of two integer numbers
        /// </summary>
        /// <param name="input1">the first term</param>
        /// <param name="input2">the second term</param>
        /// <returns></returns>
        public int Run(int input1, int input2) => checked(input1 + input2);
    }
}