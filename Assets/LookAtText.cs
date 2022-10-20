using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtText : MonoBehaviour
{
    public Text text;
    GameObject _camera;
    void Start()
    {
        _camera=Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        text.transform.LookAt(_camera.transform);
        text.transform.localEulerAngles = new Vector3(text.transform.localEulerAngles.x+40, text.transform.localEulerAngles.y+180,text.transform.localEulerAngles.z);
    }
}
