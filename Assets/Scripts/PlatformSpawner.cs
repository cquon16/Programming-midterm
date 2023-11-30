using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    [SerializeField] GameObject platformprefab;
    [SerializeField] GameObject diamondprefab;
    public GameObject[] Arry;
    private int randomNumber;
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
        StartCoroutine(diamondspawn());
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

    IEnumerator diamondspawn()
    {
        while (k !=1)
        {
            Arry = GameObject.FindGameObjectsWithTag("Platform");
            randomNumber = Random.Range(0,Arry.Length);
            GameObject gameObject = Instantiate(diamondprefab,new Vector3(Arry[randomNumber].transform.position.x, Arry[randomNumber].transform.position.y +1, Arry[randomNumber].transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0, 4));
        }
    }
        
}
