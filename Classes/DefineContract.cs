using System;

public interface Contract
{

  bool IsMatch(GreetingContext context);

  string GetGreeting(GreetingContext context);
}