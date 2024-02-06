using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] parkedCars;

    // Start is called before the first frame update
    void Start()
    {
        parkedCars[Random.Range(0, parkedCars.Length)].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenSpot ()
    {
        for (int i = 0; i <= parkedCars.Length - 1;i++)
        {
            parkedCars[Random.Range(0, parkedCars.Length)].SetActive(true);
        }
        parkedCars[Random.Range(0, parkedCars.Length)].SetActive(false);

    }
}
