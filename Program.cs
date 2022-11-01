 string Prompt(string message)
{
    Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

string[] CreateArray (int Length){
    var userArray = new string[Length];
    
for (int i = 0; i < userArray.Length; i++){
    System.Console.WriteLine($"Введите {i+1}-ю строку");
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
int HowManyStrings(string[] arrayForCheck){
    int count = 0;
    for (int i = 0; i < arrayForCheck.Length; i++){
        if (arrayForCheck[i].Length <= 3){
            count++;
        }
}
return count;
}

string[] ReconfigArray(string[] arrayForCheck, int Length){
    string[] finalArray = new string[Length];
    int count = 0;
    for (int i = 0; i < arrayForCheck.Length; i++){
        if (arrayForCheck[i].Length <= 3){
            finalArray[count] = arrayForCheck[i];
            count++;}
    }
return finalArray;
}
int lengthArray = Convert.ToInt32(Prompt("Введите количество строк > "));
string[] reqArray = CreateArray(lengthArray);
int neededNumber =  HowManyStrings(reqArray);
string[] arrayForPrint = ReconfigArray(reqArray,neededNumber );
System.Console.WriteLine($"Среди строк, введенных Вами {neededNumber} содержат меньше четырех символов. Вот они:");
PrintArray(arrayForPrint);