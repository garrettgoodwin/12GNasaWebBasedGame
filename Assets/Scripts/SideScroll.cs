using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScroll : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        MeshRenderer mrend = GetComponent<MeshRenderer>();

        Material Background = mrend.material;

        Vector2 offset = Background.mainTextureOffset;

        offset.x += Time.deltaTime / 10;
        
        Background.mainTextureOffset = offset;

    }
}
