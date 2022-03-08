using System;
namespace RPG2
{
    class SceneDescription
    {
        public string Description { get; set; }
        public SceneDescription(string description)
        {
            Description = description;
        }
    }

    class Start
    {
        public static (string, string) StartText()
        {
            // Opening lines.
            var _startText = new SceneDescription("UNKNOWN: I wish I had ended it that first day, that first opportunity. Why the f*ck should I breath this air anymore. One poison breath at a time for five long years. Five years into this hell and still no way out. It's been so long now it shouldn't matter. I've thought too long. Thought too far, too deep. I'm tired. So fucking tired that sometimes I can't even remember who I am. Can't remember my own f**king name.");

            // Opening lines continued.
            var _namePrompt = new SceneDescription("What was it again? Come on. Think.");

            // Print opening line, _startText.
            Outputs.TextOut(_startText.Description);
            // Print name prompt, _namePrompt.
            Outputs.TextOut(_namePrompt.Description);

            // Create new protagonist and assign name.
            var protagonist = new Protagonist(Console.ReadLine());
            // Extra line for space.
            Console.WriteLine();

            // Create string array for name prompt response.
            string[] _nameresponse = { protagonist.NarrationName + ": Such a stupid name. " + protagonist.Name + ".", "I pity the Gods, naming us animals. Breathing life into us with an assignment, like we even matter. Like lambs to the slaughter in this life. Probably in the next too." };

            // Print response to name prompt.
            Outputs.ListOptions(_nameresponse);
            return (protagonist.Name, protagonist.NarrationName);
        }
    }

    class FirstRoom
    {
        public static void AfterIntro(string proName, string narName)
        {
            string[] _AfterIntro = { "NARRATOR: One slice of light, served graciously from the heavens, it pours over them. They are slouched over themself, limp. One hollow breath at a time, they live. Their will keeps them. ", "The door ahead taunts them. LOCKED from the outside, it is kept by IT.", "A beat.", "A cluttering can be heard across the great divide. They fall towards the iron gate as if to feel noticed by it. The letter box opens its mouth, and spits its facetious gift.", "A rusty philips head from the gods, a note pasted to it. They read to themself:", narName + ": Six digits to freedom. Left to right, decide your destiny." };

            string[] screwProperties = { "red", "short" };
            var screwDriver = new ItemCreator("PHILLIPS", "A Phillips screwdriver has a head with pointed edges in the shape of a cross, which fit neatly into the cross slots of a Phillips screw.", screwProperties, true);

            // Numpad Layout
            //.------------.
            //|[N][/][*][-]|
            //|[7][8][9]|+||
            //|[4][5][6]|_||
            //|[1][2][3]| ||
            //|[ 0  ][.]|_||
            //'------------'
            //
            Outputs.ListOptions(_AfterIntro);
            bool doorLocked = true;
            string currentStage = "center";
            while (doorLocked)
            {
                // Main mechanics for handling inputs
                bool notCommands = false;
                string nextStage = "";
                while (!notCommands)
                {
                    (notCommands, nextStage) = Inputs.Commands(Console.ReadLine(), notCommands, currentStage);
                }
                // end main mechanics.
                switch (nextStage)
                {
                    case "right":
                        currentStage = "right";
                        string[] rightOption = { "Right is working.", "Good work." };
                        Outputs.ListOptions(rightOption);
                       
                        doorLocked = true;
                        break;

                    case "left":
                        currentStage = "left";
                        string[] leftOption = { "Left is working.", "Good work." };
                        Outputs.ListOptions(leftOption);
                        doorLocked = true;
                        break;

                    case "door":
                        currentStage = "door";
                        if (screwDriver.Found)
                        {
                            string[] doorOption1 = { ".------------.", "|[N][/][*][-]|", "|[7][8][9]|+||", "|[4][5][6]|_||", "|[1][2][3]| ||", "|[ 0  ][.]|_||", "'------------'" };
                            Outputs.quickOut(doorOption1);
                            Outputs.TextOut("Enter the code:");
                            string doorCode = Console.ReadLine();

                            switch (doorCode)
                            {
                                case "138079":
                                    doorLocked = false;
                                    Outputs.TextOut("Game Complete.");
                                    break;
                                default:
                                    Outputs.TextOut("Incorrect Pin");
                                    doorLocked = true;
                                    break;
                            }
                        }

                        break;
                }
            }
        }
    }
}