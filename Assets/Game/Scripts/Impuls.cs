using UnityEngine;

public class Impuls : MonoBehaviour
{
    public float acceleration;
    public Rigidbody rb;
    public Transform cueParent;


    void Update()
    {
        GiveImpuls();
    }

    void GiveImpuls()
    {
        if (Input.GetMouseButtonUp(0))
        {
            rb.AddForce(cueParent.right * acceleration, ForceMode.Force);
        }
        else if (cueParent != null)
        {
            Vector3 pivotVector = Input.mousePosition - Camera.main.WorldToScreenPoint(cueParent.position);
            float angle = Mathf.Atan2(pivotVector.y, pivotVector.x) * Mathf.Rad2Deg;
            cueParent.rotation = Quaternion.AngleAxis(-angle - 180, Vector3.up);
        }
    }
}
