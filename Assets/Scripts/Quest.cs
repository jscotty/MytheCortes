using UnityEngine;
using System.Collections;

public class Quest
{
    public Transform[] mapPoints;
    public string questId;
    public int questProgression;
    public bool isQuestActive = false;
    public bool questCompleted = false;

    public Quest (string name, Transform[] points)
    {
        questId = name;
        mapPoints = points;
        questProgression = 0;
        isQuestActive = false;
        questCompleted = false;
    }
}
