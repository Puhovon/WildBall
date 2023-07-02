using UnityEngine;

namespace Plate
{
    public class PlateMoving : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
                collision.transform.SetParent(transform);

        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
                collision.transform.SetParent(null);
        }
    }
}