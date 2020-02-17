namespace Inheritance
{
    partial class Program
    {
        class Text : PresentationObject
        {
            public int FontSize { get; set; }
            public string FontName { get; set; }

            public void HyperLink(string url)
            {
                System.Console.WriteLine("Adding Hyperlink " + url);
            }
        }
    }
}
