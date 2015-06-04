using UnityEngine;
using System.Collections;
using EquipmentTypes;

public class MakeEquipment : MonoBehaviour
{
    public GameObject equipment;
    public ItemDatabase refToDB;


    [ContextMenu("Get shit done.")]
    void MakeTheEquipment()
    {
        var newItem = Instantiate(equipment) as GameObject;
        newItem.gameObject.name = "Item";
        newItem.GetComponent<EquipmentStats>().Build(1);

        ShelbyDatabase.instance.AddSingleItem(newItem, refToDB);
    }

    void RemoveTheThings()
    {

    }
}