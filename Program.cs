string[] GetListWith3Char(List<string> list) {
    var newList = list.Where(a => a.Length <= 3).ToArray();
    return newList;
}

Console.WriteLine("Write words/strings. Click enter to add to the list. To finish the list, click enter without any letters... In return you will get an array of words whose length is less than or equal to 3 characters:");
var stringList = new List<string>();
var finished = false;
while(!finished) {
    var input = Console.ReadLine()?.Trim();
    if (string.IsNullOrWhiteSpace(input)) finished = true;
    else stringList.Add(input);
}

if (!stringList.Any()) {
    Console.WriteLine("List is empty...");
    return;
}

Console.WriteLine("These words contain 3 or less letters");
var arr = GetListWith3Char(stringList);
foreach (var str in arr) Console.Write($"{str} ");
