using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;


    public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.getItem(id);
        characterItems.Add(itemToAdd);
        Debug.Log("Added Item " + itemToAdd.title);
    }


    public void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.getItem(itemName);
        characterItems.Add(itemToAdd);
        Debug.Log("Added Item " + itemToAdd.title);
    }

    public Item CheckForItem(int id){
        return characterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item item =CheckForItem(id);
        if(item != null)
        {
            characterItems.Remove(item);
            Debug.Log("Item removed: " + item.title);
        }
    }
}
