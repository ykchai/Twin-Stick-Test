using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyKeyFrame : MonoBehaviour {

    float time;
    Vector3 pos;
    Quaternion rot;

    public MyKeyFrame( float _time, Vector3 _pos, Quaternion _rot )
    {
        _time = this.time;
        _pos = this.pos;
        _rot = this.rot;
    }
}
