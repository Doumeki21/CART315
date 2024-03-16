using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    // track how fast the notes are dropping
    public float beatTempo;

    public bool hasStarted;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            // if (Input.anyKeyDown)
            // {
            //     hasStarted = true;
            // }
        }
        else
        {
            //standard beat = 120bpm (tempo) / 60 = 2 beats per sec.
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
