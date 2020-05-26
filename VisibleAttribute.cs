using System;

namespace KinderGarten.Views
{
    public class VisibleAttribute : Attribute
    {
        public bool IsVisible { get; }
        public VisibleAttribute(bool isVisible)
        {
            IsVisible = isVisible;
        }
    }
}