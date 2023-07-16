using State;

var travelMode = new DrivingMode();
var service = new DirectionService(travelMode);

var eta = service.GetETA();
var direction = service.GetDirection();

Console.WriteLine($"ETA : {eta} - Direction : {direction}");