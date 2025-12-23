using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml;
using PracticeQuestions;


PrimeNumberChecker P = new PrimeNumberChecker();
int num=2;
bool checkPrime = P.IsPrime(num);

// Console.WriteLine($"Number {num} is Prime: {checkPrime}");
// Console.WriteLine($"Number {1} is Prime: {P.IsPrime(1)}");
// Console.WriteLine($"Number {2} is Prime: {P.IsPrime(2)}");
// Console.WriteLine($"Number {3} is Prime: {P.IsPrime(3)}");
// Console.WriteLine($"Number {4} is Prime: {P.IsPrime(4)}");
// Console.WriteLine($"Number {5} is Prime: {P.IsPrime(5)}");
// Console.WriteLine($"Number {6} is Prime: {P.IsPrime(6)}");

// HeightChecker H = new HeightChecker();
// Console.WriteLine($"Height is : {H.checkHeight(190)}");

// LeapYearChecker L = new LeapYearChecker();
// int year = 2004;
// Console.WriteLine($"{year} is leap year: {L.IsLeapYear(year)}");

// VowelChecker v = new VowelChecker();
// char c = 'w';
// Console.WriteLine($"{c} is vowel: {v.IsVowel(c)}");

// TriangleChecker t = new TriangleChecker();
// int a = 3;
// int b = 2;
// int c = 5;
// Console.WriteLine($"Triangle type is: {t.checkTriangleType(a,b,c)}");

// GradeChecker g = new GradeChecker();
// Console.WriteLine($"Grade : {g.getGradeRemarks('A')}");

// DateChecker d = new DateChecker();
// Console.WriteLine($"date is valid: {d.IsValidDate(29,2,2000)}");

ArmstrongNumberChecker A = new ArmstrongNumberChecker();
Console.WriteLine(A.IsValidArmstrongNumber(123));

BasicMaths B = new BasicMaths();
int a = 48;
int b = 18;
Console.WriteLine($"GCd of {a} and {b}: {B.findGCD(a,b)}");
Console.WriteLine($"LCM of {a} and {b}: {B.findLCM(a,b)}");

Pattern p = new Pattern();
p.printDiamondPattern(5);


FactorialFinder f = new FactorialFinder();
Console.WriteLine($"Factorial of 5:{f.findFactorial(5)}");

StrongNumberChecker s = new StrongNumberChecker();
int x = 145;
Console.WriteLine($"{x} is strong number ? : {s.IsStrongNumber(x)}");

DigitalRootFinder D = new DigitalRootFinder();
num = 9875;
Console.WriteLine($"Digital Root of {num} : {D.findDigitalRoot(num)}");

BinaryConverter Bin = new BinaryConverter();
string binary = "1011";
Console.WriteLine($"Binary{binary} to Decimal: {Bin.ToDecimal(binary)}");