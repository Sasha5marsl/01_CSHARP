int i1 =5;
int i2 = 6;
int sum = i1 + i2;
System.Console.WriteLine(sum);

// sum - это бинарная операция, где участие приниамют два операнда, соответственно результату сложения присваиваем тип данных как у операндов.
// ctrl+S - сохраняет введенные данные кода

long l1 = 6;
long sum2 = l1 + i1;
System.Console.WriteLine(sum2);

// переменной ыгь2 присвоим тип данных long , следуя правилу:
// если типы данных у операндов разные, то выбираем тот , что объемнее и вместительнее.

double d1 = 5.5;
double sum3 = d1 + i1;
System.Console.WriteLine(sum3);

int product1 = i1 * i2;
long product2 = l1 * i1;
double product3 = i1 * d1;
System.Console.WriteLine(product1);
System.Console.WriteLine(product2);
System.Console.WriteLine(product3);

int quotient = i1 / i2; // quotient - переводится частное
System.Console.WriteLine(quotient);

// на консоли мы видем в результате 0, поскольку тип данных был указан - целочисленное
// для того, чтобы на экран выводилось не целое число, необходимо,
// чтобы хотя бы одна переменная была типа duoble

d1 = 6;
double quotient2 = i1 / d1;
System.Console.WriteLine(quotient2);

