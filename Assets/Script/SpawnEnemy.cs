using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int jumlahEnemy;
    public int total;
    public float xPos;
    public Text wave;
    int currentWave = 1;
    //int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        wave.text = "WAVE " + currentWave.ToString();
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn()
    {
        for (int i=0; i<=100; i++)
        {
            if (jumlahEnemy == 0)
            {
                while (jumlahEnemy < total)
                {
                    xPos = Random.Range(-8, 8);
                    Instantiate(objectToSpawn, new Vector3(xPos, 6, 0), Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                    jumlahEnemy += 1;
                }
                currentWave += 1;
                yield return new WaitForSeconds(5f);
            }
            else
            {
                wave.text = "WAVE " + currentWave.ToString();
                jumlahEnemy = 0;
                total += 5;
            }
        }
    }
    
}
