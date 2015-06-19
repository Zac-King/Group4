using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public  class ShelbyDatabase : Singleton<ShelbyDatabase> 
{
    public string SelectAllNames(Database db)
    {
        string Names = "";
        print(db.database.Count);
        if (db.database.Count > 1)
        {
            for (int i = 0; i < db.database.Count ; ++i)
            {
                Names += db.database[i].GetComponent<EquipmentStats>().name + "\n";
               
            }
            print(Names);
        }
        //Names = Names.Remove(Names.Length - 2, 2);
        else
        {
            Names += db.database[0].GetComponent<EquipmentStats>().name;
        }
        
        
        return Names;
    }

    public string SelectAllIDs(Database db)
    {
        string IDs = "";
        for (int i = 0; i < db.database.Count -1; ++i)
        {
            IDs += db.database[i].GetComponent<EquipmentStats>().id.ToString() + ",\n";
        }
        //IDs = IDs.Remove(IDs.Length - 2, 2);
        IDs += db.database[db.database.Count].GetComponent<EquipmentStats>().id.ToString();
        return IDs;
    }

    public void AddListToDatabase(Database db)
    {

    }

    public void AddSingleItem(GameObject o, Database db)
    {
        db.database.Add(o);
    }
}
