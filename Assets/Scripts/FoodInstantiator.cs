﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement random;
    public int maxClones;
    public int cloneCount;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood), 0, interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CloneFood()
    {
        if (cloneCount < maxClones)
        {
            cloneCount++;
            random.SetRandomPosition();
            GameObject prefab = alimentos[Random.Range(0,alimentos.Length)];
            Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }
        
    }
}
