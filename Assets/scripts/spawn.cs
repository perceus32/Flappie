/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawn : MonoBehaviour
{
    //public GameObject topPipe;
    //public GameObject bottomPipe;
    public float lastHeight;
    public GameObject folder;
    public GameObject[] pipes;
    //public float currentHeight;

    public float range;
    public GameObject spawnManager;
    public float maxHeight; //= 5f;
    public float minHeight;//= 0.3f;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnTime);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void Spawn()
    {
        Debug.Log("spawn");
        float y1 = Random.Range(lastHeight - range, lastHeight + range);
        if (y1 < minHeight)
        {
            y1 = minHeight;
        }
        if (y1 > maxHeight)
        {
            y1 = maxHeight;
        }
        //GameObject spawnTop = Instantiate(topPipe, spawnManager.transform);
         Debug.Log(y1);
        int random = Random.Range(0, 5);
        Debug.Log(random);
        GameObject spawnPipe = Instantiate(pipes[random], spawnManager.transform);
        spawnPipe.transform.parent = folder.transform;

        spawnManager.transform.position = new Vector3(spawnManager.transform.position.x, y1, 0f);
        //GameObject spawnPipe = Instantiate(pipes, spawnManager.transform);
        Debug.Log(spawnManager.transform.position.y);
        lastHeight = spawnManager.transform.position.y;
        //spawnPipe.AddComponent<Pipes>();
        
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawn : MonoBehaviour
{
    public GameObject topPipe;
    public GameObject bottomPipe;
    public float lastHeight;
    public GameObject folder;
    //public float currentHeight;
    public float minTopHeight;
    public float maxTopHeight;

    public float range;
    public GameObject spawnManager;
    public float maxHeight; //= 5f;
    public float minHeight;//= 0.3f;
    public float spawnTime;
    public GameObject spareGameobject;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnTime);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        Debug.Log("spawn");
        float y1 = Random.Range(lastHeight - range, lastHeight + range);
        if (y1 < minHeight)
        {
            y1 = minHeight;
        }
        if (y1 > maxHeight)
        {
            y1 = maxHeight;
        }
        Debug.Log(y1);
        float random = Random.Range(minTopHeight, maxTopHeight);
        //Debug.Log(random);
        GameObject spawnPipeBot = Instantiate(bottomPipe, spawnManager.transform);

        spawnManager.transform.position = new Vector3(spawnManager.transform.position.x, y1, 0f);
        //Debug.Log(spawnManager.transform.position.y);
        lastHeight = spawnManager.transform.position.y;
        spawnPipeBot.transform.parent = folder.transform;



        //spareGameobject.transform.position = new Vector3(spawnManager.transform.position.x, spawnPipeBot.transform.position.y + random, spawnManager.transform.position.z);
        Vector3 topPipePos = new Vector3(spawnManager.transform.position.x, spawnPipeBot.transform.position.y + random, spawnManager.transform.position.z);
        Vector3 rotateTop = new Vector3(0, 0, 180); 
        GameObject spawnPipeTop = Instantiate(topPipe, topPipePos, Quaternion.Euler(rotateTop));
        spawnPipeTop.transform.parent = folder.transform;


    }
}


