using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Camera cam;
    public static CameraFollow singleton;
    public bool isControllable = true;
    private Vector3 screenPoint;
    private Vector3 offset;
    public Transform target;
    public float distance = 7.0f;
    public float xSpeed = 15.0f;
    public float ySpeed = 15.0f;

    public float yMinLimit = 15f;
    public float yMaxLimit = 50f;

    public float distanceMin = .5f;
    public float distanceMax = 15f;

    public float smoothTime = 3f;

    public float rotationYAxis = 0.0f;
    float rotationXAxis = 0.0f;

    float velocityX = 0.0f;
    float velocityY = 0.0f;
    float moveDirection = -1;
    private void Awake()
    {

        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }
    public void SetControllable(bool value)
    {
        isControllable = value;
    }

    // Use this for initialization
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
        Vector3 angles = transform.eulerAngles;
        rotationYAxis = (rotationYAxis == 0) ? angles.y : rotationYAxis;
        rotationXAxis = angles.x;

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // Make the rigid body not change rotation
        if (rigidbody)
        {
            rigidbody.freezeRotation = true;
        }
    }

    void LateUpdate()
    {
        if (target)
        {
            if (isControllable)
            {
                if (Input.GetMouseButton(1) && isControllable)
                {
                    velocityX += xSpeed * Input.GetAxis("Mouse X") * 0.02f;
                    velocityY += ySpeed * Input.GetAxis("Mouse Y") * 0.02f;
                }


                if (Input.GetMouseButton(2) && isControllable)
                {
                    Vector3 curScreenPoint = new Vector3(moveDirection * Input.mousePosition.x, moveDirection * Input.mousePosition.y, screenPoint.z);

                    Vector3 curPosition = cam.ScreenToWorldPoint(curScreenPoint) + offset;
                    target.transform.position = curPosition;
                }

                if (Input.GetKeyDown(KeyCode.R) && isControllable)
                {
                    target.transform.position = Vector3.zero;
                }

                if (Input.GetKeyDown(KeyCode.T) && isControllable)
                {
                    moveDirection *= -1;
                }

                if (isControllable)
                {
                    distance -= Input.GetAxis("Mouse ScrollWheel");

                    if (distance > distanceMax)
                    {
                        distance = distanceMax;
                    }
                    else if (distance < distanceMin)
                    {
                        distance = distanceMin;
                    }
                }

                rotationYAxis += velocityX;
                rotationXAxis -= velocityY;

                rotationXAxis = ClampAngle(rotationXAxis, yMinLimit, yMaxLimit);

                Quaternion fromRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
                Quaternion toRotation = Quaternion.Euler(rotationXAxis, rotationYAxis, 0);
                Quaternion rotation = toRotation;

                Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
                Vector3 position = rotation * negDistance + target.position;

                transform.rotation = rotation;
                transform.position = position;

                velocityX = Mathf.Lerp(velocityX, 0, Time.deltaTime * smoothTime);
                velocityY = Mathf.Lerp(velocityY, 0, Time.deltaTime * smoothTime);

                screenPoint = cam.WorldToScreenPoint(target.transform.position);
                offset = target.transform.position - cam.ScreenToWorldPoint(new Vector3(moveDirection * Input.mousePosition.x, moveDirection * Input.mousePosition.y, screenPoint.z));
            }
        }
        else
        {
            Debug.LogError("No Transform Assigned! Assign the camera a target in the inspector...");
        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}

