using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;
    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>().AddComponent<QuestManager>(); 
            }
            return instance;
        }   
    }

    private void Awake()
    {
        if(instance == null) instance = this;
    }
}
