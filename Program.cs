using System;
using Spectre.Console;
public class Program
{
  static void Main(string[] args)
  {
    // Prompt for user name
    AnsiConsole.MarkupLine("[bold purple]Please Enter Your Name:[/]");
    var userName = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userName))
    {
      userName = "Guest";
    }

    // Prompt for birth month
    AnsiConsole.MarkupLine("[bold purple]Please Enter Your Birth Month (1-12):[/]");
    var birthMonth = Console.ReadLine();
    // Validate and parse birth month input
    if (!int.TryParse(birthMonth, out var birthMonthInt) || birthMonthInt < 1 || birthMonthInt > 12)
    {
      birthMonthInt = 1;
    }

    // Prompt for birth day
    AnsiConsole.MarkupLine("[bold purple]Please Enter Your Birth Day (1-31):[/]");
    var birthDay = Console.ReadLine();
    // Validate and parse birth day input
    if (!int.TryParse(birthDay, out var birthDayInt) || birthDayInt < 1 || birthDayInt > 31)
    {
      birthDayInt = 1;
    }
// Get the current date and time
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
    AnsiConsole.MarkupLine("[teal]\n-------------------------[/]");
    AnsiConsole.MarkupLine($"[lime]Current Time: {now.ToShortTimeString()} ({now.DayOfWeek}), {now.Day} of {now.ToString("MMMM")}[/]");
    AnsiConsole.MarkupLine("[teal]\n-------------------------[/]");
    AnsiConsole.MarkupLine(greeting);
    AnsiConsole.MarkupLine("[teal]\n-------------------------[/]");
    while (true)
    {
      var choice = AnsiConsole.Prompt(
          new SelectionPrompt<string>()
              .Title("[bold green]Greeting selection[/]")
              .AddChoices("BirthdayRule", "FridayRule", "WeekendRule", "MorningRule", "AfternoonRule", "EveningRule", "NightRule", "DefaultRule", "Exit")
      );
      switch (choice)
      {
        case "BirthdayRule":
          AnsiConsole.MarkupLine($"{new BirthdayRule().GetGreeting(context)}");
          break;
        case "FridayRule":
          AnsiConsole.MarkupLine($"{new FridayRule().GetGreeting(context)}");
          break;
        case "WeekendRule":
          AnsiConsole.MarkupLine($"{new WeekendRule().GetGreeting(context)}");
          break;
        case "MorningRule":
          AnsiConsole.MarkupLine($"{new MorningRule().GetGreeting(context)}");
          break;
        case "AfternoonRule":
          AnsiConsole.MarkupLine($"{new AfternoonRule().GetGreeting(context)}");
          break;
        case "EveningRule":
          AnsiConsole.MarkupLine($"{new EveningRule().GetGreeting(context)}");
          break;
        case "NightRule":
          AnsiConsole.MarkupLine($"{new NightRule().GetGreeting(context)}");
          break;
        case "DefaultRule":
          AnsiConsole.MarkupLine($"{new DefaultRule().GetGreeting(context)}");
          break;
        case "Exit":
          return;
      }
    }

  }
}