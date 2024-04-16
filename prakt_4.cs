using System;
using System.Collections.Generic;
//(6-1)mod3+1=3
namespace xoba{
	interface ITask{
		void Execute();
		void Complete();
	}
	class Task : ITask{
		public string name { set; get; }
		public Task(string nam){ name = nam;}
		public void Execute(){
			Console.WriteLine($"Executing task {name}...\n");
		}
		public void Complete(){
			Console.WriteLine($"task {name} complete.\n");
		}
	}
	abstract class Figure{
		public abstract double CalculateVolume();
	}
	class Cube : Figure{
		public double side{ set; get; }
		public Cube(double x){side = x;}
		public override double CalculateVolume(){
			return side*side*side;
		}	
	}
	class Sphere : Figure{
		public const double pi = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234603486104543266482133936072602491412737245870066063155881748815209209628292540917153643678925903600113305305488204665213841469519415116094330572703657591951;
		public double radius{ set; get; }
		public Sphere(double x){ radius = x;}
		public override double CalculateVolume(){
			return (4*pi*(radius*radius*radius))/3;
		}
	}
	class BankAccount : IComparable<BankAccount>{
		public int balance { get; set; }
		public BankAccount(int x){ balance = x;}
		public int CompareTo(BankAccount other){
			return this.balance.CompareTo(other.balance);
		}
	}
	class Person{
		public string name{ get; set; }
		public int age{ get; set; }
		public Person(string nam, int ag){ name = nam; age = ag;}
		public static bool operator ==(Person uno, Person dos){
			return (uno.name == dos.name) && (uno.age == dos.age);
		}
		public static bool operator !=(Person uno, Person dos){
			return !((uno.name == dos.name) && (uno.age == dos.age));
		}
	}
	class Program{
		static void Main(){
			Task task = new Task("do homework");
			task.Execute();
			task.Complete();
			Cube cubik = new Cube(3);
			Console.WriteLine($"Volume of cube = {cubik.CalculateVolume()}\n");
			Sphere kulya = new Sphere(5);
			Console.WriteLine($"Volume of sphere = {kulya.CalculateVolume()}\n");
			BankAccount eins = new BankAccount(333);
			BankAccount zwei = new BankAccount(777);
			Console.WriteLine($"{eins.CompareTo(zwei)}\n");
			Person tolya = new Person("tolya", 20);
			Person bogdan = new Person("bogdan", 30);
			Console.WriteLine($"{tolya == bogdan}\n\n{bogdan == bogdan}\n\n");
		}	
	}
}
