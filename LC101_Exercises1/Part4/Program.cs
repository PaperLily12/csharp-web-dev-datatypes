// See https://aka.ms/new-console-template for more information
string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
Console.WriteLine(sentence);
Console.WriteLine("What would you like to search for?");
string search = Console.ReadLine();
if (sentence.ToLower().IndexOf(search.ToLower()) != -1)
{
    Console.WriteLine("The word \"" + search + "\" is " + search.Length + " characters long and begins at index " + sentence.ToLower().IndexOf(search.ToLower()));
} else
{
    Console.WriteLine("Not found");
}