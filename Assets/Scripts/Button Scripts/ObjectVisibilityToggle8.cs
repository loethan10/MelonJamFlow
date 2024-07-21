using UnityEngine;

public class ObjectVisibilityToggle8 : MonoBehaviour
{
    public GameObject objectToToggle;
    //public float toggleDistance = 3f;
    public bool objectVisible = false;
    public WordBank wordBank = null;
    public bool showButton = false;

    private void Start()
    {
        objectToToggle.SetActive(false); // Set object initially invisible
    }

    private void Update()
    {
        if (wordBank.level8Done && objectToToggle != null)
        {
            ToggleObjectVisibility();
        }
    }

    public void ToggleObjectVisibility()
    {
        if (!objectVisible || wordBank.level8Done)
        {
            Vector3 playerPosition = transform.position;
            Vector3 objectPosition = objectToToggle.transform.position;
            float distance = Vector3.Distance(playerPosition, objectPosition);

            if (true)
            {
                objectVisible = true;
                objectToToggle.SetActive(true); // Set object visible
            }
        } else {
            Vector3 playerPosition = transform.position;
            Vector3 objectPosition = objectToToggle.transform.position;
            float distance = Vector3.Distance(playerPosition, objectPosition);

            if (true)
            {
                objectVisible = false;
                objectToToggle.SetActive(false); // Set object visible
            }
        }
    }
}
