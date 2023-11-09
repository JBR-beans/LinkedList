﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritola_LinkedList
{
	public class Node
	{
		public string Data { get; set; }
		public Node Next { get; set; }

		public Node(string data)
		{
			Data = data;
			Next = null;
		}
	}
}
