/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/19/2021
 * Time: 10:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace singleton
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Mysinlgeton mysingleton = Mysinlgeton.Instance;
			mysingleton.Dosomething();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public class Mysinlgeton
		{
			private static Mysinlgeton instance = null; //new Mysinlgeton(); // instance of the class
			private Mysinlgeton(){
			//private constructor which disallows the creation of new instance
			}
			
			public static Mysinlgeton Instance
			{
				get{ 
					if(instance == null)
					{
						instance = new Mysinlgeton();
					}
					
						return instance;
					} // methoda to expose the instance so the functionality of the single is shown
			}
			public void Dosomething()
			{
				Console.WriteLine("Singleto class as been called ");
				Console.ReadLine();
			}
		}
	}
}