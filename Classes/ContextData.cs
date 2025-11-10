using System;

public record GreetingContext (
string UserName,
int HourOfDay,
DayOfWeek Day,
int CurrentDay,
int CurrentMonth,
int BirthMonth,
int BirthDay
);
