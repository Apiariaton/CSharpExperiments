using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExperiments
{

    class Program
    {

        static async Task Main(string[] args)
        {

            var pricerunnerScraper = new Scraper("https://www.pricerunner.com");
        
            var listOfGameTitles = new List<string>
            {
                "Catan",
                "Mattel UNO Card",
                "Pegasus Fungi"
            };

            foreach (var gameTitle in listOfGameTitles)
            {
                pricerunnerScraper.WebsiteUrl = string.Format("https://www.pricerunner.com/results?q={0}%20Board%20Game&suggestionsActive=true&suggestionClicked=false&suggestionReverted=false", gameTitle);
                Console.WriteLine("This game, {0}, costs: £",gameTitle);
                pricerunnerScraper.GetElement("/html/body/div[1]/div/div[1]/div[1]/div/div[5]/div/div/div[1]/a/div/div[2]/div[1]/div/span");
            }

        
        }


    }






}


