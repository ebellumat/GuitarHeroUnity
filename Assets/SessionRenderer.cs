using UnityEngine;
using UnityEngine.UI;
public class SessionRenderer : MonoBehaviour
{
	public RectTransform[] outputs;
	public RectTransform group;
	public void Initialize(RenderTexture[] textures)
	{
		for (int i = 0; i < outputs.Length; ++i)
		{
			outputs[i].gameObject.SetActive(i < textures.Length);
			
		}
		for (int i = 0; i < textures.Length; ++i)
		{
			outputs[i].GetComponent<RawImage>().texture = textures[i];
		}
		var myRect = transform;
		Vector2 groupSizeDelta = group.sizeDelta;
		groupSizeDelta.x = myRect.position.x;
		groupSizeDelta.y = myRect.position.x / textures.Length;
		if (groupSizeDelta.y > myRect.position.y)
		{
			groupSizeDelta *= myRect.position.y / groupSizeDelta.y;
		}
		group.sizeDelta = groupSizeDelta;
	}
}