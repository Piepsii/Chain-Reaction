using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoBuilder : MonoBehaviour
{
    public MeshCollider plane;
    public GameObject domino;
    public float spacing = 0.2f;
    public Transform start, end;

    [ContextMenu("Build Dominoes")]
    void build(){
        var distance = Vector3.Distance(end.position, start.position);
        var direction = (start.position - end.position).normalized;
        int numberOfDominoes = Mathf.FloorToInt(distance / spacing);
        GameObject[] dominoes = new GameObject[numberOfDominoes];
        for(int i = 0; i < numberOfDominoes; ++i){
            Instantiate<GameObject>(dominoes[i]);
            dominoes[i].transform.position = start.position + direction * spacing * i;
        }
    }
}
