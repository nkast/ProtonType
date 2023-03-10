/************************************************************************

   AvalonDock

   Copyright (C) 2007-2013 Xceed Software Inc.

   This program is provided to you under the terms of the New BSD
   License (BSD) as published at http://avalondock.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up AvalonDock in Extended WPF Toolkit Plus at http://xceed.com/wpf_toolkit

   Stay informed: follow @datagrid on Twitter or Like facebook.com/datagrids

  **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Windows;
using System.Xml.Serialization;

namespace AvalonDock.Layout
{
    [Serializable]
    [XmlInclude(typeof(LayoutAnchorableFloatingWindow))]
    [XmlInclude(typeof(LayoutDocumentFloatingWindow))]
    public abstract class LayoutFloatingWindow : LayoutElement, ILayoutContainer
    {
        public LayoutFloatingWindow()
        { 

        }


        public abstract IEnumerable<ILayoutElement> Children { get; }

        public abstract void RemoveChild(ILayoutElement element);

        public abstract void ReplaceChild(ILayoutElement oldElement, ILayoutElement newElement);

        public abstract int ChildrenCount { get; }

        public abstract bool IsValid { get; }




    }
}
