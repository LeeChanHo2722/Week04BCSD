using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.angularVelocity = new Vector3(2, 4, 3);
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        rigid.AddTorque(Vector3.up);*/

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube (1)")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }
}
