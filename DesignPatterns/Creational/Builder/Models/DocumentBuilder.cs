namespace Builder.Models
{
    /*
     * Problem: 
     *    Birden fazla aşamadan oluşan bir obje inşa etmeniz gerekiyor. Bu aşamaları kullanarak nesneyi en ideal nasıl inşa edersiniz?
     */

    public interface IPageBuilder
    {
        void BuildHeader();
        void BuildContent();
        void BuildTable();
        void BuildFooter();
        void BuildMenu();
    }


    public class HtmlPageBuilder : IPageBuilder
    {
        private HTMLPage htmlPage = new HTMLPage();
        public HTMLPage Build()
        {
            return htmlPage;
        }
        public void BuildContent()
        {
            htmlPage.Content = "İçerik ok";
        }

        public void BuildFooter()
        {
            htmlPage.Footer = "Footer ok";
        }

        public void BuildHeader()
        {
            htmlPage.Header = "Başlık..ok..";
        }

        public void BuildMenu()
        {
            htmlPage.Menu = "Menü..ok..";

        }

        public void BuildTable()
        {
            htmlPage.Table = "Tablo..ok..";

        }
    }

    public class HTMLPage
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string Menu { get; set; }
        public string Footer { get; set; }
        public string Table { get; set; }
    }

    public class PageBuilder
    {
        public HTMLPage BuildHtmlPage()
        {
            HtmlPageBuilder htmlPageBuilder = new HtmlPageBuilder();
            htmlPageBuilder.BuildHeader();
            htmlPageBuilder.BuildContent();
            htmlPageBuilder.BuildFooter();
            htmlPageBuilder.BuildMenu();
            htmlPageBuilder.BuildTable();

            return htmlPageBuilder.Build();

        }
    }

}
