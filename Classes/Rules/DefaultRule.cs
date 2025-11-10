using System;

public class DefaultRule : Contract
{
  public bool IsMatch(GreetingContext context)
    => true;

  public string GetGreeting(GreetingContext context)
    => $"Hello, {context.UserName}! Hope you're having a wonderful day!";
}