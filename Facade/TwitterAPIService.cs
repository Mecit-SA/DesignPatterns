namespace Facade
{
    /// <summary>
    /// Facade Service
    /// </summary>
    class TwitterAPIService
    {
        private readonly string _apiKey;
        private readonly string _appSecret;

        public TwitterAPIService(string apiKey, string appSecret)
        {
            _apiKey = apiKey;
            _appSecret = appSecret;
        }

        public List<Tweet> GetRecentTweets()
        {
            var accessToken = GetAccessToken();
            var client = new TwitterClient();
            return client.GetRecentTweets(accessToken);
        }

        private string GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken(_apiKey, _appSecret);
            var accessToken = oauth.GetAccessToken(requestToken);
            return accessToken;
        }
    }
}