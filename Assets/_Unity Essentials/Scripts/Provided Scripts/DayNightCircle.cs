using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float secondsPerDay = 60f;

    void Update()
    {
        if (secondsPerDay <= 0f)
            return;

        float rotationSpeed = 360f / secondsPerDay;

        transform.Rotate(
            Vector3.right,
            rotationSpeed * Time.deltaTime
        );
    }
}