using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResellButton : MonoBehaviour
{
    public Transform backpackSlot; // The Backpack slot that this button corresponds to
    public Buy buyscript;
    public int slotIndex;

    public int strawberryValue = 27;
    public int watermelonValue = 20;
    public int orangeValue = 10;
    public int lemonValue = 15;
    public int kiwiValue = 25;
    public int bananaValue = 5;
    public int cherryValue = 8;
    public int appleValue = 7;
    public int broccoliValue = 12;
    public int carrotValue = 10;
    public int garlicValue = 15;
    public int cornValue = 22;
    public int eggplantValue = 27;
    public int onionValue = 13;
    public int potatoValue = 19;
    public int pumpkinValue = 28;


    public void ResellObject()
    {
        int objectValue = 0; // Initialize objectValue to 0

        // Check if the slot has a child object
        if (backpackSlot.childCount > 0)
        {
            GameObject childObject = backpackSlot.GetChild(0).gameObject;

            // Determine the object's value based on its tag
            switch (childObject.tag)
            {
                case "Strawberry":
                    objectValue = strawberryValue;
                    break;
                case "Watermelon":
                    objectValue = watermelonValue;
                    break;
                case "Orange":
                    objectValue = orangeValue;
                    break;
                case "Lemon":
                    objectValue = lemonValue;
                    break;
                case "Kiwi":
                    objectValue = kiwiValue;
                    break;
                case "Banana":
                    objectValue = bananaValue;
                    break;
                case "Cherry":
                    objectValue = cherryValue;
                    break;
                case "Apple":
                    objectValue = appleValue;
                    break;
                case "Broccoli":
                    objectValue = broccoliValue;
                    break;
                case "Carrot":
                    objectValue = carrotValue;
                    break;
                case "Garlic":
                    objectValue = garlicValue;
                    break;
                case "Corn":
                    objectValue = cornValue;
                    break;
                case "Eggplant":
                    objectValue = eggplantValue;
                    break;
                case "Onion":
                    objectValue = onionValue;
                    break;
                case "Potato":
                    objectValue = potatoValue;
                    break;
                case "Pumpkin":
                    objectValue = pumpkinValue;
                    break;
            }

            // Destroy the object and return the money
            Destroy(childObject);
            buyscript.PlayerMoney += objectValue;
            buyscript.UpdateBalances();
            Debug.Log("Sold " + childObject.tag + " for $" + objectValue);
        }
        else
        {
            Debug.Log("No object to sell.");
        }
    }
}

