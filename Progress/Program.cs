Console.CursorVisible=false;
Console.WriteLine("Task in progress...");
Console.BackgroundColor=ConsoleColor.White;
String word = " ";
int count = 20;
int delayMilliseconds = 200;
for (int i = 0; i < count-1; i++)
{
    Console.Write(word);
    await Task.Delay(delayMilliseconds);
}
Console.WriteLine(word);
Console.BackgroundColor = ConsoleColor.Black;
Console.Write("Finished!");
