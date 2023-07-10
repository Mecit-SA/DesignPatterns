using Memento;

// create the originator and caretaker
var document = new Document();
var history = new History();

// store the initialstate
history.Push(document.CreateState());
Console.WriteLine(document);

// make some changes and store the state
document.Content = "Test 1";
history.Push(document.CreateState());
Console.WriteLine(document);

// make some changes and store the state
document.FontSize = 22;
history.Push(document.CreateState());
Console.WriteLine(document);

// make last change
document.Content = "Test 2";
Console.WriteLine(document);

// Undo
document.RestoreState(history.Pop());
Console.WriteLine(document);

// Undo
document.RestoreState(history.Pop());
Console.WriteLine(document);

// Undo
document.RestoreState(history.Pop());
Console.WriteLine(document);

// Undo
document.RestoreState(history.Pop());
Console.WriteLine(document);