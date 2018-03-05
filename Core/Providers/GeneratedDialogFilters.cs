namespace Core.Providers
{
    public class DialogJsonFilter : DialogFilter
    {
        public DialogJsonFilter()
        {
            Filter = "Json Files|*.json";
        }
    }

    public class DialogXmlFilter : DialogFilter
    {
        public DialogXmlFilter()
        {
            Filter = "Xml Files|*.xml";
        }
    }

    public class DialogTextFilter : DialogFilter
    {
        public DialogTextFilter()
        {
            Filter = "Text Files|*.txt";
        }
    }

}