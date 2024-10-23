﻿using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;
    public Dictionary<string, Queue<GameObject>> PoolDictionary;
    private GameObject arrow;

    void Start()
    { 
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        //PoolDictionary = new Dictionary<string, Queue<GameObject>>(poolSize);
        pool = new List<GameObject>(300);
    }

    public GameObject Get()
    {
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
        for (int i = 0; i < pool.Count; i++)
        {
            pool[i].SetActive(true);            
        }
    }

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
    }
}