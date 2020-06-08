using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// シリアライズ可能な Dictionary
	/// </summary>
	[Serializable]
	public abstract class SerializableDictionary<TKey, TValue, TPair> : IEnumerable<TPair>
		where TPair : SerializableKeyValuePair<TKey, TValue>, new()
	{
		[SerializeField] private List<TPair> m_list = new List<TPair>();

		private Dictionary<TKey, TValue> m_table;

		/// <summary>
		/// 指定されたキーに紐付く値を返します
		/// </summary>
		public TValue this[ TKey key ]
		{
			get
			{
				var pair = m_list.Find( c => c.Key.Equals( key ) );
				return pair.Value;
			}
		}

		/// <summary>
		/// Dictionary を返します
		/// </summary>
		public Dictionary<TKey, TValue> Table => m_table ?? ( m_table = ListToDictionary( m_list ) );

		/// <summary>
		/// m_list を Dictionary に変換して返します
		/// </summary>
		private static Dictionary<TKey, TValue> ListToDictionary( IList<TPair> list )
		{
			var dict = new Dictionary<TKey, TValue>();

			foreach ( var n in list )
			{
				dict.Add( n.Key, n.Value );
			}

			return dict;
		}

		/// <summary>
		/// コレクションを反復処理する列挙子を返します
		/// </summary>
		IEnumerator<TPair> IEnumerable<TPair>.GetEnumerator()
		{
			foreach ( var n in m_list )
			{
				yield return n;
			}
		}

		/// <summary>
		/// コレクションを反復処理する列挙子を返します
		/// </summary>
		IEnumerator IEnumerable.GetEnumerator()
		{
			foreach ( var n in m_list )
			{
				yield return n;
			}
		}
	}
}