using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    public ItemDatabase refToDB;
    public Text nameQueryLabel;
    public Text idQueryLabel;
    
    void NameQuery()
    {
        string theQuery = "";
        theQuery = ShelbyDatabase.instance.SelectAllNames(refToDB);
      //sword_0 sword_2
        nameQueryLabel.text = theQuery;
    }

    void IDQuery()
    {
        string theQuery = "";
        theQuery = ShelbyDatabase.instance.SelectAllIDs(refToDB);
        //sword_0 sword_2
        idQueryLabel.text = theQuery;
    }

    void Update ()
    {
        NameQuery();
        IDQuery();
    }

    public string blah = "shelby";
    [ContextMenu("test string")]
    void testSTring()
    {
        blah = blah.Remove(blah.Length - 2, 2);
        print(blah);
  
    }
}
