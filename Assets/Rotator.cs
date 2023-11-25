
using MixedReality.Toolkit;
using UnityEngine;

public class RotateGameObject : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the rotation speed as needed

  
    public bool isRotating = false;

    public void Start()
    {
        // Add StatefulInteractable component to the existing GameObject
        StatefulInteractable statefulInteractable = gameObject.AddComponent<StatefulInteractable>();

        // Add listener for the OnClicked event
        statefulInteractable.OnClicked.AddListener(ToggleRotation);
    }

    public void Update()
    {
        // Rotate the GameObject around its center if isRotating is true
        if (isRotating)
        {
            RotateObjectAroundCenter();
        }
    }

    public void RotateObjectAroundCenter()
    {
        // Calculate the center of the GameObject
        Vector3 center = transform.position;

        // Rotate the GameObject around its center
        transform.RotateAround(center, Vector3.up, rotationSpeed * Time.deltaTime);
    }

    public void ToggleRotation()

    {
        // Toggle the rotation state on each click
        isRotating = !isRotating;
        Debug.Log("Rotation Toggled. isRotating: " + isRotating);
    }
}

