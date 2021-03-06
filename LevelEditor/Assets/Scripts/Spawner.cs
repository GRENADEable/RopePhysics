﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Public Variables
    public ZombieStats zomStats;
    #endregion

    #region Private Variables
    private GameObject[] tiles;
    #endregion

    #region Callbacks
    void Start()
    {
        tiles = GameObject.FindGameObjectsWithTag("MonsterSpawn");

        Vector3 pos = new Vector3(0, 1f, 0);

        for (int i = 0; i < tiles.Length; i++)
        {
            if (tiles[i] != null)
            {
                GameObject monsterObj = Instantiate(zomStats.monster, tiles[i].transform.position + pos, Quaternion.identity);
                monsterObj.transform.parent = gameObject.transform;
            }
        }
    }
    #endregion
}
