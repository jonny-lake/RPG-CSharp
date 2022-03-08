using System;

namespace RPG2
{
    class Inputs
    {
        public static (bool, string) Commands(string input, bool notCommands, string currentStage)
        {
            string nextStage = "";
           switch(input)
            {
                case "goLeft":
                    if (currentStage == "left")
                    {
                        notCommands = false;
                        Outputs.TextOut("He can't go any further left.");
                        Console.WriteLine();
                    }
                    else {
                        notCommands = true;
                        nextStage = "left";
                    }
                    break;

                case "goRight":
                    if (currentStage == "right")
                    {
                        notCommands = false;
                        Outputs.TextOut("He can't go any further right.");
                        Console.WriteLine();
                    }
                    else
                    {
                        notCommands = true;
                        nextStage = "right";
                    }
                    break;

                case "door":
                        notCommands = true;
                        nextStage = "door";
                    break;

                case "commands":
                    Console.WriteLine();
                    string[] commandsList = { "goLeft: Examine the left side of the room.","goRight: Examine the right side of the room.","door: Examine the door.","commands: See list of commands."};
                    Outputs.ListOptions(commandsList);
                    Console.WriteLine();
                    notCommands = false;
                    break;

                default:
                    Outputs.TextOut("You must input a valid command. Use 'commands' to see valid commands.");
                    Console.WriteLine();
                    break;
            }
            return (notCommands, nextStage);
        }
    }
}