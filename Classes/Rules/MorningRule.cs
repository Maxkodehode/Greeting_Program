using System;

public class MorningRule : Contract
{
  public bool IsMatch(GreetingContext context)
    => context.HourOfDay >= 5 && context.HourOfDay < 12;

  public string GetGreeting(GreetingContext context)
    => $"Good Morning, {context.UserName}! Have a great day!";  
}