using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float Speed;
    public float distance;
    private bool movingRight = true;
    public Transform groundDetection;

    // Update is called once per frame
    void Update()
    {
        // hraði sem enemey hreyfir sig á
        transform.Translate(Vector2.right * Speed * Time.deltaTime);

        // létur ósýnilegan laser til að tjekka ef það er eitthvað fyrir neðan hann ef það er ekki ná snýr hann við.
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

        // if state ment til að láta enemy skipta um átt
        // enemy byrjar að hreyfa sig til hægri
        if (groundInfo.collider == false)
        {
            // hér breytir hann áttiinni sinni til vinstri
            if (movingRight == true)
            {                
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            // hér snýr hann aftur til hægri.
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

    }

}
