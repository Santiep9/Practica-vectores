using UnityEngine;

public class Vector3D : MonoBehaviour
{
    public float x { get; private set; }
    public float y { get; private set; }
    public float z { get; private set; }

    Vector3D()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    Vector3D(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}