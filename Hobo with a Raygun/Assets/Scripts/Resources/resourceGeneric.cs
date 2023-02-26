using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceGeneric : MonoBehaviour
{
    private Rigidbody2D rb;
    private int[] nodes;
    private int[,] positions;
    private int size = 8;
    public GameObject Nodetype;
    public GameObject Manager;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        nodes = new int[8];
        nodes[0] = 0;
        nodes[1] = 0;
        nodes[2] = 0;
        nodes[3] = 0;
        nodes[4] = 0;
        nodes[5] = 0;
        nodes[6] = 0;
        nodes[7] = 0;
        positions = new int[8,2];
        positions[0,0] = 0;
        positions[0,1] = 192;
        positions[1,0] = 192;
        positions[1,1] = 192;
        positions[2,0] = 192;
        positions[2,1] = 0;
        positions[3,0] = 192;
        positions[3,1] = -192;
        positions[4,0] = 0;
        positions[4,1] = -192;
        positions[5,0] = -192;
        positions[5,1] = -192;
        positions[6,0] = -192;
        positions[6,1] = 0;
        positions[7,0] = -192;
        positions[7,1] = 192;

        createNode();
        createNode();
        createNode();
    }

    public int isFull()
    {
        for(int i = 0; i < size; i++)
        {
            if (isEmpty(i) == 1)
                return 0;
        }
        return 1;
    }

    public int isEmpty(int pos)
    {
        if (nodes[pos] == 0)
            return 1;
        else
            return 0;
    }

    public void createNode()
    {
        for (int i = 0; i < size; i++)
        {
            if (isEmpty(i) == 1)
            {
                GameObject instance = (GameObject)Instantiate(Nodetype,new Vector3(rb.position.x + positions[i,0],rb.position.y + positions[i,1]),Quaternion.identity);
                //Debug.Log("Node Made Pos: " + i + " node: " + this.gameObject);
                instance.GetComponent<ResourceFragmentGeneric>().pos = i;
                instance.GetComponent<ResourceFragmentGeneric>().node = this.gameObject;
                nodes[i] = 1;
                i = size; //End Loop
            }
        }

    }

    public void removeNode(int pos)
    {
        nodes[pos] = 0;
        Manager.GetComponent<ResourceManagerGeneric>().moveResource(this.gameObject);
    }
}

