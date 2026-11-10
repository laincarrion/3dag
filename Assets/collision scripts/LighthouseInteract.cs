using UnityEngine;
using UnityEngine.InputSystem;

public class LighthouseInteract : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private floatinteractionDistance;

    [SerializeField] private InputActionReference interactionReference;

    private void OnEnable()
    {
        interactionReference.action.Enable();
        interactionReference.action.started += LighthouseInteract;
    }

    private void OnDisable()
    {
        interactionReference.action.started -= LighthouseInteract;
        interactionReference.action.Disable();
    }

    private void LighthouseInteract(InputAction.CallbackContext context)
    {
        if (context.started)
        { 
            Ray ray = new Ray(playerCamera.position, playerCamera.forward);

            if (!Physics.Raycast(ray, out RaycastHit hitInfo, interactionDistance)) return;

            if (hitInfo.collider.gameObject.TryGetComponent(out Interactable interactableObject))
            {
                interactableObject.Interact();
            }
        }