using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactionArea : MonoBehaviour
{
    public Text txtScore;
    public int Score;
    public int maxScores;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        Score += alimento.valorAlimentario;
        if (Score < maxScores)
        {
            txtScore.text = Score.ToString();
            Destroy(collision.gameObject);
        }
        else
        {
            txtScore.text = "Ganaste!";
        }
        
    }
}
