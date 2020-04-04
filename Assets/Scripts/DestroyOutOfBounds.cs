using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
  private float topbound = 30;
  private float bottombound = -10;

  private void Update()
  {
    if (transform.position.z > topbound || transform.position.z < bottombound)
    {
      Destroy(gameObject);
    }
  }
}