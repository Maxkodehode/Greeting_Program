using System.Collections.Generic;
using System.Linq;


// Class to determine which greeting to use based on provided rules
public class WhichGreeting
{
  private readonly List<Contract> __rules;

  // Constructor to initialize the greeting rules
  public WhichGreeting(IEnumerable<Contract> rules)
  {
    __rules = rules.ToList();
  }
  // Determine the appropriate greeting based on the provided context
  public string GetGreeting(GreetingContext context)
  {
    // Iterate through each rule and return the greeting from the first matching rule
    foreach (var rule in __rules)
    {
      if (rule.IsMatch(context))
      {
        return rule.GetGreeting(context);
      }
    }

    // Is even more redundant than DefaultRule, but just in case no rules match, return a generic greeting
    return $"Hello, there {context.UserName} Hope you are well!";
  }
}
  