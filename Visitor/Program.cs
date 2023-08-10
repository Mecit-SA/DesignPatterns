using Visitor;

var file = WavFile.Read(string.Empty);
file.Execute(new ReduseNoiseOperation());
file.Execute(new AddReverbOperation());
file.Execute(new NormalizeOperation());