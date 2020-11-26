﻿/*
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
using System.Globalization;
using Cysharp.Threading.Tasks;
using Loxodon.Framework.Data;
using UnityEngine;

namespace Loxodon.Framework.Localizations
{
    public sealed class Localization
    {
        private static readonly object _instanceLock = new object();
        private static Localization instance;

        private readonly object _lock = new object();
        private CultureInfo cultureInfo;
        private EventHandler cultureInfoChanged;

        private readonly LocalizeDataProvider dataProvider;

        public static Localization Current
        {
            get
            {
                if (instance != null)
                    lock (_instanceLock)
                    {
                        return instance;
                    }

                lock (_instanceLock)
                {
                    if (instance == null)
                        instance = new Localization();
                    return instance;
                }
            }
            set { lock (_instanceLock) { instance = value; } }
        }

        private Localization() : this(null, new ResourceDataProvider())
        {
        }

        private Localization(CultureInfo cultureInfo, IDataProvider dataProvider)
        {
            this.cultureInfo = cultureInfo ?? Locale.GetCultureInfo();

            this.dataProvider = new LocalizeDataProvider(dataProvider, this);
        }

        public event EventHandler CultureInfoChanged
        {
            add { lock (_lock) { this.cultureInfoChanged += value; } }
            remove { lock (_lock) { this.cultureInfoChanged -= value; } }
        }

        public CultureInfo CultureInfo
        {
            get { return this.cultureInfo; }
            set
            {
                if (value == null || (this.cultureInfo != null && this.cultureInfo.Equals(value)))
                    return;

                this.dataProvider.ClearData();
                
                this.cultureInfo = value;
                this.OnCultureInfoChanged();
            }
        }

        public UniTask<string> Get(string category, string key)
        {
            return dataProvider.Get(category, key);
        }

        private void RaiseCultureInfoChanged()
        {
            try
            {
                Debug.Log("language: " + this.cultureInfo.Name);
                this.cultureInfoChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void OnCultureInfoChanged()
        {
            RaiseCultureInfoChanged();
        }

    }
}
