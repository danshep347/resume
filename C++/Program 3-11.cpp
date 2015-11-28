#include <iostream>
using namespace std;

int main()
{
	int begInv,
		sold,
		store1,
		store2,
		store3;

	cout << "One week ago, 3 new widget stores opened\n";
	cout << "at the same time with the same beginning\n";
	cout << "inventory. What was the beginning inventory? ";
	cin >> begInv;

	store1 = store2 = store3 = begInv;

	cout << "How many widgets has store 1 sold? ";
	cin >> sold;
	store1 -= sold;

	cout << "How many widgets has store 2 sold? ";
	cin >> sold;
	store2 -= sold;

	cout << "How many widgets has store 3 sold? ";
	cin >> sold;
	store3 -= sold;

	cout << "\nThe current inventory of each store:\n";
	cout << "Store 1: " << store1 << endl;
	cout << "Store 2: " << store2 << endl;
	cout << "Store 3: " << store3 << endl;

	return 0;
}