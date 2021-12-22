// See https://aka.ms/new-console-template for more information


Console.WriteLine("dictionary");
// Type Parameters
// TKey
// The type of the keys in the dictionary.

// TValue
// The type of the values in the dictionary.

// Inheritance
// Object
// Dictionary<TKey,TValue>
// Derived
// System.ServiceModel.MessageQuerySet


// Dictionary<string, string> openWith =
//     new Dictionary<string, string>();

// List<Dictionary<int, string>> first = new List<Dictionary<int, string>>();
// first.Add()

// employe.Append(first);
//???? how we can thattt    as mohammad bepors 


// Dictionary<int, string> employe = new Dictionary<int, string>();
// var emGroup = new Dictionary<int, string>();
// employe.Add(1, "Ahmad");
// employe.Add(2, "Nastaran");
// employe.Add(3, "Qolam");
// employe.Add(4, "Taqi");
// ///employe.Add(4, "Ahmad"); Show me Error
// employe.Add(5, null);
// employe.Add(6, "Name");
// employe.Remove(6);

// foreach (var item in employe)
// {
//     System.Console.WriteLine(item);
// }

// //employe.Add(null, null); Show me Error 

// var keys = employe.Keys.ToArray();
// var Values = employe.Values.ToArray();
// for (int i = 0; i < keys.Length; i++)
// {
//     System.Console.WriteLine($"{keys[i]} {Values[i]}");
// }


// System.Console.WriteLine(employe.GetValueOrDefault(3)); //o(1)
// System.Console.WriteLine(employe.ContainsKey(7));  //o(nw)
// System.Console.WriteLine(employe.ContainsValue("Name"));
// System.Console.WriteLine("Update Dictionary");
// employe[3] = "VAli";

// System.Console.WriteLine(employe[3]);

System.Console.WriteLine("Exercise");
//  a first carecter that dont  Repeated
//A green Apple 

var RepeatCharacter = new RepeatCharacter("A green Apple ");
///System.Console.WriteLine(RepeatCharacter.DontRepeat());
System.Console.WriteLine(RepeatCharacter.Repeat());




///set interface  exacucly look like dic but dosent have value just key 

HashSet<int> myhash1 = new HashSet<int>();
int[] numbers = { 1, 2, 3, 4, 5, 6, 6, 8 };

foreach (var item in numbers)
{
    myhash1.Add(item);
}
myhash1.Remove(1);

foreach (var item in myhash1)
{
    System.Console.WriteLine();
}


var repeatObj = new repeat("A green Apple");
System.Console.WriteLine("repeatObj");
System.Console.WriteLine(repeatObj.repetCharecter());



///HAsh code 
string Name = "Ahmadreza";
System.Console.WriteLine("Hash code !");
System.Console.WriteLine(Name.GetHashCode());