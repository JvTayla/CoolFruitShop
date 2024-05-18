using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Buy : MonoBehaviour
{
    private const double V = 0.75;
    public TextMeshProUGUI ShopBalance;
    public TextMeshProUGUI ChestBalance;
    public TextMeshProUGUI BackPackBalance;

    public Transform[] BackpackSlots;
    private int LastPoint = -1;
   

    private Vector3 size = new Vector3((float)V, (float)V, 2);

    public int PlayerMoney = 100;

    public ResellButton[] resellButtons;

    public int ChestSlotResaleValue = 15; // Resell value of each chest slot


    public void UpdateBalances()
    {
        ShopBalance.text = "$" + PlayerMoney.ToString();
        ChestBalance.text = "$" + PlayerMoney.ToString();
        BackPackBalance.text = "$" + PlayerMoney.ToString();
    }

    private int FindLowestFreeSlot()
    {
        for (int i = 0; i < BackpackSlots.Length; i++)
        {
            if (BackpackSlots[i].childCount == 0)
            {
                return i;
            }
        }
        return -1;
    }

    private void Start()
    {
        StartCoroutine(AddMoneyOverTime());
    }

    private IEnumerator AddMoneyOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(30f); // Wait for 30 seconds
            PlayerMoney += 20; // Add $20 to player's money
            UpdateBalances(); // Update the displayed balances
        }
    }

    #region Strawberry
    [Header("Strawberry")]
    public int StrawberryPrice = 27;
    public GameObject strawberry;

    public void BuyStrawberry()
    {
        if (PlayerMoney >= StrawberryPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedStrawberry = Instantiate(strawberry, freeSlot.position, Quaternion.identity, freeSlot);
                clonedStrawberry.transform.localScale = size;
                clonedStrawberry.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedStrawberry.AddComponent<DragAndDrop>();

                PlayerMoney -= StrawberryPrice;
                UpdateBalances();
                Debug.Log("Added Strawberry to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the strawberry.");
        }
    }


    #endregion

    #region Watermelon
    [Header("Watermelon")]
    public int WatermelonPrice = 20;
    public GameObject watermelon;

    public void BuyWatermelon()
    {
        if (PlayerMoney >= WatermelonPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedWatermelon = Instantiate(watermelon, freeSlot.position, Quaternion.identity, freeSlot);
                clonedWatermelon.transform.localScale = size;
                clonedWatermelon.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedWatermelon.AddComponent<DragAndDrop>();

                PlayerMoney -= WatermelonPrice;
                UpdateBalances();
                Debug.Log("Added Watermelon to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the watermelon.");
        }
    }
    #endregion

    #region Orange
    [Header("Orange")]
    public int OrangePrice = 10;
    public GameObject orange;

    public void BuyOrange()
    {
        if (PlayerMoney >= OrangePrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedOrange = Instantiate(orange, freeSlot.position, Quaternion.identity, freeSlot);
                clonedOrange.transform.localScale = size;
                clonedOrange.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedOrange.AddComponent<DragAndDrop>();

                PlayerMoney -= OrangePrice;
                UpdateBalances();
                Debug.Log("Added Orange to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the orange.");
        }
    }
    #endregion

    #region Lemon
    [Header("Lemon")]
    public int LemonPrice = 15;
    public GameObject lemon;

    public void BuyLemon()
    {
        if (PlayerMoney >= LemonPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedLemon = Instantiate(lemon, freeSlot.position, Quaternion.identity, freeSlot);
                clonedLemon.transform.localScale = size;
                clonedLemon.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedLemon.AddComponent<DragAndDrop>();

                PlayerMoney -= LemonPrice;
                UpdateBalances();
                Debug.Log("Added Lemon to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the lemon.");
        }
    }

    #endregion

    #region Kiwi
    [Header("Kiwi")]
    public int KiwiPrice = 25;
    public GameObject kiwi;

    public void BuyKiwi()
    {
        if (PlayerMoney >= KiwiPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedKiwi = Instantiate(kiwi, freeSlot.position, Quaternion.identity, freeSlot);
                clonedKiwi.transform.localScale = size;
                clonedKiwi.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedKiwi.AddComponent<DragAndDrop>();

                PlayerMoney -= KiwiPrice;
                UpdateBalances();
                Debug.Log("Added Kiwi to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the kiwi.");
        }
    }

    #endregion

    #region Banana
    [Header("Banana")]
    public int BananaPrice = 5;
    public GameObject banana;

    public void BuyBanana()
    {
        if (PlayerMoney >= BananaPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedBanana = Instantiate(banana, freeSlot.position, Quaternion.identity, freeSlot);
                clonedBanana.transform.localScale = size;
                clonedBanana.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedBanana.AddComponent<DragAndDrop>();

                PlayerMoney -= BananaPrice;
                UpdateBalances();
                Debug.Log("Added Banana to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the banana.");
        }
    }
    #endregion

    #region Cherry
    [Header("Cherry")]
    public int CherryPrice = 8;
    public GameObject cherry;

    public void BuyCherry()
    {
        if (PlayerMoney >= CherryPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedCherry = Instantiate(cherry, freeSlot.position, Quaternion.identity, freeSlot);
                clonedCherry.transform.localScale = size;
                clonedCherry.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedCherry.AddComponent<DragAndDrop>();

                PlayerMoney -= CherryPrice;
                UpdateBalances();
                Debug.Log("Added Cherry to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the cherry.");
        }
    }

    #endregion

    #region Apple
    [Header("Apple")]
    public int ApplePrice = 7;
    public GameObject apple;

    public void BuyApple()
    {
        if (PlayerMoney >= ApplePrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedApple = Instantiate(apple, freeSlot.position, Quaternion.identity, freeSlot);
                clonedApple.transform.localScale = size;
                clonedApple.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedApple.AddComponent<DragAndDrop>();

                PlayerMoney -= ApplePrice;
                UpdateBalances();
                Debug.Log("Added Apple to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the apple.");
        }
    }

    #endregion

    #region Broccoli
    [Header("Broccoli")]
    public int BroccoliPrice = 12;
    public GameObject broccoli;

    public void BuyBroccoli()
    {
        if (PlayerMoney >= BroccoliPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedBroccoli = Instantiate(broccoli, freeSlot.position, Quaternion.identity, freeSlot);
                clonedBroccoli.transform.localScale = size;
                clonedBroccoli.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedBroccoli.AddComponent<DragAndDrop>();

                PlayerMoney -= BroccoliPrice;
                UpdateBalances();
                Debug.Log("Added Broccoli to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the broccoli.");
        }
    }
    #endregion

    #region Carrot
    [Header("Carrot")]
    public int CarrotPrice = 9;
    public GameObject carrot;

    public void BuyCarrot()
    {
        if (PlayerMoney >= CarrotPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedCarrot = Instantiate(carrot, freeSlot.position, Quaternion.identity, freeSlot);
                clonedCarrot.transform.localScale = size;
                clonedCarrot.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedCarrot.AddComponent<DragAndDrop>();

                PlayerMoney -= CarrotPrice;
                UpdateBalances();
                Debug.Log("Added Carrot to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the carrot.");
        }
    }

    #endregion

    #region Garlic
    [Header("Garlic")]
    public int GarlicPrice = 15;
    public GameObject garlic;

    public void BuyGarlic()
    {
        if (PlayerMoney >= GarlicPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedGarlic = Instantiate(garlic, freeSlot.position, Quaternion.identity, freeSlot);
                clonedGarlic.transform.localScale = size;
                clonedGarlic.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedGarlic.AddComponent<DragAndDrop>();

                PlayerMoney -= GarlicPrice;
                UpdateBalances();
                Debug.Log("Added Garlic to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the garlic.");
        }
    }
    #endregion

    #region Corn
    [Header("Corn")]
    public int CornPrice = 15;
    public GameObject corn;

    public void BuyCorn()
    {
        if (PlayerMoney >= CornPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedCorn = Instantiate(corn, freeSlot.position, Quaternion.identity, freeSlot);
                clonedCorn.transform.localScale = size;
                clonedCorn.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedCorn.AddComponent<DragAndDrop>();

                PlayerMoney -= CornPrice;
                UpdateBalances();
                Debug.Log("Added Corn to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the corn.");
        }
    }


    #endregion

    #region Eggplant
    [Header("Eggplant")]
    public int EggplantPrice = 18;
    public GameObject eggplant;

    public void BuyEggplant()
    {
        if (PlayerMoney >= EggplantPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedEggplant = Instantiate(eggplant, freeSlot.position, Quaternion.identity, freeSlot);
                clonedEggplant.transform.localScale = size;
                clonedEggplant.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedEggplant.AddComponent<DragAndDrop>();

                PlayerMoney -= EggplantPrice;
                UpdateBalances();
                Debug.Log("Added Eggplant to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the eggplant.");
        }
    }

    #endregion

    #region Onion
    [Header("Onion")]
    public int OnionPrice = 11;
    public GameObject onion;

    public void BuyOnion()
    {
        if (PlayerMoney >= OnionPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedOnion = Instantiate(onion, freeSlot.position, Quaternion.identity, freeSlot);
                clonedOnion.transform.localScale = size;
                clonedOnion.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedOnion.AddComponent<DragAndDrop>();

                PlayerMoney -= OnionPrice;
                UpdateBalances();
                Debug.Log("Added Onion to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the onion.");
        }
    }


    #endregion


    #region Potato
    [Header("Potato")]
    public int PotatoPrice = 15;
    public GameObject potato;

    public void BuyPotato()
    {
        if (PlayerMoney >= PotatoPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedPotato = Instantiate(potato, freeSlot.position, Quaternion.identity, freeSlot);
                clonedPotato.transform.localScale = size;
                clonedPotato.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedPotato.AddComponent<DragAndDrop>();

                PlayerMoney -= PotatoPrice;
                UpdateBalances();
                Debug.Log("Added Potato to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the potato.");
        }
    }
    #endregion

    #region Pumpkin
    [Header("Pumpkin")]
    public int PumpkinPrice = 28;
    public GameObject pumpkin;

    public void BuyPumpkin()
    {
        if (PlayerMoney >= PumpkinPrice)
        {
            int freeSlotIndex = FindLowestFreeSlot();
            if (freeSlotIndex != -1)
            {
                Transform freeSlot = BackpackSlots[freeSlotIndex];
                GameObject clonedPumpkin = Instantiate(pumpkin, freeSlot.position, Quaternion.identity, freeSlot);
                clonedPumpkin.transform.localScale = size;
                clonedPumpkin.transform.position = new Vector3(freeSlot.position.x, freeSlot.position.y, -2);
                clonedPumpkin.AddComponent<DragAndDrop>();

                PlayerMoney -= PumpkinPrice;
                UpdateBalances();
                Debug.Log("Added Pumpkin to Backpack Slot " + freeSlotIndex);
            }
            else
            {
                Debug.Log("No free slots available in the backpack.");
            }
        }
        else
        {
            Debug.Log("Not enough money to buy the pumpkin.");
        }
    }

    #endregion

    /*region ChestSlotBuy
     public GameObject[] ChestSlots;
     public int ChestSlotCost = 15; //Cost for each Chest Slot
     private int LastPointChest = -1;


     public void ChestUpgrade()

     {
         if (PlayerMoney >= ChestSlotCost && ChestSlots[0].activeSelf == false) // Check if enough money and slot is inactive
         {
             int startIndex = LastPointChest + 1;

             ChestSlots[0].SetActive(true); // Activate the chest slot
             PlayerMoney -= ChestSlotCost; // Deduct the cost from the player's money
             UpdateBalances();
         }
         else
         {
             Debug.Log("Not enough money to buy the Chest Slot.");
         }
     }
     #endregion
    }
    */

    #region ChestSlotBuy
    public GameObject[] ChestSlots;
    public int ChestSlotCost = 15; //Cost for each Chest Slot
    private int LastPointChest = -1;
   
    public void UpgradeChestSlot()
    {
        if (PlayerMoney >= ChestSlotCost) // Check if enough money
        {
            int startIndex = (LastPointChest + 1) % ChestSlots.Length; // Calculate the starting index

            for (int i = startIndex; i < ChestSlots.Length; i++)
            {
                if (!ChestSlots[i].activeSelf) // Check if the slot is inactive
                {
                    ChestSlots[i].SetActive(true); // Activate the chest slot
                    PlayerMoney -= ChestSlotCost; // Deduct the cost from the player's money
                    LastPointChest = i; // Update the last point
                    UpdateBalances();
                    return; // Exit the method after activating a slot
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                if (!ChestSlots[i].activeSelf) // Check if the slot is inactive
                {
                    ChestSlots[i].SetActive(true); // Activate the chest slot
                    PlayerMoney -= ChestSlotCost; // Deduct the cost from the player's money
                    LastPointChest = i; // Update the last point
                    UpdateBalances();
                    return; // Exit the method after activating a slot
                }
            }

            Debug.Log("All Chest Slots are already active.");
        }
        else
        {
            Debug.Log("Not enough money to buy the Chest Slot.");
        }
    }

    public int ChestSlotresaleValue = 15; //Resell value of each chest slot 


    public void ResellChestSlot()
    {
        // Find the last active chest slot
        int startIndex = LastPointChest;
        bool soldSlot = false; // Flag to track if a slot has been sold

        // Iterate backwards from the last active slot to the first slot
        for (int i = startIndex; i >= 0; i--)
        {
            if (ChestSlots[i].activeSelf) // Check if the slot is active
            {
                ChestSlots[i].SetActive(false); // Deactivate the chest slot
                PlayerMoney += ChestSlotResaleValue; // Add the resale value to the player's money
                LastPointChest = i - 1; // Update the last point
                UpdateBalances();
                Debug.Log("Chest Slot at index " + i + " has been resold for $" + ChestSlotResaleValue);
                soldSlot = true; // Mark that a slot has been sold
                break; // Exit the loop after selling one slot
            }
        }

        // If no active slots found to sell, display a message
        if (!soldSlot)
        {
            Debug.Log("No active chest slots found to resell.");
        }
    }

    #endregion

    #region 
    public static void ResellObject(int slotIndex, ResellButton[] resellButtons)
{
        if (slotIndex >= 0 && slotIndex < resellButtons.Length)
    {
            resellButtons[slotIndex].ResellObject();
    }
    else
    {
        Debug.Log("Invalid slot index for resell button.");
    }
}
}

#endregion
