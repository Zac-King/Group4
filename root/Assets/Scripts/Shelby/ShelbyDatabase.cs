using UnityEngine;
using System.Collections;

public  class ShelbyDatabase : Singleton<ShelbyDatabase> 
{
    public string SelectAllNames(ItemDatabase db)
    {
        string Names = "";
        for (int i = 0; i < db.database.Count; ++i)
        {
            Names += db.database[i].GetComponent<EquipmentStats>().name + ",\n";
        }
        Names = Names.Remove(Names.Length - 2, 2);
        return Names;
    }

    public string SelectAllIDs(ItemDatabase db)
    {
        string IDs = "";
        for (int i = 0; i < db.database.Count; ++i)
        {
            IDs += db.database[i].GetComponent<EquipmentStats>().id.ToString() + ",\n";
        }
        IDs = IDs.Remove(IDs.Length - 2, 2);
        return IDs;
    }

    public void AddListToDatabase(ItemDatabase db)
    {

    }

    public void AddSingleItem(GameObject o, ItemDatabase db)
    {
        db.database.Add(o);
    }
}
