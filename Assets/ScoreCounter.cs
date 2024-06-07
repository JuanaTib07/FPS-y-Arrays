﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public Text txtScore;
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        Score += alimento.valorAlimentario;
        txtScore.text = Score.ToString();
     
    }
}
