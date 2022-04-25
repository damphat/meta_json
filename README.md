## JSON .NET in Unity

```cs
public class MainScript : MonoBehaviour
{
    public Text jsonOutput;

    void Start()
    {
        jsonOutput.text = JsonConvert.SerializeObject(new [] {1, 2, 3 });
    }

}
```

## Issues

- [ ] it does not work on `Windows Platform` target?
