#include <stdio.h>

void AddNumbers1to100();

void main()
{
	long lngTotal = 0;
	long lngIndex = 0;

	lngTotal = AddNumbers1to100;

	printf("problem #1: Add numbers 1 to 100 = %ld", lngTotal);
	
	getchar();
		/*system("pause"),*/
}

long AddNumbers1to100()
{
	for(lngIndex = 1; lngIndex <=100; lngIndex +=1)
	{
		lngTotal += lngIndex;
	}
	return lngTotal
}