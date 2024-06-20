using UnityEngine;
using UnityEngine.InputSystem;
using NaughtyAttributes;

/// <summary>
/// Script qui g�re le contr�le de la cam�ra.
/// </summary>
public class ControlCamera : MonoBehaviour
{
    [Header("base things")]
    /// <summary>
    /// R�f�rence vers le component cam�ra.
    /// </summary>
    [SerializeField] private Camera Camera;

    /// <summary>
    /// R�f�rence � la position du parent de la cam�ra
    /// </summary>
    [SerializeField] private Transform GOParentTransform;

    /// <summary>
    /// Stock les mouvements de la souris
    /// </summary>
    public Vector2 mouseDelta;

    /// <summary>
    /// Vitesse de d�placement de la cam�ra
    /// </summary>
    [SerializeField] private float moveSpeed;

    /// <summary>
    /// GameObject parent de la cam�ra
    /// </summary>
    [SerializeField] private GameObject GameObjectParent;

    /// <summary>
    /// Bool�en disant si on appuit sur le bouton gauche de la souris
    /// </summary>
    private bool isLeftMouseButtonPress;

    [Header("Useless")]
    /// <summary>
    /// valeur max de d�placement sur l'axe X
    /// </summary>
    [SerializeField] private float maxX;

    /// <summary>
    /// valeur min de d�placement sur l'axe X
    /// </summary>
    [SerializeField] private float minX;

    /// <summary>
    /// valeur max de d�placement sur l'axe Z
    /// </summary>
    [SerializeField] private float maxZ;

    /// <summary>
    /// valeur min de d�placement sur l'axe Z
    /// </summary>
    [SerializeField] private float minZ;

    [Header("Bounds")]
    [SerializeField]
    private Bounds cameraLimits;

    [Header("ZoomParameter")]
    public float ZoomMax;
    public float ZoomMin;

    private void Start()
    {
        GOParentTransform = GameObjectParent.transform;
        isLeftMouseButtonPress = false;
    }

    /// <summary>
    /// Fonction permettant de zoomer avec la cam�ra
    /// </summary>
    /// <param name="_context"></param>
    public void OnZoomP(InputAction.CallbackContext _context)
    {
        if (Camera.GetComponent<Camera>().orthographicSize >= ZoomMin)
        {
            Camera.GetComponent<Camera>().orthographicSize -= 0.5f;
            if (Camera.GetComponent<Camera>().orthographicSize <= ZoomMin)
            {
                Camera.GetComponent<Camera>().orthographicSize = ZoomMin;
            }
        }
    }

    /// <summary>
    /// Fonction permettant de d�zoomer
    /// </summary>
    /// <param name="_context"></param>
    public void OnZoomM(InputAction.CallbackContext _context)
    {
        if (Camera.GetComponent<Camera>().orthographicSize <= ZoomMax)
        {
            Camera.GetComponent<Camera>().orthographicSize += 0.5f;
            if (Camera.GetComponent<Camera>().orthographicSize >= ZoomMax)
            {
                Camera.GetComponent<Camera>().orthographicSize = ZoomMax;
            }
        }
    }

    /// <summary>
    /// Fonction qui permet de d�placer la cam�ra
    /// </summary>
    /// <param name="_context"></param>
    public void OnRightClickMove(InputAction.CallbackContext _context)
    {
        if (_context.started)
        {
            isLeftMouseButtonPress = true;
            //Cursor.lockState = CursorLockMode.Locked;
        }

        if (_context.canceled)
        {
            isLeftMouseButtonPress = false;
            //Cursor.lockState = CursorLockMode.None;
        }
    }

    private void Update()
    {
        if (!isLeftMouseButtonPress) return;

        // R�cup�rer les mouvements de la souris
        Vector2 mouseMovement = Mouse.current.delta.ReadValue();

        // Convertir le mouvement de la souris en Vector3
        mouseDelta += moveSpeed * Time.deltaTime * mouseMovement;

        Vector3 mouseScreen = new Vector3(-mouseDelta.x, 0, -mouseDelta.y);

        Vector3 mouseIso =  mouseScreen;

        Vector3 targetPosition = GOParentTransform.position + mouseIso;

        GOParentTransform.position = cameraLimits.ClosestPoint(targetPosition);

        // R�initialiser le mouvement de la souris pour le frame suivant
        mouseDelta = Vector2.zero;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;

        Gizmos.DrawWireCube(cameraLimits.center, cameraLimits.size);
    }
}