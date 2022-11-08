using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    private int randomNumber;
    public int clickCounter;

    private void Start()
    {
        randomNumber = Random.Range(1, 11);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCounter();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (HaveIWon())
            {
                Debug.Log("¡Eres un máquina!");
            }
        }
    }

    private void AddOneToCounter()
    {
        clickCounter++;
        transform.localScale += Vector3.one;
    }

    private bool HaveIWon()
    {
        if (clickCounter < randomNumber)
        {
            Debug.Log($"Te has quedado corto. Has hecho {clickCounter} clicks y el número aleatorio era {randomNumber}");
            return false;
        }else if (clickCounter == randomNumber)
        {
            Debug.Log("¡Has ganado!");
            return true;
        }
        
        Debug.Log("Te has pasado de largo.");
        Destroy(gameObject);
        return false;
    }
}
