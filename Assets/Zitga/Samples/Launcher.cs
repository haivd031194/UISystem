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
using Loxodon.Framework.Views;
using Loxodon.Log;
using UnityEngine;

namespace Loxodon.Framework.Examples
{
    public class Launcher : MonoBehaviour
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Launcher));
        private void Awake()
        {
            GlobalWindowManager windowManager = FindObjectOfType<GlobalWindowManager>();
            if (windowManager == null)
                throw new NotFoundException("Not found the GlobalWindowManager.");
        }

        private IEnumerator Start()
        {
            /* Create a window container */
            WindowContainer winContainer = WindowContainer.Create("MAIN");

            yield return null;

            IUIViewLocator locator = new ResourcesViewLocator();
            
            var result = locator.LoadWindowAsync<StartupWindow>(winContainer, "UI/Startup/Startup");
            while (!result.IsDone)
            {
                Debug.LogFormat("Percentage: {0}% ", result.Progress);
                yield return null;
            }

            Debug.LogFormat("IsDone:{0} Result:{1}", result.IsDone, result.Result);
            var window = result.Result;
            window.Create();
            ITransition transition = window.Show().OnStateChanged((w, state) =>
            {
                log.DebugFormat("Window:{0} State{1}",w.Name,state);
            });
            
            yield return transition.WaitForDone();
        }
    }
}