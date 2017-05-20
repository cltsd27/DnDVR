using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour {

    void Update()
    {
        // Debug.Log(rollDice());
    }

    static int rollDice()
    {
        return rollDice(20);
    }

    static int rollDice(int sides)
    {
        return Random.Range(0, sides);
    }
}
