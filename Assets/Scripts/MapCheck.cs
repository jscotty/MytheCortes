using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapCheck : MonoBehaviour {

    public Transform[] MapPoints;
    public string quest = "quest1";

    public int questProgresion = 10;
    //void Start ()
    //{
    //    //This is how you create a Dictionary. Notice how this takes
    //    //two generic terms. In this case you are using a string and a
    //    //BadGuy as your two values.
    //    Dictionary<string, quest> badguys = new Dictionary<string, quest>();
        
    //    quest bg1 = new quest("Harvey", 50);
    //    quest bg2 = new quest("Magneto", 100);
        
    //    Quest myFirstQuest = new Quest("My Name", MapPoints);
    //    //You can place variables into the Dictionary with the
    //    //Add() method.
    //    quest.Add("gangster", bg1);
    //    quest.Add("mutant", bg2);
        
    //    quest magneto = badguys["mutant"];
        
    //    quest temp = null;
        
    //    //This is a safer, but slow, method of accessing
    //    //values in a dictionary.
    //    if(quest.TryGetValue("birds", out temp))
    //    {
    //        //success!
    //    }
    //    else
    //    {
    //        //failure!
    //    }
    //}
    void Update()
    {
        int selectedVillage = 0;
        int VillageAmount = 5;
        for (int i = 0; i < VillageAmount; i++ )
        {
            MapPoints[i].renderer.material.color = Color.black;
        }
        selectedVillage = 0;

        switch (quest)
        {
            case "quest1":  //---------------------------1st quest
                if (questProgresion >= 10)
                {
                    selectedVillage = 0;
                }
                if (questProgresion >= 20)
                {
                    selectedVillage = 1;
                }
                if (questProgresion >= 30)
                {
                    selectedVillage = 2;
                }
                if (questProgresion >= 40)
                {
                    selectedVillage = 3;
                }
                if (questProgresion >= 50)
                {
                    selectedVillage = 4;
                }
                break;
            case "quest2":  //---------------------------2De quest
                if (questProgresion >= 10)
                {
                    selectedVillage = 3;
                }
                if (questProgresion >= 20)
                {
                    selectedVillage = 0;
                }
                if (questProgresion >= 30)
                {
                    selectedVillage = 4;
                }
                if (questProgresion >= 40)
                {
                    selectedVillage = 2;
                }
                if (questProgresion >= 50)
                {
                    selectedVillage = 1;
                }
                break;
            case "quest3":  //---------------------------3De quest
                if (questProgresion >= 10)
                {
                    selectedVillage = 4;
                }
                if (questProgresion >= 20)
                {
                    selectedVillage = 3;
                }
                if (questProgresion >= 30)
                {
                    selectedVillage = 2;
                }
                if (questProgresion >= 40)
                {
                    selectedVillage = 1;
                }
                if (questProgresion >= 50)
                {
                    selectedVillage = 0;
                }
                break;
            case "quest4":  //---------------------------4De quest
                if (questProgresion >= 10)
                {
                    selectedVillage = 0;
                }
                if (questProgresion >= 20)
                {
                    selectedVillage = 3;
                }
                if (questProgresion >= 30)
                {
                    selectedVillage = 1;
                }
                if (questProgresion >= 40)
                {
                    selectedVillage = 4;
                }
                if (questProgresion >= 50)
                {
                    selectedVillage = 2;
                }
                break;
            case "quest5":  //---------------------------5De quest
                if (questProgresion >= 10)
                {
                    selectedVillage = 0;
                }
                if (questProgresion >= 20)
                {
                    selectedVillage = 1;
                }
                if (questProgresion >= 30)
                {
                    selectedVillage = 0;
                }
                if (questProgresion >= 40)
                {
                    selectedVillage = 2;
                }
                if (questProgresion >= 50)
                {
                    selectedVillage = 0;
                }
                if (questProgresion >= 60)
                {
                    selectedVillage = 3;
                }
                if (questProgresion >= 70)
                {
                    selectedVillage = 0;
                }
                if (questProgresion >= 80)
                {
                    selectedVillage = 4;
                }
                if (questProgresion >= 90)
                {
                    selectedVillage = 0;
                }
                if (questProgresion >= 100)
                {
                    selectedVillage = 0;
                }
                break;
            default:
                
                break;
        }
        MapPoints[selectedVillage].renderer.material.color = Color.yellow;

    }




            
    }   
