using UnityEngine;

public class MoveForward : MonoBehaviour
{

  public float speed = 20.0f;

  private void Update()
  {
    transform.Translate(Vector3.forward * Time.deltaTime * speed);
  }
}