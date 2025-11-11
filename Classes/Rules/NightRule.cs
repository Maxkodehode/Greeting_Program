using System;

public class NightRule : Contract
{
  public bool IsMatch(GreetingContext context)
  {
    return context.HourOfDay >= 0 || context.HourOfDay < 5;
  }

  public string GetGreeting(GreetingContext context)
  {
    return $"[blue]Burning the midnight oil i see, {context.UserName} have a nice night![/]";
  }
}