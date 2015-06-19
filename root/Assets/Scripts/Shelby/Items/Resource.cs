using UnityEngine;
using System.Collections;

public class Resource : MonoBehaviour, IPickup {
  
    public int value;

    public void PickUp()
    {
        //print("Scraps: " + GameObject.Find("PlayerInventory").GetComponent<ItemDatabase>().scraps);
        //print("Special Scraps: " + GameObject.Find("PlayerInventory").GetComponent<ItemDatabase>().scraps_special);
        Object.Destroy(gameObject);
       
    }

    public void Drop()
    {
        throw new System.NotImplementedException();
    }
}
