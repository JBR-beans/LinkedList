using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritola_LinkedList
{
	public class LinkedList
	{
		private Node head;

		public LinkedList()
		{
			head = null;
		}

		public void Add(string item)
		{
			Node newNode = new Node(item);
			if (head == null || string.Compare(item, head.Data, StringComparison.OrdinalIgnoreCase) < 0)
			{
				newNode.Next = head;
				head = newNode;
			}
			else
			{
				Node current = head;
				while (current.Next != null && string.Compare(item, current.Next.Data, StringComparison.OrdinalIgnoreCase) > 0)
				{
					current = current.Next;
				}

				newNode.Next = current.Next;
				current.Next = newNode;
			}
		}

		public bool Contains(string item)
		{
			Node current = head;
			while (current != null)
			{
				if (string.Compare(item, current.Data, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return true;
				}
				current = current.Next;
			}
			return false;
		}

		public bool Remove(string item)
		{
			if (head == null)
				return false;

			if (string.Compare(item, head.Data, StringComparison.OrdinalIgnoreCase) == 0)
			{
				head = head.Next;
				return true;
			}

			Node current = head;
			while (current.Next != null && string.Compare(item, current.Next.Data, StringComparison.OrdinalIgnoreCase) != 0)
			{
				current = current.Next;
			}

			if (current.Next == null)
				return false;

			current.Next = current.Next.Next;
			return true;
		}

		public void PrintAllNodes()
		{
			Node current = head;
			while (current != null)
			{
				Console.WriteLine(current.Data);
				current = current.Next;
			}
		}
	}
}
