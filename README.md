<img width="1998" height="1006" alt="image" src=Greeting_Program_plan.png/>

/*
1-Gather Input 

Prompt user for the Name (store as UserName)
Get Time/Date data (CurrentHour, CurrentDay, etc)
Create an information package (Context) with all the input data


2-Define Rules

Create a list of Rules (MorningRule, EveningRule, BirthdayRule, etc)
Make sure the order of the rules goes from least likely to most likely.


3-Desission On Which Rule

For each rule in Rule List:
If Rule IsMatch(Context) is true:
Greeting = Rule.GetGreeting(Context)
return Greeting

if no rule IsMatch:
Greeting = Default Message


4-Display Greeting

End
*/