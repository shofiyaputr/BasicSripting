using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan6 : MonoBehaviour
{
    public int[] intArray;
    
    void Start()
    {
        Debug.Log("Menampilkan Seluruh Array");
        foreach(int a in intArray)
        {
            Debug.Log(a);
        }
        Debug.Log("Nilai Index ke 2 adalah " + intArray[2]);
    }

    void Update()
    {
        
    }
}
