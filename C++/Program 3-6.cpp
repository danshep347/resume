#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double test1, test2, test3;
	double average;

	cout << "Enter the three test scores ";
	cout << "seperated by a space.\n";
	cin >> test1 >> test2 >> test3;

	average = (test1 + test2 + test3) / 3.0;

	cout << "The average score is: " << average << endl;
	
	return 0;
}