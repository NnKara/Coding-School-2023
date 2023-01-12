
using Session_04;
//Exercise #1 
HelloName newHelloName = new HelloName();
Console.WriteLine(newHelloName.helloName());
Console.WriteLine("\n");

//Exercise #2
SumAndDivisionOfTwoNumbers newSumDivizionNumbers = new SumAndDivisionOfTwoNumbers();
Console.WriteLine(newSumDivizionNumbers.sumOfTwoNumbers());
Console.WriteLine(newSumDivizionNumbers.divizionOfTwoNumbers());
Console.WriteLine("\n");

//Exercise #3
ResultOfSpecifiedOperations newResult = new ResultOfSpecifiedOperations();
Console.WriteLine(newResult.firstBullet());
Console.WriteLine(newResult.secondBullet());
Console.WriteLine(newResult.thirdBullet());
Console.WriteLine(newResult.fourthBullet());
Console.WriteLine(newResult.fifthBullet());
Console.WriteLine("\n");

//Exercise #4
ProgrammForAgeAndNumberString newString = new ProgrammForAgeAndNumberString();
Console.WriteLine(newString.printAgeAndgender());
Console.WriteLine("\n");

//Exercise #5
IntegerRepresentingSeconds newRepresenting = new IntegerRepresentingSeconds();
newRepresenting.represantation();
Console.WriteLine("\n");

//Exercise #6
NewVersionOfProgram5 newVersion = new NewVersionOfProgram5();
newVersion.operatingSeconds();
Console.WriteLine("\n");

//Exercise #7
CelsiusToKelvinAndFahrenheit newConverter = new CelsiusToKelvinAndFahrenheit();
newConverter.convertCelsius();

Console.ReadLine();

