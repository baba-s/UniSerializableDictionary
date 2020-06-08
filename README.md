# Uni Serializable Dictionary

Dictionary を Inspector で設定できるようにするクラス

## 使用例

```cs
using Kogane;
using System;
using UnityEngine;

public class Example : MonoBehaviour
{
	[Serializable]
	public class IntStringKeyValuePair : SerializableKeyValuePair<int, string> { }
	
	[Serializable]
	public class IntStringDictionary : SerializableDictionary<int, string, IntStringKeyValuePair> { }

	public IntStringDictionary m_table;
}
```

![2020-04-22_230415](https://user-images.githubusercontent.com/6134875/79991874-bc54a180-84ed-11ea-94a1-85a48cf2964c.png)

## 参考サイト様

https://qiita.com/k_yanase/items/fb64ccfe1c14567a907d