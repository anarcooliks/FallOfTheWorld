using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGrid : MonoBehaviour
{
    [SerializeField] int width, height;

    private HexMesh hexMesh;

    void Awake(){
        hexMesh = GetComponentInChildren<HexMesh>();
    }
    // Start is called before the first frame update
    void Start()
    {   
        hexMesh.CreateHexagone();
    }
}
