using UnityEngine;
using System.Collections;
public class RayShooter : MonoBehaviour
{
    private string coordinates;
    private Camera _camera;
    private bool _alive = true;
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;

    private Score score;

    void Start()
    {
        _camera = GetComponent<Camera>();
        score = FindObjectOfType<Score>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Vector3 down = transform.TransformDirection(Vector3.down) * 10;
        Debug.DrawRay(transform.position, down * 100, Color.red);

        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            Ray ray = new Ray(transform.position, Vector3.down);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;

                if (hitObject.GetComponent<PlayerCharacter>().PlayerOne)
                {
                    score.PlayerTwoScoreIncrease();
                }
                if (hitObject.GetComponent<PlayerCharacter>().PlayerTwo)
                {
                    score.PlayerOneScoreIncrease();
                }
                if (hitObject.GetComponent<Environment>())
                {
                    return;
                }

            }

        }
    }
}