﻿#region License
//   Copyright 2020-2021 Kastellanos Nikolaos
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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using nkast.ProtonType.Framework.Modules;
using nkast.ProtonType.Framework.ViewModels;

namespace nkast.ProtonType.Logger
{
    public partial class LoggerModule : IModule
    {
        static protected ISiteViewModel _site;

        internal ISiteViewModel Site { get { return _site; } }
                
        #region IModule Members

        void IModule.Initialize(ISiteViewModel site)
        {
            _site = site;

            InitializeModuleUI();
        }
        
        #endregion
        
    }
}
