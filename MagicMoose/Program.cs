using MagicMoose;

Responses responses = new Responses();

string quit = "enter";
while (quit != "") {
Console.WriteLine("Ask me your question and I will answer!");
    quit = Console.ReadLine();
    if (quit != "")
    {
        Console.WriteLine(responses.GetResponse());
    }
}

Console.ReadLine();
