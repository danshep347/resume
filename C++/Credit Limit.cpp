#include <stdio.h>

int main( void )
{
	int account = 0;
	float balance = 0;
	float charges = 0;
	float credits = 0;
	float creditlimit = 0;
	float finalbalance = 0;
	
	while ( account != -1 ) {

	printf( "Enter account number (-1 to end): " );
	scanf( "%d", &account );

		if ( account != -1 ) {
			printf( "Enter beginning balance: " );
			scanf( "%f", &balance );

			printf( "Enter total charges: " );
			scanf( "%f", &charges );

			printf( "Enter total credits: " );
			scanf( "%f", &credits );

			printf( "Enter credit limit: " );
			scanf( "%f", &creditlimit );

			finalbalance = balance + charges - credits;

			if ( finalbalance > creditlimit ) {
				printf( "Account: %d\n", account );
				printf( "Credit limit: %.2f\n", creditlimit );
				printf( "Balance: %.2f\n", finalbalance );
				printf( "Credit Limit Exceeded.\n" );
			}
		}
	}
	return 0;
}
