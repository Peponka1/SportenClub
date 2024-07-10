using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsClubManagement
{
    class Program
    {
        static Club club = new Club("Elite Sports Club", "123 Sports Avenue", "John Doe");

        static void Main(string[] args)
        {
            while (true)
            {
                ShowMainMenu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddMember();
                        break;
                    case 2:
                        RemoveMember();
                        break;
                    case 3:
                        SearchMember();
                        break;
                    case 4:
                        ListAllMembers();
                        break;
                    case 5:
                        AddCoach();
                        break;
                    case 6:
                        RemoveCoach();
                        break;
                    case 7:
                        AddTrainingSession();
                        break;
                    case 8:
                        RemoveTrainingSession();
                        break;
                    case 9:
                        AddEvent();
                        break;
                    case 10:
                        RemoveEvent();
                        break;
                    case 11:
                        GenerateActivityReport();
                        break;
                    case 12:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. Remove Member");
            Console.WriteLine("3. Search Member by Name");
            Console.WriteLine("4. List All Members");
            Console.WriteLine("5. Add Coach");
            Console.WriteLine("6. Remove Coach");
            Console.WriteLine("7. Add Training Session");
            Console.WriteLine("8. Remove Training Session");
            Console.WriteLine("9. Add Event");
            Console.WriteLine("10. Remove Event");
            Console.WriteLine("11. Generate Activity Report");
            Console.WriteLine("12. Exit");
        }

        static void AddMember()
        {
            Console.WriteLine("Enter Member ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Full Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Membership Type:");
            string type = Console.ReadLine();
            Console.WriteLine("Is Active (true/false):");
            bool isActive = bool.Parse(Console.ReadLine());

            club.AddMember(new Member(id, name, age, type, isActive));
            Console.WriteLine("Member added successfully.");
        }

        static void RemoveMember()
        {
            Console.WriteLine("Enter Member ID to remove:");
            string id = Console.ReadLine();
            club.RemoveMember(id);
            Console.WriteLine("Member removed successfully.");
        }

        static void SearchMember()
        {
            Console.WriteLine("Enter Member Name to search:");
            string name = Console.ReadLine();
            var members = club.SearchMemberByName(name);
            if (members.Count > 0)
            {
                Console.WriteLine("Members found:");
                members.ForEach(m => Console.WriteLine(m.ToString()));
            }
            else
            {
                Console.WriteLine("No members found with the given name.");
            }
        }

        static void ListAllMembers()
        {
            club.ListAllMembers();
        }

        static void AddCoach()
        {
            Console.WriteLine("Enter Coach ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Full Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Specialization:");
            string specialization = Console.ReadLine();

            club.AddCoach(new Coach(id, name, specialization));
            Console.WriteLine("Coach added successfully.");
        }

        static void RemoveCoach()
        {
            Console.WriteLine("Enter Coach ID to remove:");
            string id = Console.ReadLine();
            club.RemoveCoach(id);
            Console.WriteLine("Coach removed successfully.");
        }

        static void AddTrainingSession()
        {
            Console.WriteLine("Enter Session ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Coach ID:");
            string coachID = Console.ReadLine();
            Console.WriteLine("Enter Date (yyyy-mm-dd):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Duration (in minutes):");
            int duration = int.Parse(Console.ReadLine());

            club.AddTrainingSession(new TrainingSession(id, coachID, date, duration));
            Console.WriteLine("Training session added successfully.");
        }

        static void RemoveTrainingSession()
        {
            Console.WriteLine("Enter Session ID to remove:");
            string id = Console.ReadLine();
            club.RemoveTrainingSession(id);
            Console.WriteLine("Training session removed successfully.");
        }

        static void AddEvent()
        {
            Console.WriteLine("Enter Event ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Event Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Date (yyyy-mm-dd):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Location:");
            string location = Console.ReadLine();

            club.AddEvent(new Event(id, name, date, location));
            Console.WriteLine("Event added successfully.");
        }

        static void RemoveEvent()
        {
            Console.WriteLine("Enter Event ID to remove:");
            string id = Console.ReadLine();
            club.RemoveEvent(id);
            Console.WriteLine("Event removed successfully.");
        }

        static void GenerateActivityReport()
        {
            club.GenerateActivityReport();
        }
    }
}
