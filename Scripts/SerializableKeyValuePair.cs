using System;
using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// シリアライズ可能な KeyValuePair
	/// </summary>
	[Serializable]
	public abstract class SerializableKeyValuePair<TKey, TValue>
	{
		[SerializeField] private TKey   m_key   = default;
		[SerializeField] private TValue m_value = default;

		/// <summary>
		/// キーを返します
		/// </summary>
		public TKey Key => m_key;

		/// <summary>
		/// 値を返します
		/// </summary>
		public TValue Value => m_value;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		protected SerializableKeyValuePair()
		{
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		protected SerializableKeyValuePair( TKey key, TValue value )
		{
			m_key   = key;
			m_value = value;
		}
	}
}