#include <stdio.h>

int main( void )
{
	int account1 = 0;
	float oldcreditlimit1 = 0;
	float balance1 = 0;
	float newcreditlimit1 = 0;

	int account2 = 0;
	float oldcreditlimit2 = 0;
	float balance2 = 0;
	float newcreditlimit2 = 0;

	int account3 = 0;
	float oldcreditlimit3 = 0;
	float balance3 = 0;
	float newcreditlimit3 = 0;

	int counter = 1;
	
	while ( counter <= 3 ) {

		if ( counter = 1) {
		printf( "Enter account number: " );
		scanf( "%d", &account1 );

		printf( "Enter credit limit: " );
		scanf( "%f", &oldcreditlimit1 );

		printf( "Enter current balance: " );
		scanf( "%f", &balance1 );

		}

		if ( counter = 2) {
		printf( "Enter account number: " );
		scanf( "%d", &account2 );

		printf( "Enter credit limit: " );
		scanf( "%f", &oldcreditlimit2 );

		printf( "Enter current balance: " );
		scanf( "%f", &balance2 );
		
		}

		if ( counter = 3) {
		printf( "Enter account number: " );
		scanf( "%d", &account3 );

		printf( "Enter credit limit: " );
		scanf( "%f", &oldcreditlimit3 );

		printf( "Enter current balance: " );
		scanf( "%f", &balance3 );
		
		}

		counter++;

	}

	newcreditlimit1 = oldcreditlimit1 / 2;
	newcreditlimit2 = oldcreditlimit2 / 2;
	newcreditlimit3 = oldcreditlimit3 / 2;

	printf( "Account: %d\n", account1 );
	printf( "New Credit limit: %.2f\n", newcreditlimit1 );

	printf( "Account: %d\n", account2 );
	printf( "New Credit limit: %.2f\n", newcreditlimit2 );
		
	printf( "Account: %d\n", account3 );
	printf( "New Credit limit: %.2f\n", newcreditlimit3 );

	printf( "The following accounts exceed their new credit limits:\n" );

	if ( balance1 > newcreditlimit1 ) {
				
		printf( "Account: %d\t", account1 );
		printf( "Credit Limit Exceeded.\n" );
	}

	if ( balance2 > newcreditlimit2 ) {
				
		printf( "Account: %d\t", account2 );
		printf( "Credit Limit Exceeded.\n" );
	}

	if ( balance3 > newcreditlimit3 ) {
				
		printf( "Account: %d\t", account3 );
		printf( "Credit Limit Exceeded.\n" );
	}

	if (balance1 < newcreditlimit1 ) {
		if (balance2 < newcreditlimit2 ) {
			if (balance3 < newcreditlimit3 ) {
				printf( "None, all accounts were under their credit limit\n" );
			}
		}
	}

	return 0;
}