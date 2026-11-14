using UnityEngine;

public class Offset_Rotation : MonoBehaviour
{
    Transform parent;
    float parRotation = 0;

    void Start() {
        parent = transform.parent;
    }
    // Update is called once per frame
    void Update()
    {
        if (parent.rotation.z != parRotation)
        {
            parRotation = parent.rotation.z;
            transform.rotation = Quaternion.Euler(0f, 0f, -parRotation);
        }
        
    }
}
