using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassthroughSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var passthrough = gameObject.AddComponent<OVRPassthroughLayer>();

        passthrough.enabled = true;
        passthrough.overlayType = OVROverlay.OverlayType.Underlay;
        passthrough.edgeRenderingEnabled = false;
        passthrough.colorMapEditorBrightness = 1.0f;
        passthrough.colorMapEditorContrast = 1.2f;
        passthrough.colorMapEditorSaturation = 1.1f;
    }
}
