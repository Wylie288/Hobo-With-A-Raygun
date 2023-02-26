using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed;
    public float bulletSpeed;
    private Vector2 clampPos;
    public GameObject player;
    public GameObject area;
    public GameObject enemyBullet;
    private RectTransform rt;
    private Vector2 pos;
    private Vector2 newpos;
    private Vector2 direction;
    private float dist;
    public int sc = 1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        area = gameObject.transform.parent.gameObject;
        pos = transform.localPosition;
        newpos = pos;
        rt = area.GetComponent<RectTransform>();
    }

    void Update()
    {
        direction.x = newpos.x - transform.localPosition.x;
        direction.y = newpos.y - transform.localPosition.y;
    }
    
    void FixedUpdate()
    {
        if (player.transform.IsChildOf(area.transform))
        {
            dist = Vector2.Distance(transform.localPosition, player.transform.localPosition);
            if (dist > 2000.0f)
                sc = 1;
            else if (dist <= 2000.0f)
                sc = 2;
        }
        switch (sc)
        {
            case 1:
                Invoke("UpdatePath", 3.0f);
                break;
            case 2:
                Invoke("EnemyShoot", 2.0f);
                newpos = player.transform.localPosition;
                break;
        }

        if (newpos.x > (rt.rect.width / 2) || newpos.x < (-rt.rect.width / 2) || newpos.y > (rt.rect.height / 2) || newpos.y < (-rt.rect.height / 2))
        {
            //Debug.Log("Called");
            Invoke("UpdatePath", 0.0f);
        }
        transform.localPosition = Vector2.MoveTowards(transform.localPosition, newpos, speed);
        clampPos = transform.localPosition;
        clampPos.x = Mathf.Clamp(transform.localPosition.x, (-rt.rect.width / 2), (rt.rect.width / 2));
        clampPos.y = Mathf.Clamp(transform.localPosition.y, (-rt.rect.height / 2), (rt.rect.height / 2));
        transform.localPosition = clampPos;

        transform.up = direction;

        //Debug.DrawLine(transform.localPosition, newpos, Color.blue);
    }

    void UpdatePath()
    {

        pos.x = Random.Range((-rt.rect.width / 2), (rt.rect.width / 2));
        pos.y = Random.Range((-rt.rect.height / 2), (rt.rect.height / 2)); 

        newpos = pos + (Vector2)transform.localPosition;

        CancelInvoke("UpdatePath");
    }
    void EnemyShoot()
    {
        GameObject bulletShoot = (GameObject)Instantiate(enemyBullet, transform.position, Quaternion.identity);
        bulletShoot.GetComponent<Rigidbody2D>().velocity = (player.transform.position - transform.position).normalized * bulletSpeed;

        CancelInvoke("EnemyShoot");
    }
}
