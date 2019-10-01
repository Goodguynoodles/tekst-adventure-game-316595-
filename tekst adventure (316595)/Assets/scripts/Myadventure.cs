using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myadventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro,
        take1,
        deelnee,
        deelja,
        gameover,
    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            Showmainmenu();
        }

        switch (currentState)
        {
            case States.gameover:
                if (input == "gameover")
                {
                    Showmainmenu();
                }
                else
                {
                    Terminal.WriteLine("type gameover you moron");
                }

                break;
            case States.start:
                if (input == "start")
                {
                    StartIntro();
                }
                else if (input == "credits")
                {
                    Credits();
                }
                else
                {
                    Terminal.WriteLine("type start to begin");
                }

                break;

            case States.intro:

                if (input == "steal a car")
                {
                    Take1();
                }

                break;

            case States.take1:
                if (input == "laferrari")
                {
                    deathcar();
                }

                break;
        }
    }

    void Credits()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("koos van losenoord");
    }

    void ShowMainMenu()
    {
        Terminal.WriteLine("");
        Terminal.WriteLine("the adventure of the devil's");
        Terminal.WriteLine("");
        Terminal.WriteLine("it was a dark night the ");
        Terminal.WriteLine("darkest of them all");
        Terminal.WriteLine("    ");
        Terminal.WriteLine("and the devil's was on the run");
        Terminal.WriteLine("from the china");
        Terminal.WriteLine("");
    }

    void Showmainmenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("the adventure of the devil's");
        Terminal.WriteLine("");
        Terminal.WriteLine("it was a dark night the ");
        Terminal.WriteLine("darkest of them all");
        Terminal.WriteLine("    ");
        Terminal.WriteLine("and the devil's was on the run");
        Terminal.WriteLine("from the china");
        Terminal.WriteLine("");
        currentState = States.start;
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("it around 2 am and your in amsterdam");
        Terminal.WriteLine("in the center and it full of people");
        Terminal.WriteLine("running from china's special agents");
        Terminal.WriteLine("there about 5 meters behind you");
        Terminal.WriteLine("you have three option's");
        Terminal.WriteLine("you can run hide or steal a car");
        Terminal.WriteLine("");
        Terminal.WriteLine("> hide");
        Terminal.WriteLine("> run");
        Terminal.WriteLine("> steal a car");

        currentState = States.intro;
    }

    void Take1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you seen 2 cars one with a old lady");
        Terminal.WriteLine("but the car is all ready running");
        Terminal.WriteLine("or a laferrari next to her");
        Terminal.WriteLine("");
        Terminal.WriteLine("> laferrari");
        Terminal.WriteLine("> old lady's car");
        currentState = States.take1;
    }

    void deathcar()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("the car is locked and you get caught");
        Terminal.WriteLine("by the Chinese");
        Terminal.WriteLine("you get killed by the Chinese");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("type gameover");
        currentState = States.gameover;
    }

    void carlife()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
    }
}

