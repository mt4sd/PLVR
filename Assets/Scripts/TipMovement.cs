using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipMovement : MonoBehaviour
{
    public float posx;
    public float posy;
    public float posz;
    public float posHx;
    public float posHy;
    public float posHz;
    public Transform tipReference;
    public Transform collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posx=tipReference.position.x;
        posy=tipReference.position.y;
        posz=tipReference.position.z;
      
    }
}
