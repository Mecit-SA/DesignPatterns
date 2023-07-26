using Strategy;

var algorithm = new AESAlgorithm();
var chatClient = new ChatClient(algorithm);

chatClient.Send("Hello");