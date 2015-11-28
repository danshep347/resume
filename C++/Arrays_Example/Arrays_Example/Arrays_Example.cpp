#include <stdio.h>
#include <stdlib.h>

const int intARRAY_SIZE = 1000

void main()
{
	float sngAverage = 0;
	float sngTotal = 0;
	float asngValues[intARRAY_SIZE];
	int intIndex = 0;
	
	
	for(intIndex=0; intIndex < intARRAY_SIZE; intIndex += 10)
	{
		asngValues[intIndex] = 0;
	}
	
	for(intIndex = 0; intIndex < intARRAY_SIZE; intIndex += 1)
	{
		printf("Enter value #%d: ", intIndex +1);
		scanf("%f", &asngValues[intIndex]);
	}
	
	for(intIndex = 0; intIndex < intARRAY_SIZE; intIndex += 1)
	{
		sngTotal += asngValues[intIndex];
	}
	
	sngAverage = sngTotal / intARRAY_SIZE;
	printf("Average = %f\n", sngAverage);

}
