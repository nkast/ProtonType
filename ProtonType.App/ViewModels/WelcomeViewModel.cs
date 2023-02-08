﻿#region License
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
using nkast.ProtonType.ViewModels.Base;
using nkast.ProtonType.Framework.Attributes;
using nkast.ProtonType.Framework.Commands;
using nkast.ProtonType.Framework.Helpers;

namespace nkast.ProtonType.App.ViewModels
{
    [DefaultView(typeof(nkast.ProtonType.App.Views.WelcomeView))]
    class WelcomeViewModel : DocumentViewModel
    {        
        public RelayCommand OpenCommand { get; set; }

        public WelcomeViewModel(MainViewModel mainViewModel)
            : base(mainViewModel, "Welcome")
        {
            OpenCommand = new RelayCommand(Open);


            return;
        }

        private void Open(object obj)
        {
            MainViewModel.Controller.EnqueueAndExecute(new RemovePaneCmd(MainViewModel.Site, this));

            var fileInfo = (nkast.ProtonType.App.FileDocuments.RecentFilesMgr.RecentFileInfo)obj;
            MainViewModel.FileOpen(fileInfo.FullFilename);
        }

        public List<nkast.ProtonType.App.FileDocuments.RecentFilesMgr.RecentFileInfo> RecentFiles
        {
            get { return this.MainViewModel.Model.RecentFilesMgr.RecentFiles; }
        }
        
    }
}
