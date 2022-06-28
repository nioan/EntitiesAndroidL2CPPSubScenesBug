using TMPro;
using Unity.Entities;
using UnityEngine;

public class EntityCounters : MonoBehaviour {
    private static EntityManager Em => World.DefaultGameObjectInjectionWorld.EntityManager;

    public TextMeshProUGUI Text;

    public int build = 5;

    private int firstVal = -1;
    // Update is called once per frame
    private void Update() {
        var all = Em.GetAllEntities();
        if (firstVal == -1) firstVal = all.Length;
        var msg = $"B:{build} [@{Time.frameCount}] - E:{all.Length} / {firstVal}";
        all.Dispose();
        Debug.Log(msg);
        Text.text = msg;
    }
}
