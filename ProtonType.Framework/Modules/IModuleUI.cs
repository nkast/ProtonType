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

using System.Collections.Generic;
using nkast.ProtonType.Framework.ViewModels;

namespace nkast.ProtonType.Framework.Modules
{
    public interface IModuleUI : IModule
    {
        IEnumerable<MenuViewModel> Menus { get; }
        IEnumerable<ToolbarViewModel> Toolbars { get; }
        IEnumerable<StatusBarItemViewModel> StatusBars { get; }

    }
    
}
