using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnCollisionPickUp : MonoBehaviour
{
    public ItemDatabase pInventory;

    void Start()
    {
        pInventory = GameObject.Find("PlayerInventory").GetComponent<ItemDatabase>();
        //DontDestroyOnLoad(gameObject);
    }


    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Resource":
                int n_scraps = other.gameObject.GetComponent<Resource>().value;
                // resource objects have different values
                if (n_scraps >= 11)
                    pInventory.scraps_special += 1;
                else
                    pInventory.scraps += n_scraps;

                other.gameObject.GetComponent<IPickup>().PickUp();
                //Destroy(other.gameObject);
                break;
            case "Item":
                ShelbyDatabase.instance.AddSingleItem(other.gameObject, pInventory);
                other.transform.parent = pInventory.transform;
                other.transform.localPosition = Vector3.zero;
                other.gameObject.GetComponent<IPickup>().PickUp();

                break;
            default: break;
        }

        //print(gameObject.name);
        //if (other.gameObject.tag == "Item")
        //{
        //    gameObject.GetComponentInChildren<PlayerInventory>().items.Add(gameObject);
        //    other.gameObject.transform.parent = gameObject.transform;
        //    other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //    other.gameObject.transform.localPosition = new Vector3(0, 1, 2);

        //    print("Picked up " + other.gameObject.name);
        //}
    }
}

