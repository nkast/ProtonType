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
using tainicom.ProtonType.Framework.Modules;

namespace tainicom.ProtonType.Logger.Contracts
{
    public interface IModuleLogger : IModule
    {
        void LogError(IModule source, string errorCode, string description, string filename, string fragmentIdentifier);
        void LogWarning(IModule source, string errorCode, string description, string filename, string fragmentIdentifier);
        void LogMessage(IModule source, string message);
    }
}