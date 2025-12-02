using UnityEngine;

public class NewBehaviourScriptCapsule : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("test HI MOM!!!");
    }

    // Update is called once per frame
    void Update()
    {
        float fps = 1.0f / Time.deltaTime;
        Debug.Log("Fps: " + fps + " per/sec");
    }
}
