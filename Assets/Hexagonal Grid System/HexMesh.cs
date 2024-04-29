using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class HexMesh : MonoBehaviour
{
    //Hexagone composé de 6 triangle, chacun possédant 3 somments
    //besoin liste sommet et liste triangles
    Mesh hexMesh;
    
    private List<Vector3> sommets;
    private List<int> triangles;

    void Awake(){
        hexMesh = GetComponent<MeshFilter>().mesh = new Mesh();
        hexMesh.name = "Hex Mesh";
        sommets = new List<Vector3>();
        triangles = new List<int>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateHexagone(){
        hexMesh.Clear();
		sommets.Clear();
		triangles.Clear();

        CreateTriangle(new Vector3 (0, 0, 0), new Vector3 (0, 1, 0), new Vector3 (1, 0, 0));

        hexMesh.vertices = sommets.ToArray();
        hexMesh.triangles = triangles.ToArray();
    }

    void CreateTriangle(Vector3 posSommet1, Vector3 posSommet2, Vector3 posSommet3){
        sommets.Add(posSommet1);
        sommets.Add(posSommet2);
        sommets.Add(posSommet3);
        triangles.Add(0);
        triangles.Add(1);
        triangles.Add(2);
    }
}
