using System;
using System.Windows;
using nkast.ProtonType.Framework.Modules;

namespace nkast.ProtonType.Framework.Modules
{
    abstract public class ModuleBase : DependencyObject, IModule
    {
        #region IModule Members

        protected ISiteViewModel Site { get; private set; }

        public virtual void Initialize(ISiteViewModel site)
        {
            this.Site = site;
        }
        #endregion
    }
}
