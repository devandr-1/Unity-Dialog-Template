using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]
    Text textComponent;

    [SerializeField]
    State statingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = statingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();
    }

    private void ManageStates()
    {
        State[] nextStates = state.GetNextStates();
        if (nextStates.Length > 0 && Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (nextStates.Length > 1 && Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (nextStates.Length > 2 && Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        else
        {
            Debug.Log("There is no option for your choise");
        }
        textComponent.text = state.GetStateStory();
    }
}
