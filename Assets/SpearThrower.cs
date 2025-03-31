using UnityEngine;

public class SpearThrower : MonoBehaviour
{
    public GameObject spearPrefab;
    public Transform spawnPoint;
    public float throwForce = 20f;
    public float angle = 45f; // кут підйому списа

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowSpear();
        }
    }

    void ThrowSpear()
    {
        GameObject spear = Instantiate(spearPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = spear.GetComponent<Rigidbody>();

        Vector3 throwDirection = Quaternion.Euler(-angle, 0f, 0f) * spawnPoint.forward;
        rb.linearVelocity = throwDirection * throwForce;
    }
}
