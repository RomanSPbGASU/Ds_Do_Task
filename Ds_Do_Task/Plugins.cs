using System;
using System.Reflection;

namespace ds.test.impl
{
    // I cannot make it static as needed in technical task, because interface is a "contract" for class instances (objects).
    // So, I can suppose that you need only one instance of the class. To do this, we can create a singleton.
    // But what is profit of it? We only spare the object's size in memory and avoid allocating it on a heap.
    
    /// <summary>
    /// Plugins factory
    /// </summary>
    public class Plugins: PluginFactory
    {
        /// <summary>
        /// Number of types of objects performing calculations
        /// </summary>
        public int PluginsCount => 2;
        
        /// <summary>
        /// Names of types of objects performing calculations.
        /// You should use only this values as the argument of the <c>GetPlugin</c> method
        /// </summary>
        public string[] GetPluginNames => new[] {"Addition", "Subtraction"};
        
        /// <summary>
        /// Factory method that creates classes executing mathematical operations
        /// The following plugin names are supported:
        /// <list type="bullet">
        ///     <item><term>Addition</term><description>The class that implements the addition</description></item>
        ///     <item><term>Subtraction</term><description>The class that implements the subtraction</description></item>
        /// </list>
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns></returns>
        public IPlugin GetPlugin(string pluginName) // TODO: tests and docs
        {
            IPlugin plugin;
            switch (pluginName)
            {
                case "Addition":
                    plugin = new Addition();
                    break;
                
                // It isn't necessary operation because our spacemen have addition and can use negative numbers but it's good as example
                // Also spacemen can implement other operations through these two.
                case "Subtraction":    
                    plugin = new Subtraction();
                    break;
                
                default:
                    throw new Exception($"This plugin is not supported. Supported plugin names are: {GetPluginNames}");
            }

            return plugin;
        }
    }
}