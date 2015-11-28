#include <stdio.h>

int main( void )
{
	int number1;
	int number2;
	int sum;
	int product;
	int difference;
	int quotient;
	int remainder;

	printf( "Enter first number\n" );
	scanf( "%d", &number1 );

	printf( "Enter second number\n" );
	scanf( "%d", &number2 );

	sum = number1 + number2;
	product = number1 * number2;
	difference = number1 - number2;
	quotient = number1 / number2;
	remainder = number1 % number2;

	printf("Sum is %d\n", sum );
	printf("Product is %d\n", product );
	printf("Difference is %d\n", difference );
	printf("Quotient is %d\n", quotient );
	printf("Remainder is %d\n", remainder );

	return 0;
}