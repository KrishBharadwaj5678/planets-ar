using UnityEngine;

public class SaturnRotation : MonoBehaviour
{
    [Header("Rotation Targets")]
    [SerializeField] private GameObject saturn; // The Saturn planet model
    [SerializeField] private GameObject rings;  // The Saturn rings model

    [Header("Rotation Speeds")]
    [SerializeField] private float planetRotationSpeed = 10f; // Rotation speed of the planet
    [SerializeField] private float ringsRotationSpeed = 15f;  // Rotation speed of the rings

    void Update()
    {
        // Rotate the Saturn planet
        if (saturn != null)
        {
            saturn.transform.Rotate(Vector3.up * planetRotationSpeed * Time.deltaTime, Space.Self);
        }

        // Rotate the Saturn rings
        if (rings != null)
        {
            rings.transform.Rotate(Vector3.up * ringsRotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}
