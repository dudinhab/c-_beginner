﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10 && daysUntilExpiration >= 6)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration <= 5 && daysUntilExpiration >= 2)
{
    discountPercentage = 10;
    Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days until expiration.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine(@$"Your subscription expires within a day!");
}
else if (daysUntilExpiration == 0)
{
    Console.Write("Your subscription has expired.");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}