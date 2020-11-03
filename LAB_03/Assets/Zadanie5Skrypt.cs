using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Zadanie5Skrypt : MonoBehaviour
{
    private float maxX = 10f;
    private float minX = 0f;
    private float maxZ = 10f;
    private float minZ = 0f;
    public Bounds[] bounds;
    public int amountToSpawn = 10;
    public GameObject target;
    // Use this for initialization
    void Start()
    {
        generateObjects();
    }

    private void generateObjects()
    {
        List<int> pozycje_x = new List<int>(Enumerable.Range(0, 10).OrderBy(x => Random.value));
        List<int> pozycje_z = new List<int>(Enumerable.Range(0, 10).OrderBy(z => Random.value));

        for (int i = 0; i < amountToSpawn; i++)
        {
            Instantiate(target, new Vector3(pozycje_x[i], 0, pozycje_z[i]), Quaternion.identity);
        }
    }
}
