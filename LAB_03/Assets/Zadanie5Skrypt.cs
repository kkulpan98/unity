using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5Skrypt : MonoBehaviour
{
    private float maxX = 10f;
    private float minX = 0f;
    private float maxZ = 10f;
    private float minZ = 0f;
    private int createdObjects = 0;
    public Bounds[] bounds;
    public int amountToSpawn = 10;
    public GameObject Target;
    private GameObject tmpObject;
    // Use this for initialization
    void Start()
    {
        bounds = new Bounds[amountToSpawn];
        StartCoroutine(spawn());
    }

    public IEnumerator spawn()
    {
        while (createdObjects < amountToSpawn)
        {

            GameObject targ = Target;
            Bounds tmpBounds;

            targ.transform.position = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));

            tmpObject = Instantiate(targ);
            //tmpObject.transform.position = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
           //tmpBounds = new Bounds(targ.transform.BroadcastMessag)

            if (hasCollisions(tmpObject))
            {
                Debug.Log(hasCollisions(tmpObject) + "a");
                tmpObject.transform.position = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
                Debug.Log(new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ)));
            }
            if (hasCollisions(tmpObject))
            {
                Debug.Log(hasCollisions(tmpObject) + "b");
                tmpObject.transform.position = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
                Debug.Log(new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ)));
            }
            if (hasCollisions(tmpObject))
            {
                Debug.Log(hasCollisions(tmpObject) + "c");
                tmpObject.transform.position = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
                Debug.Log(new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ)));
            }

            //Debug.Log(hasCollisions(tmpObject));
            bounds[createdObjects] = new Bounds(tmpObject.GetComponent<BoxCollider>().bounds.center, tmpObject.GetComponent<BoxCollider>().bounds.size);
            createdObjects++;
        }

        yield return null;
    }

    bool hasCollisions(GameObject target)
    {
        for (int j = 0; j < createdObjects; j++)
        {
            if (target.GetComponent<BoxCollider>().bounds.Intersects(bounds[j]))
            {
                return true;
            }

        }
        return false;
    }
}
