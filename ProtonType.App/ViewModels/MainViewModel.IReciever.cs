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

using System;
using nkast.ProtonType.Framework.ViewModels;

namespace nkast.ProtonType.App.ViewModels
{
    public partial class MainViewModel
    {
        #region Receiver 
        
        internal bool __AddPane(PaneViewModel pane)
        {
            if (pane is DocumentViewModel)
            {
                if (_internalDocuments.Contains((DocumentViewModel)pane))
                {
                    // TODO: show
                    return false;
                }
                else
                {
                    _internalDocuments.Add((DocumentViewModel)pane);
                    return true;
                }
            }
            else if (pane is ToolViewModel)
            {
                if (_internalPanels.Contains((ToolViewModel)pane))
                {
                    // TODO: show
                    return false;
                }
                else
                {
                    _internalPanels.Add((ToolViewModel)pane);
                    return true;
                }
            }
            else
            {
                throw new Exception("Unknown type of PaneViewModel");
            }
        }

        internal bool __RemovePane(PaneViewModel pane)
        {
            if (pane is DocumentViewModel)
            {
                if (!_internalDocuments.Contains((DocumentViewModel)pane))
                {
                    return false;
                }
                else
                {
                    _internalDocuments.Remove((DocumentViewModel)pane);
                    return true;
                }
            }
            else if (pane is ToolViewModel)
            {
                if (!_internalPanels.Contains((ToolViewModel)pane))
                {
                    return false;
                }
                else
                {
                    _internalPanels.Remove((ToolViewModel)pane);
                    return true;
                }
            }
            else
            {
                throw new Exception("Unknown type of PaneViewModel");
            }
        }

        #endregion
    }
}
