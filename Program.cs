using GymSystem;
using System.Runtime.CompilerServices;

string tryAgain = "y";
void TryAgain()
{
    Console.WriteLine("Do you want another operation? (y/n)");
    Console.Write("Choice: ");
    tryAgain = Console.ReadLine();
}
void PrintSeparator()
{
    Console.WriteLine("-------------------------");
}
do
{
    Member member = new Member();
    Console.Write("Enter member's ID: ");
    member.id = Console.ReadLine();
    if (int.TryParse(member.id, out int id) && int.Parse(member.id) > 0)
    {
        member.id = id.ToString();
    }
    else
    {
        Console.WriteLine("Invalid ID, please enter member's ID");
        continue;
    }

    PrintSeparator();

    Console.Write("Enter member's name: ");
    member.name = Console.ReadLine();
    if (member.name is null || member.name == "")
    {
        Console.WriteLine("Please enter member's name");
        continue;
    }
    else
    {
        member.name = member.name.ToString();
    }

    PrintSeparator();

    Console.Write("Enter member's age: ");
    member.age = Console.ReadLine();
    if (int.TryParse(member.age, out int age) && int.Parse(member.age) >= 16 && int.Parse(member.age) <= 50)
    {
        member.age = age.ToString();
    }
    else
    {
        Console.WriteLine("Invalid age, please enter member's age");
        continue;
    }
    PrintSeparator();

    member.SetGender();

    PrintSeparator();

    member.SetMembershipType();

    PrintSeparator();

    member.PrintMemberInformation();

    PrintSeparator();

    TryAgain();
}
while (tryAgain == "y");