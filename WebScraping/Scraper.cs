using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;
using HtmlAgilityPack;

namespace CSharpExperiments
{

    class Scraper
    {

        public string websiteUrl = "";

        public Scraper(string newWebsiteUrl) 
        {
            websiteUrl = newWebsiteUrl;
        }

        public string WebsiteUrl
        {
            get { return websiteUrl; }
            set { websiteUrl = value; }
        }

        public string TryToGetElement(string xPathString)
        {

            HtmlWeb htmlWeb = new HtmlWeb();
            var htmlDoc = htmlWeb.Load(websiteUrl);
            var singleElementContent = htmlDoc.DocumentNode.SelectSingleNode(xPathString).InnerText;
            Console.WriteLine(singleElementContent);

            return singleElementContent;
        }

        public string GetElement(string xPathString)
        {
            try {
                
                var elementContent = TryToGetElement(xPathString);
                return elementContent;

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception);
                throw exception;

            }
        }


        public List<string> TryToGetElements(string xPathString)
        {

            HtmlWeb htmlWeb = new HtmlWeb();
            var htmlDoc = htmlWeb.Load(websiteUrl);
            var multipleElementContent = htmlDoc.DocumentNode.SelectNodes(xPathString);
            var listOfMultipleElements = new List<string>{};

            foreach (var element in multipleElementContent)
            {

                listOfMultipleElements.Add(element.InnerText);
                Console.WriteLine(element.InnerText);

            }


            return listOfMultipleElements;

        } 


        public List<string> GetElements(string xPathString)
        {
            try {
                
                var elementContent = TryToGetElements(xPathString);
                return elementContent;

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception);
                throw exception;

            }
        }





  
    }

}