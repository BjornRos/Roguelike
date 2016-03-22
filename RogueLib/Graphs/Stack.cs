
using System.Collections;
using System.Collections.Generic;

namespace RogueLib.Graphs {
	public class Stack<T> {

		private List<T> Heap;

		public Stack()
		{
			Heap = new List<T> ();
		}

		public void Push (T obj)
		{
			Heap.Add (obj);
		}

		public T Pop ()
		{
			T obj = Heap [Heap.Count - 1];

			Heap.Remove (obj);

			return obj;
		}

		public bool NotEmpty()
		{
			return (Heap.Count > 0);
		}

		public override string ToString()
		{
			string s = string.Empty;
			foreach (T obj in Heap)
								s += obj.ToString () + " ";
			return s;
		}
	}
}