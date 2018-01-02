using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MyKeyFrame : MonoBehaviour {

    public float time;
    public Vector3 pos;
    public Quaternion rot;

    public MyKeyFrame( float _time, Vector3 _pos, Quaternion _rot )
    {
        this.time = _time;
        this.pos = _pos;
        this.rot = _rot;
    }
}
