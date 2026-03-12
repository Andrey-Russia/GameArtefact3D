using UnityEngine;

public class InteracriveBox : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var buttonManager = collision.collider.GetComponent<Wallbutton>();
        if (buttonManager != null && this.CompareTag("Box1"))
            buttonManager.ActivateWall();
    }

    private void OnCollisionExit(Collision collision)
    {
        var buttonManager = collision.collider.GetComponent<Wallbutton>();
        if (buttonManager != null && this.CompareTag("Box1"))
            buttonManager.DeactivateWall();
    }
}
