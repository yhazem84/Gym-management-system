using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GymSystem
{
    internal class Member
    {
        public string? id;
        public string? name;
        public string? age;

        public Gender gender;
        public MembershipType membershipType;
        public int membershipPrice;

        public void SetGender()
        {
            Console.WriteLine("Choose Gender: ");
            Console.WriteLine("1.Male");
            Console.WriteLine("2.Female");
            Console.Write("Choice: ");
            string? choice = Console.ReadLine();
            int integerChoice = 0;
            if (int.TryParse(choice, out int genderr) && choice is not null && choice == "1" || choice == "2")
            {
                integerChoice = int.Parse(choice);
            }
            else
            {
                Console.WriteLine("Please enter one of the viewed choices");
            }

                if (integerChoice == 1)
                {
                    gender = Gender.Male;
                }
                else if (integerChoice == 2)
                {
                    gender = Gender.Female;
                }
           
        }
        public void SetMembershipType()
        {
            Console.WriteLine("Choose Membership Type: ");
            Console.WriteLine("1.Standard");
            Console.WriteLine("2.Premium");
            Console.Write("Choice: ");
            string? choice = Console.ReadLine();
            int type = 0;
            if (int.TryParse(choice, out int typee) && choice is not null && choice == "1" || choice == "2")
            {
                type = int.Parse(choice);
            }
            else
            {
                Console.WriteLine("Please enter one of the viewed choices");
            }

            if (type == 1)
            {
                membershipType = MembershipType.Standard;
                membershipPrice = 500;
            }
            else if (type == 2)
            {
                membershipType = MembershipType.Premium;
                membershipPrice = 700;
            }

        }

        public void PrintMemberInformation()
        {
            Console.WriteLine("===== Member Data =====");
            Console.WriteLine($"Id: {id} \nName: {name} \nAge: {age} \nGender: {gender} \nMembership Type: {membershipType} \nMembership Price: {membershipPrice}");
        }
    }

    
}
