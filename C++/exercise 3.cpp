#include <stdio.h>

int main( void )
{
	int number1;
	int number2;
	int number3;
	int sum;
	int average;
	int product;

	printf( "Enter first number\n" );
	scanf( "%d", &number1 );

	printf( "Enter second number\n" );
	scanf( "%d", &number2 );

	printf( "Enter third number\n" );
	scanf( "%d", &number3 );

	sum = number1 + number2 + number3;
	average = ( number1 + number2 + number3 ) / 3;
	product = number1 * number2 * number3;

	printf("Sum is %d\n", sum );
	printf("Average is %d\n", average );
	printf("Product is %d\n", product );
	
	if ( number1 < number2 ) {
		if ( number1 < number3 ) {
		printf( "Smallest is %d\n", number1 );
		}
	}
	
	if ( number2 < number1 ) {
		if ( number2 < number3 ) {
		printf( "Smallest is %d\n", number2 );
		}
	}
	
	if ( number3 < number1 ) {
		if ( number3 < number2 ) {
		printf( "Smallest is %d\n", number3 );
		}
	}


	if ( number1 > number2 ) {
		if ( number1 > number3 ) {
		printf( "Largest is %d\n", number1 );
		}
	}
	
	if ( number2 > number1 ) {
		if ( number2 > number3 ) {
		printf( "Largest is %d\n", number2 );
		}
	}
	
	if ( number3 > number1 ) {
		if ( number3 > number2 ) {
		printf( "Largest is %d\n", number3 );
		}
	}

	return 0;
}