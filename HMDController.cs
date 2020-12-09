using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMDController : MonoBehaviour
{
    [SerializeField] GameObject baseHMD;
    [SerializeField] float scaleX = 1;
    [SerializeField] float scaleY = 1;
    [SerializeField] float scaleZ = 1;
    Vector3 targetPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        targetPos.x = myTransform.localPosition.x * scaleX;
        targetPos.y = myTransform.localPosition.y * scaleY;
        targetPos.z = myTransform.localPosition.z * scaleZ;

        myTransform.localPosition = targetPos;
    }
}
