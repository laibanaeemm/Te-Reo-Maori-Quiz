/* 
 * Display intro
 * 
 * 
 * 
 */

Console.WriteLine("Te Reo Maori Quiz!\n");

Console.WriteLine("- This quiz will test you on how well you know Te Reo Maori.");
Console.WriteLine("- If you are able to answer all 10 questions correctly, then you will win a star.");
Console.WriteLine("- Let's get started!\n\n");

string ans;
Console.WriteLine("Question 1: How do you say brown in Maori?");
ans = Console.ReadLine();
if (ans == "paraone")
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Wrong! Please try again");
}


Console.WriteLine("Question 2: What are the two ways you can say Black in Maori?");
ans = Console.ReadLine();
if (ans == "mangu pango")
{
    Console.WriteLine("Correct!");
}
else 
{
    Console.WriteLine("Wrong! Please try again");
}

Console.WriteLine("Question 3: How do you say purple in Maori");
ans = Console.ReadLine();
if (ans == "waiporoporo")
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Wrong! Please try again");
}

Console.WriteLine("Question 4: How do you say light green and dark green in Maori");
ans = Console.ReadLine();
if (ans == "karerarera and karikiuri") {
    Console.WriteLine("Correct!");
} 
else
{
    Console.WriteLine("Wrong! Please try again");
}


Console.WriteLine("Question 5: How do you say pink in Maori");
ans = Console.ReadLine();
if (ans == "mawhero") {
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Wrong! Please try again");
}

