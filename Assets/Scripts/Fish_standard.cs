using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_standard : MonoBehaviour
{
    Quaternion _rot;
    bool _direc = false;
    private void Start()
    {
        _rot = transform.rotation;
    }
    void Update()
    {
        FishForward();
    }

    void FishForward()
    {
        transform.Translate(1 * Time.deltaTime, 0, 0);
        //FishRot();
    }
    void FishRot()
    {
        if (_rot.y > .5)
            _direc = true;
        if (_rot.y < -.5)
            _direc = false;

        if (_direc)
            _rot.y -= Time.deltaTime;
        else
            _rot.y += Time.deltaTime;
        transform.rotation = _rot;
    }
}
