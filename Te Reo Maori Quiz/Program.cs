/*
 * Display intro
 */

Console.WriteLine("Te Reo Maori Quiz!\n");

Console.WriteLine("- This quiz will test you on how well you know Te Reo Maori.");
Console.WriteLine("- The quiz will be seperated in 3 levels, with each level quizing you on a different topic in Maori.");
Console.WriteLine("- One more thing that you must remember is to have fun!");
Console.WriteLine("- Let's get started!\n");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Level 1: Colours");
Console.ReadLine();
Console.Clear();

string ans;
int score1 = 0;


    Console.WriteLine("Question 1: How do you say brown in Maori?");
    ans = Console.ReadLine();
    if (ans.ToLower() == "paraone")
    {
        Console.WriteLine("Correct!");
        score1 = score1 + 1; //score++; score += 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

    Console.WriteLine("\nQuestion 2: What are the two ways you can say Black in Maori?");
    ans = Console.ReadLine();
    if (ans.ToLower() == "mangu and pango")
    {
        Console.WriteLine("Correct!");
        score1 = score1 + 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

    Console.WriteLine("\nQuestion 3: How do you say purple in Maori");
    ans = Console.ReadLine();
    if (ans.ToLower() == "waiporoporo")
    {
        Console.WriteLine("Correct!");
        score1 = score1 + 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

    Console.WriteLine("\nQuestion 4: How do you say light green and dark green in Maori?");
    ans = Console.ReadLine();
    if (ans.ToLower() == "karerarera and karikiuri")
    {
        Console.WriteLine("Correct!");
        score1 = score1 + 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }


    Console.WriteLine("\nQuestion 5: How do you say pink in Maori");
    ans = Console.ReadLine();
    if (ans.ToLower() == "mawhero")
    {
        Console.WriteLine("Correct!");
        score1 = score1 + 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

    Console.WriteLine("\nQuestion 6: How do you say light blue in Maori?");
    ans = Console.ReadLine();
    if (ans.ToLower() == "orangitea")
    {
        Console.WriteLine("Correct!");
    score1 = score1 + 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

    Console.WriteLine("\nQuestion 7: How do you say grey in Maori?");
    ans = Console.ReadLine();
    if (ans.ToLower() == "kiwikiwi")
    {
        Console.WriteLine("Correct!");
        score1 = score1 + 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

    Console.WriteLine("\nQuestion 8: How do you say yellow in Maori?");
    ans = Console.ReadLine();
    if (ans.ToLower() == "kowhai")
    {
        Console.WriteLine("Correct!");
        score1 = score1 + 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

    Console.WriteLine("\nQuestion 9: How do you say magenta in Maori?");
    ans = Console.ReadLine();
    if (ans.ToLower() == "makurakura")
    {
        Console.WriteLine("Correct!");
    score1 = score1 + 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

    Console.WriteLine("\nQuestion 10: How do you say red in Maori?");
    ans = Console.ReadLine();
    if (ans.ToLower() == "whero")
    {
        Console.WriteLine("Correct!");
        score1 = score1 + 1;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

Console.WriteLine("\n\nCongratulations! You have finished the first level!\n");
Console.WriteLine("Your score on Level 1 is: " + score1);
Console.WriteLine("Press enter to go on to the next level");
Console.ReadLine();
Console.Clear();

int score2 = 0;

Console.WriteLine("Level 2: Animals");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Question 1: How do you say horse in Maori?");
ans = Console.ReadLine();
if (ans.ToLower() == "hoiho")
{
    Console.WriteLine("Correct!");
    score2 = score2 + 1;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine("\nQuestion 2: How do you say goat in Maori?");
ans = Console.ReadLine();
if (ans.ToLower() == "nanenane")
{
    Console.WriteLine("Correct!");
    score2 = score2 + 1;// adds one point to the scoreboard
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine("\nQuestion 3: How do you say dog in Maori?");
ans = Console.ReadLine();
if (ans.ToLower() == "kuri")
{

    Console.WriteLine("Correct!");
    score2 = score2 + 1;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine("\nQuestion 4: How do you say cat in Maori? ");
ans = Console.ReadLine();
if (ans.ToLower() == "ngeru")
{
    Console.WriteLine("Correct!");
    score2 = score2 + 1;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine("\nQuestion 5: How do you say hen in Maori");
ans = Console.ReadLine();
if (ans.ToLower() == "heihei")
{
    Console.WriteLine("Correct!");
    score2 = score2 + 1;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine("\nQuestion 6: How do you say rabbit in Maori?");
ans = Console.ReadLine();
if (ans.ToLower() == "rapeti")
{
    Console.WriteLine("Correct!");
    score2 = score2 + 1;
}
else
{
    Console.WriteLine("Wrong!");
}
