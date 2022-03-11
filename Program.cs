/* Grace - AC118291
 * declare number of type int
 * introduction
 * prompt user for a number
 * read number from keyboard/console
 * check if the remainder of the number when divided by 2 is 0
 * if true then display it is positive
 * otherwise display it is negative
 */
int number;
Console.WriteLine("This program will ask you to enter a number and it will determine whether it is odd or even\n\n\n");
Console.WriteLine("Enter a number: ");
number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd");
}
