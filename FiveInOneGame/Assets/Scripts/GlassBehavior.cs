using System.Collections;
using UnityEngine;

public class GlassBehavior : MonoBehaviour
{
    [SerializeField] bool isRightWallTouched;
    [SerializeField] bool isLeftWallTouched;
    [SerializeField] bool isInMid;

    private void Start()
    {
        isInMid = true;
    }

    private void Update()
    {
        GlassMovement();
    }

    void GlassMovement()
    {
        if (isInMid)
        {
            transform.Translate(Vector2.right * 2f * Time.deltaTime);
        }
        else if (isRightWallTouched)
        {
            transform.Translate(Vector2.left * 2f * Time.deltaTime);
        }
        else if (isLeftWallTouched)
        {
            transform.Translate(Vector2.right * 2f * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.name == "RightBorder")
        {
            isInMid = false;
            isLeftWallTouched = false;
            isRightWallTouched = true;
        }
        if(other.transform.name == "LeftBorder")
        {
            isInMid = false;
            isRightWallTouched = false;
            isLeftWallTouched = true;
        }
    }
}
