using UnityEngine;
using System.Collections;
using EquipmentTypes;

public class MakeEquipment : MonoBehaviour
{
    public GameObject equipment;


    //[ContextMenu("Get shit done.")]
    public void MakeTheEquipment()
    {
        var newItem = Instantiate(equipment) as GameObject;
        newItem.gameObject.name = "Item";
        newItem.GetComponent<EquipmentStats>().Build();
    }
}