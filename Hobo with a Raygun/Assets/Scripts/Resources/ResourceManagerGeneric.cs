using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable] 
public class ResourceManagerGeneric : MonoBehaviour
{
    public List<GameObject> Nodes;
    public void moveResource(GameObject selfNode)
    {
        shuffle(Nodes);
        int i = 0;

        while((Nodes[i].GetComponent<resourceGeneric>().isFull() == 1) || (Nodes[i] == selfNode))
            i += 1;

        Nodes[i].GetComponent<resourceGeneric>().createNode();
    }

    void shuffle(List<GameObject> list)
    {
        for (int t = 0; t < list.Count; t++ )
        {
            GameObject tmp = list[t];
            int r = Random.Range(t, list.Count);
            list[t] = list[r];
            list[r] = tmp;
        }
    }

}