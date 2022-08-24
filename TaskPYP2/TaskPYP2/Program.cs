#region Task2
//int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

//Console.WriteLine("Enter the number");
//int input = int.Parse(Console.ReadLine());

//Console.WriteLine(Array.Exists(numbers, number => number == input)); 

#endregion

#region Task 3

//int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

//Array.ForEach(numbers, Console.WriteLine);
//Array.ForEach(numbers, x => Console.WriteLine(x));

#endregion

#region Task 1
//int[] numbers = new int[] { 1, 2, 3, 4, 5, 6,4 };
//int num = Convert.ToInt32(Console.ReadLine());
//int[] duplicates = Array.FindAll(numbers, x => x == num);
//if (duplicates.Length>1)
//{
//    Console.WriteLine("Tekrarlanir");
//}
//else if (duplicates.Length == 1)
//{
//    Console.WriteLine("Var tekrari yoxdur");
//}
//else
//{
//    Console.WriteLine("yoxdur");
//}

//bool result = false;
//for (int i = 0; i < numbers.Length; i++)
//{
//	for (int j = i+1; j < numbers.Length; j++)
//	{
//		if (numbers[j] == numbers[i])
//		{
//			result = true; break;
//		} 
//	}
//}
//if (result) Console.WriteLine("Tekrar element var");
//else Console.WriteLine("Tekrar element yoxdur");
#endregion

#region Task 4

//string[] words = { "c#", "java", "javaScript" };

//string input = Console.ReadLine();

//string[] newWords = Array.FindAll(words, w => w.StartsWith(input));

//for (int i = 0; i < newWords.Length; i++)
//{
//    Console.WriteLine(newWords[i]);
//}

#endregion

#region Task 6

//addArray(numbers, numbers1);
//void addArray(int[] arr1, int[] arr2)
//{
//    int[] sameNumbers = new int[0];
//    int[] differentNumbers = new int[0];
//    for (int i = 0; i < arr1.Length; i++)
//    {
//        if (Array.Exists(arr2, x => x == arr1[i]))
//        {
//            Array.Resize(ref sameNumbers, sameNumbers.Length + 1);
//            sameNumbers[sameNumbers.Length - 1] = arr1[i];
//        }
//        else
//        {
//            Array.Resize(ref differentNumbers, differentNumbers.Length + 1);
//            differentNumbers[differentNumbers.Length - 1] = arr1[i];
//        }
//    }
//    for (int i = 0; i < arr2.Length; i++)
//    {
//        if (Array.Exists(sameNumbers, x => x == arr2[i]) ){
//            continue;
//        }
//        else 
//        {
//            Array.Resize(ref differentNumbers, differentNumbers.Length + 1);
//            differentNumbers[differentNumbers.Length - 1] = arr2[i];
//        }
//    }
//    Console.WriteLine("Eyni elementler");
//    for (int i = 0; i < sameNumbers.Length; i++)
//    {
//        Console.Write(sameNumbers[i]+",");
//    }
//    Console.WriteLine();
//    Console.WriteLine("Ferqli elementler");
//    for (int i = 0; i < differentNumbers.Length; i++)
//    {
//        Console.Write(differentNumbers[i] + ",");
//    }

//}

int[] numbers1 = new int[] { 1, 2, 3, 4, 5, 6, 11,14 ,16,19};
int[] numbers2 = new int[] { 1, 2, 3, 4,5, 8, 9, 10,12 };

// Except()
int[] diffrents = numbers1.Except(numbers2).ToArray().Concat(numbers2.Except(numbers1).ToArray()).ToArray();
int[]  same = numbers1.Except(diffrents).ToArray();
Console.WriteLine("=========================================");
Console.WriteLine("The Diffrent Numbers");

Array.ForEach(diffrents, Console.WriteLine);

Console.WriteLine("=========================================");
Console.WriteLine("The Same Numbers");
Array.ForEach(same, Console.WriteLine);


// FindAll()
Console.WriteLine("=========================================");
Console.WriteLine("The Same Numbers");
int[] sameNumber = Array.FindAll(numbers1, x => Array.Exists(numbers2, y => y == x));

Array.ForEach(sameNumber, Console.WriteLine);

#endregion

#region ClassTask
// Ədədlərdən ibarət arrayın ən kiçik elementini tapın
Console.WriteLine("=========================================");
int[]arr = {2,5,7,55,4,8,9,-10, -565,};
//int min = arr[0];
//int max = arr[0];
//for (int i = 1; i < arr.Length; i++)
//{
//	if (min > arr[i])
//	{
//		min = arr[i];
//	}
//	if (max < arr[i])
//	{
//		max = arr[i];

//    }
//}

// insertion sort
for(int j = 1; j < arr.Length; j++)
{
    int curr = arr[j];
    int i = j - 1;
    
    while(i >= 0 && arr[i] > curr)
    {
        arr[i + 1] = arr[i];
        i--;
    }
    arr[i + 1] = curr;
}


Console.WriteLine($"min {arr[0]} max {arr[arr.Length - 1]}");
#endregion

#region ClassTask2
Console.WriteLine("=========================================");
// Ədədlərdən ibarət arrayda neçə rəqəm olduğunu ekrana çap edin { 1,44,7,8,55,67}
int[] digit = { 2, 5, 7, 55, 4, 8, 9, -10, -565,-3 };
int count = 0;
foreach (var item in arr)
{
    if (item < 10 && item >= 0) count++;

}
Console.WriteLine(count);


#endregion


