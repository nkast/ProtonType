#region License
//   Copyright 2019-2021 Kastellanos Nikolaos
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
#endregion

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using nkast.ProtonType.App.Views;
using nkast.ProtonType.Framework.Commands;
using nkast.ProtonType.Framework.ViewModels;

namespace nkast.ProtonType.App.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        ObservableCollection<nkast.ProtonType.Framework.ViewModels.ToolViewModel> _internalPanels = new ObservableCollection<nkast.ProtonType.Framework.ViewModels.ToolViewModel>();
        ObservableCollection<nkast.ProtonType.Framework.ViewModels.DocumentViewModel> _internalDocuments = new ObservableCollection<nkast.ProtonType.Framework.ViewModels.DocumentViewModel>();
        
        private ReadOnlyObservableCollection<nkast.ProtonType.Framework.ViewModels.DocumentViewModel> _readonyDocuments = null;
        private ReadOnlyObservableCollection<nkast.ProtonType.Framework.ViewModels.ToolViewModel> _readonyPanels = null;
        
        private void InitializePanels(MainWindow mainWindow)
        {
            mainWindow.dockingManager.DocumentClosing += dockingManager_DocumentClosing;
            mainWindow.dockingManager.AnchorableClosing += dockingManager_AnchorableClosing; 
            mainWindow.dockingManager.AnchorableHiding += dockingManager_AnchorableHiding;
        }

        void dockingManager_DocumentClosing(object sender, AvalonDock.DocumentClosingEventArgs e)
        {
            e.Cancel = true;
            var paneViewModel = (PaneViewModel)e.Document.Content;
            Controller.EnqueueAndExecute(new nkast.ProtonType.Framework.Commands.RemovePaneCmd(Site, paneViewModel));
        }
        void dockingManager_AnchorableClosing(object sender, AvalonDock.AnchorableClosingEventArgs e)
        {
            // AnchorableClosing is never called. By default AnchorableItems will get Hidden when the Close button is clicked.
            e.Cancel = true;
            var paneViewModel = (PaneViewModel)e.Anchorable.Content;
            Controller.EnqueueAndExecute(new nkast.ProtonType.Framework.Commands.RemovePaneCmd(Site, paneViewModel));
        }        
        void dockingManager_AnchorableHiding(object sender, AvalonDock.AnchorableHidingEventArgs e)
        {
            e.Cancel = true;
            var paneViewModel = (PaneViewModel)e.Anchorable.Content;
            //Controller.EnqueueAndExecute(new HidePaneCmd(Site, e.Anchorable));
            Controller.EnqueueAndExecute(new nkast.ProtonType.Framework.Commands.RemovePaneCmd(Site, paneViewModel));
        }

        public IEnumerable<nkast.ProtonType.Framework.ViewModels.ToolViewModel> Panels
        {
            get
            {
                if (_readonyPanels == null)
                {
                    _readonyPanels = new ReadOnlyObservableCollection<nkast.ProtonType.Framework.ViewModels.ToolViewModel>(_internalPanels);
                }
                return _readonyPanels;
            }
        }

        public IEnumerable<nkast.ProtonType.Framework.ViewModels.DocumentViewModel> Documents
        {
            get
            {
                if (_readonyDocuments == null)
                {
                    _readonyDocuments = new ReadOnlyObservableCollection<nkast.ProtonType.Framework.ViewModels.DocumentViewModel>(_internalDocuments);
                }
                return _readonyDocuments;
            }
        }

        public static readonly DependencyProperty ActiveContentProperty =
            DependencyProperty.Register("ActiveContent", typeof(object), typeof(MainViewModel));

        public PaneViewModel ActiveContent
        {
            get { return (PaneViewModel)GetValue(ActiveContentProperty); }
            //set { SetValue(ActiveContentProperty, value); }
        }
        
        internal void AddPane(nkast.ProtonType.Framework.ViewModels.ToolViewModel viewModel)
        {
            Controller.EnqueueAndExecute(new AddPaneCmd(this.Site, viewModel));
        }


    }

}
