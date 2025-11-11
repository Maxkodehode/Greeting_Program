using System;

public class WeekendRule : Contract
{
  public bool IsMatch(GreetingContext context)
  => context.HourOfDay >= 7 && context.HourOfDay < 12
    && context.Day == DayOfWeek.Saturday || context.Day == DayOfWeek.Sunday;

  public string GetGreeting(GreetingContext context)
    => $"[maroon]Happy Weekend, {context.UserName}! Time to relax.[/]";
}