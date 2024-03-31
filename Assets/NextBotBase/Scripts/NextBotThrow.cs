using UnityEngine;

public class NextBotThrow : MonoBehaviour
{
    [Header("Push Settings")]
    [Tooltip("Radius of the push effect")]
    public float sphereRadius = 2f;
    [Tooltip("Force applied to rigidbodies when pushed away")]
    public float pushForce = 10f;

    [Header("Visualization")]
    [Tooltip("Color of the sphere radius visualizer")]
    public Color visualizerColor = Color.red;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = visualizerColor;
        Gizmos.DrawWireSphere(transform.position, sphereRadius);
    }

    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, sphereRadius);

        foreach (Collider collider in colliders)
        {
            Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                Vector3 awayDirection = collider.transform.position - transform.position;
                rigidbody.AddForce(awayDirection.normalized * pushForce, ForceMode.Impulse);
            }
        }
    }
}
