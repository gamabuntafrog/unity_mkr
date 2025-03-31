using UnityEngine;

public class VectorLength : MonoBehaviour
{
    void Start()
    {
        Vector3 vectorA = new Vector3(4, 0, 7);
        Vector3 vectorB = new Vector3(7, 1, 1);

        Vector3 sum = vectorA + vectorB;
        float length = sum.magnitude;

        Debug.Log("Сума векторів: " + sum);
        Debug.Log("Довжина суми: " + length);
    }
}
