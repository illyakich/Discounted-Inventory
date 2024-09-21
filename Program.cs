Console.WriteLine("The following items are avaliable: \n 1 - Rope \r \n 2 - Torches \r \n 3 - Climbing Equipment \r \n 4 - Clean Water \r \n 5 - Machete \r \n 6 - Canoe \r \n 7 - Food Supplies \r");
Console.Write("What's your name? ");
string response;

response = Convert.ToString(Console.ReadLine()); // i think they guy who made the book didnot declare that? im just a dumbass probably lol
string responseUP = response.ToUpper();

responseUP = responseUP switch
{
    "MARK" => "hey, 50% off for ya, what do you want to buy?",
    _ => "what do you want to buy? "
};

Console.WriteLine(responseUP);

string item;
int itemNumber;

int Rope = 10;
int Torches = 15;
int Climbing = 25;
int Water = 1;
int Machete = 20;
int Canoe = 200;
int Food = 1;

item = Convert.ToString(Console.ReadLine());

if (response.ToUpper() == "MARK")
{
    item = item switch
    {
        "1" => $"Will cost you {Rope / 2}",
        "2" => $"Will cost you {Torches / 2}",
        "3" => $"Will cost you {Climbing / 2}",
        "4" => $"Will cost you {Water / 2}",
        "5" => $"Will cost you {Machete / 2}",
        "6" => $"Will cost you {Canoe / 2}",
        "7" => $"Will cost you {Food / 2}",
        _ => "whar",
    };
}
else
{
    item = item switch
    {
        "1" => $"Will cost you {Rope}",
        "2" => $"Will cost you {Torches}",
        "3" => $"Will cost you {Climbing}",
        "4" => $"Will cost you {Water}",
        "5" => $"Will cost you {Machete}",
        "6" => $"Will cost you {Canoe}",
        "7" => $"Will cost you {Food}",
        _ => "whar",
    };
}
Console.WriteLine(item);
// lmfao this took me like an hour and this shi was supposed to be easy, though im a dumbass and this code is extremely unoptimised but who gives a shit right? hope they future me can fix this shit of a code.