using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public int count = 0;
    public int MAX_COUNT = 100;
    public GameObject[] e;
    public GameObject[] spawnLocations;
    public GameObject spawne;
    public GameObject area;
    GameObject s;
    public int rand;
    private RectTransform rt;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        area = gameObject.transform.gameObject;
        rt = area.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        e = GameObject.FindGameObjectsWithTag("Enemy");
        count = e.Length;
    }
    void FixedUpdate()
    {
        if(count < MAX_COUNT)
            Invoke("Spawn", 3.0f);
    }
    public void Spawn()
    {
        //pos.x = Random.Range((-rt.rect.width / 2), (rt.rect.width / 2));
        //pos.y = Random.Range((-rt.rect.height / 2), (rt.rect.height / 2));
        rand = Random.Range(0, spawnLocations.Length);

        
        s = Instantiate(spawne, spawnLocations[rand].transform.localPosition, Quaternion.identity) as GameObject;
        s.transform.SetParent(gameObject.transform, false);
        //Debug.Log("Spawned");
        CancelInvoke("Spawn");
    }
}
