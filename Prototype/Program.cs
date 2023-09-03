using Prototype;

var timeline = new Timeline();
var menu = new ContextMenu(timeline);

var txt1 = new Text("Text 1 test");
timeline.Add(txt1);

menu.Duplicate(txt1);

timeline.Print();