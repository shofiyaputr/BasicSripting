using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan3 : MonoBehaviour
{
    /// <summary>
    /// Merupakan fungsi penjumlahan dari 2 input angka
    /// </summary>
    /// <param name="a">Masukkan Angka Integer</param>
    /// <param name="b">Masukkan Angka Integer</param>
    /// <returns></returns>
    int Jumlah(int a, int b)
    {
        return a + b;
    }

    // Start is called before the first frame update
    void Start()
    {
        int c = Jumlah(60, 40);
        Debug.Log("Hasil Jumlah A dan B adalah " + c); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
