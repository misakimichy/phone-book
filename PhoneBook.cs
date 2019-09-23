using System;
using System.Collections.Generic;

class Phonebook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

  static void Main()
static void Main()
{
  Console.WriteLine("MAIN MENU");
  Console.WriteLine("Would you like to add a person to your phone book? ['Y' for yes, 'Enter' for no]");
  string answer = Console.ReadLine();
  if (answer == "Y" || answer == "y")
  {
    AddContact();
  }
  else
  {
    Console.WriteLine("Would you like to look up a number in your phone book? ['Y' for yes, 'Enter' for no]");
    string lookUpAnswer = Console.ReadLine();
    if (lookUpAnswer == "Y" || lookUpAnswer == "y")
    {
      LookUpContact();
    }
    else
    {
      Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
      string finishedAnswer = Console.ReadLine();
      if (finishedAnswer == "Y" || finishedAnswer == "y")
      {
        Console.WriteLine("Goodbye.");
      }
      else
      {
        Main();
      }
    }
  }
}
  static void AddContact()
{
  Console.WriteLine("NEW CONTACT");
  Console.WriteLine("Enter a new contact name");
  string name = Console.ReadLine();
  Console.WriteLine("Enter a new contact phone number");
  string number = Console.ReadLine();
  if (phoneNumbers.ContainsKey(name))
  {
    Console.WriteLine("That person is already in your phonebook. Their number is " + phoneNumbers[name]);
  }
  else
  {
    phoneNumbers.Add(name, number);
  }
  Main();
}

  static void LookUpContact()
  {
    //nothing here yet.
  }
}