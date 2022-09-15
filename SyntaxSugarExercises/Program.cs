//Exercise 1:
//Given the following code, change the code to implement:
//inferred typing
//string interpolation
//and the ternary operator
//int answer = 4;
//string response;
//if (answer < 9)
//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + " is greater than or equal to nine";
//}

var answer = 4;
var response= (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than nine";
Console.WriteLine(response);
