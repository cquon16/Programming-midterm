using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    [SerializeField] GameObject platformprefab;
    private int i;
    private int k;

    // Start is called before the first frame update
    void Start()
    {
        k = 0;

        for(i = 0; i<20; i++)
        {
            var position = new Vector3(Random.Range(0,100),0 , Random.Range(0, 100));
            GameObject gameObject = Instantiate(platformprefab,position, Quaternion.identity);
        }

        StartCoroutine(platformSpawn());
    }

    IEnumerator platformSpawn()
    {
        while(k != 1)
        {
            var position = new Vector3(Random.Range(0,100), 0, Random.Range(0,100) );
            GameObject gameObject = Instantiate(platformprefab,position, Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
        }
    }
        
}
