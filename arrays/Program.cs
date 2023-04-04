
string[] fruitBasket = { "apples", "bananas", "oranges" };

Console.WriteLine($"There are {fruitBasket.Length} fruit in your basket.");

for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}


fruitBasket[0] = "pine-apple";
fruitBasket[1] = "peaches";

for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}    

