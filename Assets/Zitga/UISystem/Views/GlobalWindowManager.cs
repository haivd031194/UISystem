/*
 * MIT License
 *
 * Copyright (c) 2018 Clark Yang
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the "Software"), to deal in 
 * the Software without restriction, including without limitation the rights to 
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
 * of the Software, and to permit persons to whom the Software is furnished to do so, 
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all 
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE 
 * SOFTWARE.
 */

using System.Collections;
using System.Collections.Generic;
using Loxodon.Framework.Contexts;
using Loxodon.Log;
using UnityEngine;

namespace Loxodon.Framework.Views
{
    [RequireComponent(typeof(RectTransform), typeof(Canvas))]
    public class GlobalWindowManager : WindowManager
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(GlobalWindowManager));

        /// <summary>
        /// The context of the game. Use to get game services
        /// </summary>
        private ApplicationContext context;

        /// <summary>
        /// The window which loading, creating, showing with animation but not finish.
        /// Add when call to show
        /// Remove when showing animation finish
        /// </summary>
        private Queue<string> loadingWindow;

        /// <summary>
        /// All showing windows in the game. Just contain window after finish animations.
        /// </summary> 
        private List<IWindow> showingWindow;

        /// <summary>
        /// All loaded windows in the game. It contains all showing window collection
        /// </summary>
        private Dictionary<string, IWindow> loadedWindow;

        private void Awake()
        {
            context = Context.GetApplicationContext();

            loadingWindow = new Queue<string>();

            showingWindow = new List<IWindow>();

            loadedWindow = new Dictionary<string, IWindow>();
        }

        public new IEnumerator Show(string uiViewId)
        {
            IWindow window;

            if (IsWindowLoading(uiViewId))
            {
                // may be can update model view after that
                yield break;
            }

            if (IsWindowLoaded(uiViewId))
            {
                loadedWindow.TryGetValue(uiViewId, out window);
            }
            else
            {
                loadingWindow.Enqueue(uiViewId);
                
                var locator = context.GetService<IUIViewLocator>();
                
                var result = locator.LoadWindowAsync<IWindow>(uiViewId);

                while (!result.IsDone)
                {
                    Debug.LogFormat("Percentage: {0}% ", result.Progress);
                    yield return null;
                }

                Debug.LogFormat("IsDone:{0} Result:{1}", result.IsDone, result.Result);

                window = result.Result;

                window.Create();
                
                string lastUIViewId = loadingWindow.Dequeue();

                if (lastUIViewId != uiViewId)
                {
                    log.ErrorFormat("Window is valid: {0} != {1}", lastUIViewId, uiViewId);
                    yield break;
                }

                loadedWindow.Add(uiViewId, window);
            }

            if (window != null && window.Visibility == false)
            {
                showingWindow.Add(window);
                
                ITransition transition = window.Show().OnStateChanged((w, state) =>
                {
                    // log.DebugFormat("Window Show:{0} State{1}", w.Name, state);
                });

                yield return transition.WaitForDone();
            }

            if (loadingWindow.Count > 0)
            {
                var nextUIViewId = loadingWindow.Peek();
                yield return Show(nextUIViewId);
            }
        }

        public new IEnumerator Hide(string uiViewId)
        {
            loadedWindow.TryGetValue(uiViewId, out IWindow window);
            if (window != null)
            {
                if (showingWindow.Contains(window) && window.Visibility)
                {
                    ITransition transition = window.Hide().OnStateChanged((w, state) =>
                    {
                        // log.DebugFormat("Window Hide:{0} State{1}", w.Name, state);
                    });
                
                    yield return transition.WaitForDone();
                
                    showingWindow.Remove(window);
                }
                else
                {
                    log.WarnFormat("Window has already hid: {0}", uiViewId);
                }
            }
            else
            {
                log.ErrorFormat("Window is not exist: {0}", uiViewId);
            }
        }

        /// <summary>
        /// Is window loading or in queue to load?
        /// </summary>
        /// <param name="uiViewId"></param>
        /// <returns></returns>
        private bool IsWindowLoading(string uiViewId)
        {
            return loadingWindow.Contains(uiViewId);
        }

        /// <summary>
        /// Is window called to load?
        /// </summary>
        /// <param name="uiViewId"></param>
        /// <returns></returns>
        private bool IsWindowLoaded(string uiViewId)
        {
            return loadedWindow.ContainsKey(uiViewId);
        }
    }
}