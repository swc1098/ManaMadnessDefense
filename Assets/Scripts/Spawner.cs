﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    private GameObject enemy;
    private GameObject player;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player");
        spawnEnemy();
	}
    void spawnEnemy()
    {
        if(player != null)
        {
            enemy = (GameObject)Instantiate(Resources.Load("Enemy"), gameObject.transform.position, Quaternion.identity) as GameObject;
            InvokeRepeating("spawnEnemy", 10, 10);
        }
    }
}
