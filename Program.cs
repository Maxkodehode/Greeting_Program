using System;
public class Program
{
  static void Main(string[] args)
  {
// Prompt for user name
    Console.WriteLine("Please Enter Your Name:");
    var userName = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userName))
    {
      userName = "Guest";
    }
// Prompt for birth month
    Console.WriteLine("Please Enter Your Birth Month (1-12):");
    var birthMonth = Console.ReadLine();
// Validate and parse birth month input
    if (!int.TryParse(birthMonth, out var birthMonthInt) || birthMonthInt < 1 || birthMonthInt > 12)
    {
      birthMonthInt = 1;
    }
// Prompt for birth day
    Console.WriteLine("Please Enter Your Birth Day (1-31):");
    var birthDay = Console.ReadLine();
// Validate and parse birth day input
    if (!int.TryParse(birthDay, out var birthDayInt) || birthDayInt < 1 || birthDayInt > 31)
    {
      birthDayInt = 1;
    }

    DateTime now = DateTime.Now;
// Create the greeting context with user data and current time
    var context = new GreetingContext(

    UserName: userName,
    HourOfDay: now.Hour,
    Day: now.DayOfWeek,
    CurrentDay: now.Day,
    CurrentMonth: now.Month,
    BirthMonth: birthMonthInt,
    BirthDay: birthDayInt
  );
// Define the greeting rules in order of priority
  var rules = new List<Contract>
  {
      new BirthdayRule(),
      new WeekendRule(),
      new FridayRule(),
      new MorningRule(),
      new AfternoonRule(),
      new EveningRule(),
      new NightRule(),
      new DefaultRule()// Is redundant as it will always match
};
// Initialize the WhichGreeting with the defined rules
    var whichGreeting = new WhichGreeting(rules);
// Get the greeting based on the context
    var greeting = whichGreeting.GetGreeting(context);

    // Display the greeting
    Console.WriteLine("\n-------------------------");
    Console.WriteLine($"Current Time: {now.ToShortTimeString()} ({now.DayOfWeek}), {now.Day} of {now.ToString("MMMM")}");
    Console.WriteLine(greeting);
    Console.WriteLine("\n-------------------------");
  } 
 }