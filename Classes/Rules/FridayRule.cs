public class FridayRule : Contract
{
  public bool IsMatch(GreetingContext context)
    => context.Day == DayOfWeek.Friday && context.HourOfDay >= 15 && context.HourOfDay < 23;

  public string GetGreeting(GreetingContext context)
    => $"It's friday! {context.UserName}! Enjoy your weekend!";
}