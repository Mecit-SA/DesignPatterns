using Command;

var history = new History();
var videoEditor = new VideoEditor();

var removeTextCommand = new RemoveTextCommand(videoEditor, history);
removeTextCommand.Execute();
Console.WriteLine(videoEditor.Text);

var undoCommand = new UndoCommand(history);
undoCommand.Execute();
Console.WriteLine(videoEditor.Text);

var changeContrastCommand = new ChangeContrastCommand(videoEditor, history, 0.7f);
changeContrastCommand.Execute();
Console.WriteLine(videoEditor.Contrast);

var undoCommand2 = new UndoCommand(history);
undoCommand2.Execute();
Console.WriteLine(videoEditor.Contrast);