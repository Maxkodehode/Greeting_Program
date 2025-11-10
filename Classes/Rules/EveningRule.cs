using System;

public class EveningRule : Contract
{
  public bool IsMatch(GreetingContext context)
    => context.HourOfDay >= 18 && context.HourOfDay <= 23;

  public string GetGreeting(GreetingContext context)
    => $"Good evening, {context.UserName}!";
}