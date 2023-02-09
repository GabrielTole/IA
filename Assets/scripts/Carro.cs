using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Carro : MonoBehaviour
{
    private NavMeshAgent Car;
    public GameObject Destiny;
    void Start()
    {
        Car = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Car.SetDestination(Destiny.transform.position);
    }
}
