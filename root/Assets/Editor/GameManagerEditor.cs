using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

//side experiment
[CustomEditor(typeof(GameManager))]
public class GameManagerEditor : Editor
{
    //public override void OnInspectorGUI()
    ////{
    //    DrawDefaultInspector();
    //    GameManager gm = (GameManager)target;

    //    if (gm.Levels.Count == 0 && gm.NumberOfLevels == 0 )
    //    {
    //        GUILayout.Button("No levels yet... Input Number of Levels");
    //    }
    //    else 
    //    {
    //        if (GUILayout.Button("No levels yet... Ready to Populate"))
    //        {
    //            gm.PopulateArray();
    //        }
    //    }
    //}


    //public static int scene = 0;
    //[MenuItem("Zac Tools/Load level\"level_00")]
    //static public void LoadLevelZero()
    //{
    //    Application.LoadLevel("level_00");
    //}

    [MenuItem("Zac Tools/Populate levels")]
    static public void PopulateLevels()
    {
        string path = Application.dataPath + "/Scenes";
        
        DirectoryInfo dir = new DirectoryInfo(path);
        FileInfo[] info = dir.GetFiles("*.*");
        foreach(FileInfo f in info)
        {
            //grab up to a point 
            //then take that point away
            //if the path contains .unity
            if (f.ToString().Contains(".unity"))
            {
                //if the path does not contain .meta
                if (!f.ToString().Contains(".meta"))             
                {
                    //Whats left is a scene file
                    string ft = f.ToString();
                    ft = ft.Replace(f.ToString(), "");
                    Debug.Log(f);
                    Debug.Log(ft);
                }
     
            }
        }
    }
    //[MenuItem("Zac Tools/Make Scene : \"Level_\"<int>")]
    //static public void SceneMake_Level()
    //{
        
    //    if (GameManager.instance.Levels.Contains("Level_" + scene))
    //    {
    //        scene += 1;
    //        GameManagerEditor.SceneMake_Level();
    //    }
    //    // generate Scene named Level_<scene>
    //    else
    //    {
    //        GameManager.instance.Levels.Add("Level_" + scene);
    //        //EditorApplication.NewScene();
    //        //EditorApplication.SaveScene("Assests/Scenes/Level_" + scene);
    //    }
    //    scene = 0;
    //}

    //[MenuItem("Zac Tools/Make Scene : \"Menu_\"<int>")]
    //static public void SceneMake_Menu()
    //{
    //    if (GameManager.instance.Levels.Contains("Menu_" + scene))
    //    {
    //        scene += 1;
    //        GameManagerEditor.SceneMake_Menu();
    //    }
    //    // generate Scene named Menu_<scene>
    //    else
    //        GameManager.instance.Levels.Add("Menu_" + scene);
    //    scene = 0;
    //}


    
}


