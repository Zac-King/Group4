using UnityEngine;
using System.Collections;

public abstract class Item : MonoBehaviour 
{    
    public string name;
    public string id;

    protected void Awake()
    {
        if (name == "" || id == "")
            PopulateFields();
    }

    [ContextMenu("Populate Item Fields")]
    protected void PopulateFields()
    {
        name = gameObject.name;
        string type = "swerd_";
        id = gameObject.name.Replace(type, ""); 
    }
}
