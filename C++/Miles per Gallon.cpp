#include <stdio.h>

int main( void )
{
	float gallons;
	float miles;
	float milespergallon = 0;
	float averagempg = 0;
	float totalgallons = 0;
	float totalmiles = 0;

	printf( "Enter the gallons used (-1 to end): " );
	scanf( "%f", &gallons );

	printf( "Enter the miles driven: " );
	scanf( "%f", &miles );

	while ( gallons != -1 ) {
		milespergallon = miles / gallons;
		printf( "The miles / gallon for this tank was %f\n", milespergallon );
		
		totalgallons += gallons;
		totalmiles += miles;

		printf( "Enter the gallons used (-1 to end): " );
		scanf( "%f", &gallons );

		if ( gallons != -1 ) {
			printf( "Enter the miles driven: " );
			scanf( "%f", &miles );
		}
		else {
			averagempg = totalmiles / totalgallons;
			printf( "The overall average miles/gallon was %f\n", averagempg );
		}
	}
	return 0;
}
