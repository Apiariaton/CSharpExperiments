namespace CSharpExperiments
{

public class AIGameResearcher 
{

    public AIGameResearcher(string BoardGameName)
    {
        string boardGameName = BoardGameName;
        OpenAIQueryHandler openAIQueryHandler = new OpenAIQueryHandler(BoardGameName);
    }



    public async Task<GameResearchDto<GameResearchDto>> TryToObtainGameResearchObject()
    {
        var gameResearchObject = await openAIQueryHandler.ResearchGame();
        var gameExists = gameResearchObject["gameExists"];
        if (gameExists){
            return gameResearchObject;
        }
        else
        {
            throw Exception("No game was found to exist with this title...");
        }
    }


    public async Task<GameResearchDto<GameResearchDto>> ObtainGameResearchObject()
    {
        try
        {
            var gameResearchObject = await TryToObtainGameResearchObject();
            return gameResearchObject;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw exception;
        }
    }

    public async Task<GameResearchDto<GameResearchDto>> TryToStoreGameResearchObject()
    {
      


    }


    public async Task<GameResearchDto<GameResearchDto>> StoreGameResearchObject()
    {
        try
        {
            await TryToStoreGameResearchObject();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw exception;
        }
    }





}
}