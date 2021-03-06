﻿using Core.Providers;

namespace CoreIO.Manipulation
{
    internal class Load : FileDataProcess, IFileManipulationMethod
    {
        public IFileManipulationData Manipulate<T>(IFileManipulationData data) where T : IFileManipulationData
        {
            return Manipulate<T>(data, ProviderTypes.DialogType.Open);
        }
    }
}
