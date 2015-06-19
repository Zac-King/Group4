using UnityEngine;
using System.Collections;

public class FireGrenade : Grenade {

    public void Drop()
    {
        //inventory.items.Remove(gameObject);
        //inventory.grenades_fire--;

        transform.parent = null;
    }
}
