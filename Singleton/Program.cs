using Singleton;

var logger = Logger.GetInstance("default.txt");
var logger2 = Logger.GetInstance("file.txt");
var logger3 = Logger.GetInstance("file2.txt");
var logger4 = Logger.GetInstance("file.txt");
var logger5 = Logger.GetInstance("file.txt");

Console.WriteLine("Instance Count:" + Logger.InstanceCount);