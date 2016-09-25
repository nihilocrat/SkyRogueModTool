using UnityEngine;
using System.Collections;

public class Description : MonoBehaviour
{
	public string fullName = "";
	public string shortName = "MiG-92";
	[TextArea()]
	public string description = "";

	public string combinedName
	{
		get
		{
			return string.Format("'{1}' {0}", fullName, shortName);
		}
	}

	public string shortDescription
	{
		get
		{
			// return first line of text
			return description.Split('\n')[0];
		}
	}
}
