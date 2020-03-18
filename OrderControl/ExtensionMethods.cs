using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale.ExtensionMethods
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// finds the parent of a body in xaml code
        /// </summary>
        /// <typeparam name="T"> Type </typeparam>
        /// <param name="element"></param>
        /// <returns> The parent </returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if(parent == null) return null;

            if (parent is T) return parent as T;

            return parent.FindAncestor<T>();
        }
    }
}
