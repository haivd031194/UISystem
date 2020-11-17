namespace Loxodon.Framework.Views
{
    public class WindowProperties : IWindowProperties
    {
        /// <summary>
        /// Type of window will see on the game screen: Full, popup, dialog, ...
        /// </summary>
        public WindowType ShowType { get; set; }
        
        /// <summary>
        /// How should this window behave in case another window
        /// is already opened?
        /// </summary>
        /// <value>Force Foreground opens it immediately, Enqueue queues it so that it's opened as soon as
        /// the current one is closed. </value>
        public int WindowPriority { get; set; }
    }
}