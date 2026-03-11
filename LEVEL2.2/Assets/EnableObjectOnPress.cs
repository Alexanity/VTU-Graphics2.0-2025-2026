using UnityEngine;

public class EnableObjectOnPress : MonoBehaviour
{
    public GameObject objectToToggle;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (objectToToggle != null)
            {
                objectToToggle.SetActive(!objectToToggle.activeSelf);
            }
        }
    }
}
