#include <stdio.h>

int main( void )
{
	int number1;
	int number2;

	printf( "Enter two numbers\n" );
	scanf( "%d%d", &number1, &number2 );

	if ( number1 > number2 ) {
		printf( "%d is larger\n", number1 );
	}

	if ( number1 < number2 ) {
		printf( "%d is larger\n", number2 );
	}

	if ( number1 == number2 ) {
		printf( "These numbers are equal\n" );
	}

	return 0;
}