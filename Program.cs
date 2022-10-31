string[] CreateArray (int Length){
    var userArray = new string[Length];
    
for (int i = 0; i < userArray.Length; i++){
    System.Console.WriteLine("Введите строку");
    userArray[i] = Console.ReadLine();
}
return userArray;
}  

void PrintArray(string[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++){
         System.Console.WriteLine(arrayForPrint[i]);
    }
}
PrintArray(CreateArray (3));
