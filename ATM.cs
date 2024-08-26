using System;

public class HelloWorld
{
    static void Print(string message)
    {
        Console.WriteLine(message);
    }
    public static void Main(string[] args)
    {
            Print("ATM Simulator");

        int balance = 1000;

        while (true)
        {
            Print("\n1 - Check Balance");
            Print("2 - Deposit Money");
            Print("3 - Withdraw Money");
            Print("4 - Exit");

            Print("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Print($"Your balance is ₱{balance}");
            }
            else if (choice == 2)
            {
                Print("Enter the amount you want to deposit: ");
                int deposit = Convert.ToInt32(Console.ReadLine());
                balance += deposit;
                Print($"You have successfully deposited ₱{deposit}. Your new balance is ₱{balance}");
            }
            else if (choice == 3)
            {
                Print("Enter the amount you want to withdraw: ");
                int withdraw = Convert.ToInt32(Console.ReadLine());

                if (withdraw > balance)
                {
                    Print("Insufficient funds!");
                }
                else
                {
                    balance -= withdraw;
                    Print($"You have successfully withdrawn ₱{withdraw}. Your new balance is ₱{balance}");
                }
            }
            else if (choice == 4)
            {
                Print("Thank you for using the ATM. Goodbye!");
                break;
            }
            else
            {
                Print("Invalid choice. Please try again.");
            }
        }
    }
}