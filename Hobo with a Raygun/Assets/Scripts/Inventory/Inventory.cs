using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public List<Item> characterItems = new List<Item>();
    //public UIInventory inventoryUI;

    void Start()
    {
        GiveItem(11);
        GiveItem(110);
        GiveItem(101);
        GiveItem(111);
        GiveItem(122);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //inventoryUI.gameObject.SetActive(!inventoryUI.gameObject.activeSelf);
        }
    }

    public void GiveItem(int id)
    {
        if (characterItems.Count <= 9)
        {
        Item itemToAdd = ItemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        //inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
        }
    }

    public void GiveItem(string itemName)
    {
        Item itemToAdd = ItemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        //inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public Item ItemAt(int pos)
    {
        return characterItems[pos];
    }

    public Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);
        if (itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            //inventoryUI.RemoveItem(itemToRemove);
            Debug.Log("Removed item: " + itemToRemove.title);
        }
    }
}
