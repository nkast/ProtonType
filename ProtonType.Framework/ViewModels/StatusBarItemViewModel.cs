﻿#region License
//   Copyright 2019 Kastellanos Nikolaos
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
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace nkast.ProtonType.Framework.ViewModels
{
    public class StatusBarItemViewModel : BaseViewModel
    {
        private string _name = null;
        private object _content = null;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        public object Content
        {
            get { return _content; }
            set
            {
                if (_content != value)
                {
                    _content = value;
                    RaisePropertyChanged(() => Content);
                }
            }
        }

        public StatusBarItemViewModel(string name)
        {
            this.Name = name;
        }
                
    }
}
