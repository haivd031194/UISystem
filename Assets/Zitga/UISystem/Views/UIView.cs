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
using Loxodon.Framework.Views.Animations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Loxodon.Framework.Views
{
    [RequireComponent(typeof(RectTransform), typeof(CanvasGroup))]
    public class UIView: UIBehaviour, IUIView
    {
        private CanvasGroup canvasGroup;
        private RectTransform rectTransform;

        protected override void OnEnable()
        {
            base.OnEnable();
            OnVisibilityChanged();
        }

        protected override void OnDisable()
        {
            OnVisibilityChanged();
            base.OnDisable();
        }
        
        public virtual string Name
        {
            get => !IsDestroyed() && gameObject != null ? gameObject.name : null;
            set
            {
                if (IsDestroyed() || gameObject == null)
                    return;

                gameObject.name = value;
            }
        }

        public virtual Transform Parent => !IsDestroyed() && transform != null ? transform.parent : null;

        public virtual GameObject Owner => IsDestroyed() ? null : gameObject;

        public virtual Transform Transform => IsDestroyed() ? null : transform;

        public virtual RectTransform RectTransform
        {
            get
            {
                if (IsDestroyed())
                    return null;

                return rectTransform ? rectTransform : (rectTransform = GetComponent<RectTransform>());
            }
        }

        public virtual bool Visibility
        {
            get
            {
                GameObject o;
                return !IsDestroyed() && (o = gameObject) != null && o.activeSelf;
            }
            set
            {
                if (IsDestroyed() || gameObject == null)
                    return;

                if (gameObject.activeSelf == value)
                    return;

                gameObject.SetActive(value);
            }
        }

        public virtual IAnimation EnterAnimation { get; set; }

        public virtual IAnimation ExitAnimation { get; set; }

        public virtual float Alpha
        {
            get => !IsDestroyed() && gameObject != null ? CanvasGroup.alpha : 0f;
            set
            {
                if (!IsDestroyed() && gameObject != null) CanvasGroup.alpha = value;
            }
        }

        public virtual bool Interactable
        {
            get => !IsDestroyed() && gameObject != null && CanvasGroup.interactable;
            set
            {
                if (!IsDestroyed() && gameObject != null) CanvasGroup.interactable = value;
            }
        }

        public virtual CanvasGroup CanvasGroup
        {
            get
            {
                if (IsDestroyed())
                    return null;

                return canvasGroup ? canvasGroup : (canvasGroup = GetComponent<CanvasGroup>());
            }
        }

        [field: NonSerialized] public virtual IAttributes ExtraAttributes { get; } = new Attributes();

        protected virtual void OnVisibilityChanged()
        {
        }
    }
}