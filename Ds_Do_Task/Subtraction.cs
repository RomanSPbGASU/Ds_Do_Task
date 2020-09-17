using System.Drawing;

namespace ds.test.impl
{
    internal class Subtraction: PluginAbstract, IPlugin
    {
        public string PluginName => "Subtraction";
        public Image Image => Image.FromFile("../../Assets/Minus.png");
        public string Description => "The object that implements the subtraction";

        /// <summary>
        /// Returns the difference of two integer numbers
        /// </summary>
        /// <param name="input1">the minuend</param>
        /// <param name="input2">the subtrahend</param>
        /// <returns></returns>
        public int Run(int input1, int input2) => checked(input1 - input2);
    }
}