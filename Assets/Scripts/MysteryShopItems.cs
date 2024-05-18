using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MysteryShopItems : MonoBehaviour


{
    public GameObject[] gameObjectsToEnable;
    public GameObject[] standInGameObjectsToDisable;
    private int currentIndex = 0;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (currentIndex < gameObjectsToEnable.Length && timer >= 20f)
        {
            EnableNextPairOfGameObjects();
            DisableNextPairOfStandInGameObjects();
            timer = 0f;
        }
    }

    void EnableNextPairOfGameObjects()
    {
        gameObjectsToEnable[currentIndex].SetActive(true);
        gameObjectsToEnable[currentIndex + 1].SetActive(true);
        currentIndex += 2;
    }

    void DisableNextPairOfStandInGameObjects()
    {
        if (currentIndex > 1)
        {
            standInGameObjectsToDisable[currentIndex - 2].GetComponent<SpriteRenderer>().enabled = false;
            standInGameObjectsToDisable[currentIndex - 1].GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
