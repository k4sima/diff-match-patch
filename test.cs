using System.Collections;
using System.Collections.Generic;
using DiffMatchPatch;
using UnityEngine;
public class test : MonoBehaviour
{
	private string str1 = "test";
	private string str2 = "testabc";
	void Start()
	{
		var dmp = new diff_match_patch();
		var diff = dmp.diff_main(str1, str2);
		//dmp.diff_cleanupSemantic(diff);
		foreach (var result in diff)
		{
			Debug.Log(result.operation + ": " + result.text);//同じ箇所はEQUAL、追加された箇所はINSERT
		}
		//Debug.Log(diff[1].text); //diff[0]=EQUAL diff[1]=INSERT
	}
}