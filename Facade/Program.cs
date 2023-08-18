using Facade;

var twitterService = new TwitterAPIService("API_Key", "App_Secret");
twitterService.GetRecentTweets();