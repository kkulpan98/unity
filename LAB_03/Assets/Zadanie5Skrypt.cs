using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5Skrypt : MonoBehaviour
{
    class WylosowaneWartosci
    {
        List<Pair<Pair<float, float>, Pair<float, float>>> wylosowaneWartosci = new List<Pair<Pair<float, float>, Pair<float, float>>>();

        public bool czyTakaWartoscMozeByc()
        {
            foreach (var item in wylosowaneWartosci)
            {

            }

            return true;
        }
    }

    class Pair<K,V>
    {
        public K key;
        public V value;
    }

    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        HashSet<Pair<Pair<float, float>, Pair<float, float>>> wylosowaneWartosci = new HashSet<Pair<Pair<float, float>, Pair<float, float>>>();
        int y = 1;
        int x;
        int z;

        for (int i = 0; i < 10; i++)
        {
            while()

            x = Random.Range(-5, 5);
            z = Random.Range(-5, 5);


        }
    }
}
