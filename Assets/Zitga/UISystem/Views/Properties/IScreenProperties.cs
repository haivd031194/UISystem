namespace Loxodon.Framework.Views
{
    /// <summary>
    /// Base interface for all the screen properties
    /// </summary>
    public interface IScreenProperties { }

    public interface IWindowProperties : IScreenProperties
    {
        /// <summary>
        /// Type of window will see on the game screen: Full, popup, dialog, ...
        /// </summary>
        WindowType ShowType { get; set; }
        /// <summary>
        /// See what window will be showed on the top
        /// </summary>
        int WindowPriority { get; set; }
    }
    

}