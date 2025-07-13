## Project - Habit Tracker Console application
**with Sqlite database backend & ADO.NET**

## References
Project description: https://thecsharpacademy.com/project/12/habit-logger  
Docs for ADO.NET: https://learn.microsoft.com/en-us/dotnet/standard/data/sqlite/?tabs=net-cli

![Screenshot of App](./screenshot.png)

## Sample user case
- User starts app
- User provides name
- Options:
  - retrieve stored habits 
  - insert habit
  - update previous habits bycount
  - delete single habit
  - exit application

## Feedback from code review
Reviewed by VocalNight: https://github.com/TheCSharpAcademy/CodeReviews.Console.HabitTracker/pull/307

>1- Find a way to clean the console after most operations, it can get quite messy if you don't.
>
>2- Find a way to hide/format the date time when time is not needed, instead of leaving it as 00:00:00:
>
>3- you left a Console.print somewhere in the code. This a minor thing, but make sure to take out all debug prints when you are doing a final code review


## Given requirements

- This is an application where you’ll log occurrences of a habit.
- This habit can't be tracked by time (ex. hours of sleep), only by quantity (ex. number of water glasses a day)
- Users need to be able to input the date of the occurrence of the habit
- The application should store and retrieve data from a real database
- When the application starts, it should create a sqlite database, if one isn’t present.
- It should also create a table in the database, where the habit will be logged.
- The users should be able to insert, delete, update and view their logged habit.
- You should handle all possible errors so that the application never crashes.
- You can only interact with the database using ADO.NET. You can’t use mappers such as Entity Framework or Dapper.
- Follow the DRY Principle, and avoid code repetition.
- Your project needs to contain a Read Me file where you'll explain how your app works. 

## Done list
- Make user dynamic -> add new prompt at start to provide a username - DONE
- Split up methods to separate files - DONE
- Fix printing to console - DONE
- Add some colour to messages - DONE
