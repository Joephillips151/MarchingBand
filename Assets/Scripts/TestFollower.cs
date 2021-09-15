using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;


public class TestFollower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;

    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        //Print the position of the Ball in the console
        print(transform.position);

        //The following FOR LOOP finds the anchors by iterating through the POINTS and selecting every 3rd one.  It then 
        //prints the Anchor XYZ transform.
        for(int i = 0; i < pathCreator.bezierPath.points.Count; i++)
        {
            if (i % 3 == 0)
            print($"THE ANCHORS ARE: {string.Join(", ", pathCreator.bezierPath.points[i])}");
            { if (Vector3.Distance(pathCreator.bezierPath.points[i], transform.position) < 1)
                {
                    //print(Vector3.Distance(pathCreator.bezierPath.points[i], transform.position));
                    print(i);
                    if (transform.position == pathCreator.bezierPath.points[i])
                    {
                        print($"THEYREEQUAL: {string.Join(", ", pathCreator.bezierPath.points[i])}");
                    }
                }
            }    
        }
    }
}
