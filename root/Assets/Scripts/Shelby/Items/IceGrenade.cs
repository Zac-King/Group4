using UnityEngine;
using System.Collections;

public class IceGrenade : Grenade 
{
    public void Drop()
    {
        inventory.items.Remove(gameObject);
        //inventory.grenades_ice--;

        transform.parent = null;
    }
 
}
