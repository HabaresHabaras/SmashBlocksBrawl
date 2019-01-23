using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    //DATATYPES
    // int / float / string / bool
    void Start()
    {
        //variable declaration
        string playerName;

        //variable assignment
        playerName = "Mr Pink";

        //show that to user
        print(playerName);

        // variable declaration + assignment
        // string playerName = "Mr Pink";
        string enemyName = "Miss Orange";

        //show that 
        print(enemyName);

        //energy
        float energy = 1.5f;  //f is needed when declaring floats, else the number will be considered a double and be given a huge ammount of decimal zeroes

        //num of lives
        int n = 10;

        //if player is alive
        bool isAlive = true;

        //Arithmetic operations 
        //Total score of a user
        int levelsCompleted = 10;
        int totalScore = levelsCompleted * 100;

        float total = 100 + 1.5f;

        int lives = 5 - 1;

        float parts = 100 / 50;

        float combination = (100 + 1.5f) * 10 / 100;

        print("The result for "+ playerName + " is " + combination);

        float celsius = 5;

        float fahreheit = celsius * 9/5 + 32;
        print("The result is " + fahreheit);





    }
}
