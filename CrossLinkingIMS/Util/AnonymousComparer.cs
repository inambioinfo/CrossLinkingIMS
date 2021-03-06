﻿using System;
using System.Collections.Generic;

namespace CrossLinkingIMS.Util
{
	/// <summary>
	/// Class used for helping create an IComparer class for binary search.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class AnonymousComparer<T> : IComparer<T>
	{
		private Comparison<T> m_comparison;

		/// <summary>
		/// Constructor that requires the Comparison be passed in.
		/// </summary>
		/// <param name="comparison">The Comparison to be used for the binary search.</param>
		public AnonymousComparer(Comparison<T> comparison)
		{
			if (comparison == null)
			{
				throw new ArgumentNullException("comparison");
			}
			this.m_comparison = comparison;
		}

		/// <summary>
		/// Compares 2 objects using the Comparison passed in when creating the AnonymousComparer class.
		/// </summary>
		/// <param name="x">The first object.</param>
		/// <param name="y">The second object.</param>
		/// <returns>
		/// Less than zero if the first object precedes the second. 
		/// Zero if the objects occur in the same position.
		/// Greater than zero if the first object follows the second.
		/// </returns>
		public int Compare(T x, T y)
		{
			return m_comparison(x, y);
		}
	}
}
