using Spectre.Console;

namespace HabitTracker.vagabundoo;

internal class UserInterface(string connectionString, string userName)
{
    private readonly HabitController _habitController = new(connectionString, userName);
    internal void MainMenu()
    {
        while (true)
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOption>()
                    .Title("What do you want to do next?")
                    .AddChoices(Enum.GetValues<MenuOption>()));

            switch (choice)
            {
                case MenuOption.InsertHabit:
                    Console.Clear();
                    _habitController.InsertHabit();
                    break;
                case MenuOption.SeeHabits:
                    Console.Clear();
                    _habitController.SeeHabits();
                    break;
                case MenuOption.UpdateHabit:
                    Console.Clear();
                    _habitController.UpdateHabit();
                    break;
                case MenuOption.RemoveHabit:
                    Console.Clear();
                    _habitController.RemoveHabit();
                    break;
                case MenuOption.ExitApplication:
                    Console.Clear();
                    AnsiConsole.MarkupLine("[green]Goodbye![/]");
                    return;
            }

        }
    }
}