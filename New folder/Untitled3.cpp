#include<iostream>
using namespace std;
int a;
int c;
int b;
int tong;

void tinh()
{
	tong =a+c+b;
  //  *p_tong = tong;
}

void xuat(int *p)
{
	cout<<"vay ket qua cua tinh la"<<*p<<" voi chia chi la "<<&*p;
}


int main()
{

	int *p_tong=&tong;
	cout<<"a";
	cin>>a;
	cout<<"c";
	cin>>c;
		cout<<"b";
	cin>>b;
	tinh();
	xuat(p_tong);
	cout<<"hello ban"<<*p_tong;
	system("pause");
	
}
