using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject SmallCircle;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(SmallCircle, transform.position, transform.rotation);
    }
}
