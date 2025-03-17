using UnityEngine;

public class Magnus : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
        }
        ApplyMagnusEffect();

        void Kick()
        {
            rb.linearVelocity = velocity; 
        }

        void ApplyMagnusEffect()
        {

            Vector3 magnusForce = Vector3.Cross(velocity, spin);

            rb.AddForce(magnusForce);
        }
    }
}