using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class UiCarro : MonoBehaviour
{
    [SerializeField] private GameObject TelaVitoria;
    [SerializeField] private TextMeshProUGUI Nome;
    [SerializeField] private TextMeshProUGUI Leap;
    [SerializeField] private TextMeshProUGUI Pos;
    [SerializeField] private TextMeshProUGUI Vel;
    private Carro meuCarro;
    [SerializeField] private TMP_Text[] Lugar;
    void Start()
    {
        meuCarro= GetComponent<Carro>();
        Nome.text = meuCarro.name;
    }

    void Update()
    {
        Leap.text = "Leap: " + meuCarro.volta.ToString();
        Vel.text = meuCarro.GetComponent<NavMeshAgent>().speed.ToString() + "Km/h";
        Pos.text = "Pos: " + meuCarro.pos.ToString();
        Carro[] carros = GameObject.FindObjectsOfType<Carro>();
        /*int Apos = 4;
        foreach (Carro car in carros)
        {
            if (meuCarro.volta > car.volta || meuCarro.DestinyCheck > car.DestinyCheck)
            {
                Apos--;
            }
        }*/
        //Pos.text = Apos.ToString();
        if (meuCarro.volta == 2)
        {
            Time.timeScale = 0;
            TelaVitoria.SetActive(true);
            for (int i = 0; i < Lugar.Length; i++)
            {
                Lugar[carros[i].pos - 1].text = (i + 1).ToString() + " Lugar: " + carros[i].name;
            }
        }
    }
}
