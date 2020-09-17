namespace ds.test.impl
{
    /// <summary>
    /// Interface for plugins which execute mathematical operations
    /// </summary>
    public interface IPlugin 
    { 
        
        /// <summary>
        /// Name of a plugin
        /// </summary>
        string PluginName { get; } 
        
        /// <summary>
        /// Version of a plugin
        /// </summary>
        string Version { get; } 
        
        /// <summary>
        /// Image that represent plugin
        /// </summary>
        System.Drawing.Image Image { get; }
        
        /// <summary>
        /// Description of a plugin
        /// </summary>
        string Description { get; }
        
        /// <summary>
        /// The method which execute plugin's primary action
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        int Run (int input1, int input2);
    }
}

