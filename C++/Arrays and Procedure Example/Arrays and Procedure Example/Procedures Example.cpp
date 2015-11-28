// --------------------------------------------------------------------------------
// Name:	Daniel Shepherd
// Class:	C++ #2
// Abstract:	Array/Procedure example;  This program will add a bunch of values together and display the average.
// --------------------------------------------------------------------------------



// --------------------------------------------------------------------------------
// Includes
// --------------------------------------------------------------------------------
#include <stdio.h>
#include <stdlib.h>
#include <math.h>



// --------------------------------------------------------------------------------
// Constants
// --------------------------------------------------------------------------------
const int intARRAY_SIZE = 5;



// --------------------------------------------------------------------------------
// Prototypes (function declarations)
// --------------------------------------------------------------------------------
void InitializeArray(float asngValues[]);
void PopulateArray(float asngValues[]);
float CalculateArrayTotal(float asngValues[]);



// --------------------------------------------------------------------------------
//	Name: Main
//	Abstract: This is where the program starts.
// --------------------------------------------------------------------------------
void main()
{
	float sngAverage = 0;
	float sngTotal = 0;
	float asngValues[intARRAY_SIZE];
	int intIndex = 0;
	
	InitializeArray(asngValues);

	PopulateArray(asngValues);
	
	sngTotal = CalculateArrayTotal(asngValues);

	sngAverage = sngTotal / intARRAY_SIZE;
	printf("Average = %f\n", sngAverage);
}



// --------------------------------------------------------------------------------
//	Name: InitializeArray
//	Abstract: This sub routine declares the array values.
// --------------------------------------------------------------------------------
void InitializeArray(float asngValues[])
{
	int intIndex = 0;

	for(intIndex=0; intIndex < intARRAY_SIZE; intIndex += 10)
	{
		asngValues[intIndex] = 0;
	}
}



// --------------------------------------------------------------------------------
//	Name: PopulateArray
//	Abstract: This sub routine gathers information from the user.
// --------------------------------------------------------------------------------
void PopulateArray(float asngValues[])
{
	int intIndex = 0;

	for(intIndex = 0; intIndex < intARRAY_SIZE; intIndex += 1)
	{
		printf("Enter value #%d: ", intIndex +1);
		scanf("%f", &asngValues[intIndex]);
	}
}



// --------------------------------------------------------------------------------
//	Name: CalculateArrayTotal
//	Abstract: This function calculates the total by adding up the values the user inputs.
// --------------------------------------------------------------------------------
float CalculateArrayTotal(float asngValues[])
{
	int intIndex = 0;
	float sngTotal = 0;

	for(intIndex = 0; intIndex < intARRAY_SIZE; intIndex += 1)
	{
		sngTotal += asngValues[intIndex];
	}

	return sngTotal;
}