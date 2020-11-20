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

using System;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

using Loxodon.Framework.Observables;
using System.Threading.Tasks;
using Zitga.Localizations;

namespace Loxodon.Framework.Localizations
{
    public class Localization : ILocalization
    {
        private static readonly object _instanceLock = new object();
        private static Localization instance;

        private readonly object _lock = new object();
        private CultureInfo cultureInfo;
        private EventHandler cultureInfoChanged;

        public static Localization Current
        {
            get
            {
                if (instance != null)
                    return instance;

                lock (_instanceLock)
                {
                    if (instance == null)
                        instance = new Localization();
                    return instance;
                }
            }
            set { lock (_instanceLock) { instance = value; } }
        }

        protected Localization() : this(null)
        {
        }

        protected Localization(CultureInfo cultureInfo)
        {
            this.cultureInfo = cultureInfo;
            if (this.cultureInfo == null)
                this.cultureInfo = Locale.GetCultureInfo();
        }

        public event EventHandler CultureInfoChanged
        {
            add { lock (_lock) { this.cultureInfoChanged += value; } }
            remove { lock (_lock) { this.cultureInfoChanged -= value; } }
        }

        public virtual CultureInfo CultureInfo
        {
            get { return this.cultureInfo; }
            set
            {
                if (value == null || (this.cultureInfo != null && this.cultureInfo.Equals(value)))
                    return;

                this.cultureInfo = value;
                this.OnCultureInfoChanged();
            }
        }

        protected void RaiseCultureInfoChanged()
        {
            try
            {
                this.cultureInfoChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception) { }
        }

        protected virtual void OnCultureInfoChanged()
        {
            RaiseCultureInfoChanged();
            // this.Refresh();
        }

        // public Task AddDataProvider(IDataProvider provider)
        // {
        //     return DoAddDataProvider(provider);
        // }

        public bool IsSupportLanguage(CultureInfo cultureInfo)
        {
            throw new NotImplementedException();
        }

        public bool HasFeature(LocalizeFeature feature)
        {
            throw new NotImplementedException();
        }

        public bool HasFeatureKey(LocalizeFeature feature, string key)
        {
            throw new NotImplementedException();
        }
    }
}
