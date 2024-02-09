using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickLayerManager : MonoBehaviour

{
    public GameObject Brick;
    public int rows, columns;

    public float brickSpacing_h;
    public float brickSpacing_v;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < columns; i++) {
            for(int j = 0; j < rows; j++) {
                //controlled in Unity project 4 rows and 5 columns
                float xPos = -columns + (i * brickSpacing_h);
                float yPos = rows - (j * brickSpacing_v);
                Instantiate(Brick, new Vector3(xPos, yPos, 0), Quaternion.identity, this.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
