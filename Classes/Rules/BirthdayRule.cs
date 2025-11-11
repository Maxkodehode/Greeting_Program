using System;
using Spectre.Console;


public class BirthdayRule : Contract
{
  public bool IsMatch(GreetingContext context)
  {
    bool birthDayMatch = context.CurrentMonth == context.BirthMonth && context.CurrentDay == context.BirthDay;
    return birthDayMatch;
  }
  public string GetGreeting(GreetingContext context)
  => $"[yellow]🎈🥳🎂Happy Birthday! 🎉{context.UserName}!🎉 Wishing you a fantastic day!🍰🎁🎆[/]";
}