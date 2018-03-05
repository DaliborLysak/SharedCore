namespace Core.Providers
{
    public static class ProviderTypes
    {
        public enum DialogType
        {
            Save,
            Open,
            Folder
        }

        public enum FileManipulationOperationType
        {
            NotSet,
            Copy,
            Exec,
            Save,
            Load
        }

        public enum ExtensionType
        {
            Xml,
            Json,
            Text,
            Undefined
        }
    }
}
