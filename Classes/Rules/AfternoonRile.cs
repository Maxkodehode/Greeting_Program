using System;

public class AfternoonRule : Contract
{
  public bool IsMatch(GreetingContext context)
  {
    return context.HourOfDay >= 12 && context.HourOfDay< 17;
  }
  
  public string GetGreeting(GreetingContext context)
{
  return $"Good Afternoon, {context.UserName}! Hope your day is going well!";   
}
}