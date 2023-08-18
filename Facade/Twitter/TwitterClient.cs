namespace Facade
{
    class TwitterClient
    {
        public List<Tweet> GetRecentTweets(string accessToken)
        {
            Console.WriteLine("Getting recent tweets");

            return new();
        }
    }
}