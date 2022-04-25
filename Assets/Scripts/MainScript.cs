using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{

    public Text jsonOutput;

    void Start()
    {
        jsonOutput.text = JsonConvert.SerializeObject(new [] {1, 2, 3 });
    }

}
