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
        targetPos.x = baseHMD.transform.localPosition.x * (scaleX - 1);
        targetPos.y = baseHMD.transform.tlocalPosition.y * (scaleY - 1);
        targetPos.z = baseHMD.transform.localPosition.z * (scaleZ - 1);

        myTransform.localPosition = targetPos;
    }
}
