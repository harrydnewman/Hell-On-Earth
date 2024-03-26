using UnityEngine;

public class PongBallGoesFaster : MonoBehaviour
{
    public float bounceStrength = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        PongBall ball = collision.gameObject.GetComponent<PongBall>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.rigidbody.AddForce(-normal * bounceStrength, ForceMode2D.Impulse);
        }
    }

}
