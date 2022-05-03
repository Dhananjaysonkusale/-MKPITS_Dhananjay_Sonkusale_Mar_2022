#include<stdio.h>
#include<conio.h>
void add(int x, int y);
void fun1();

void main()
{
	fun1();
}
void fun1()
{
	int a=2,b=4;
	add(a,b);
}
void add(int x, int y)
{
	int r; 
	r=x+y;
	printf("Res = %d",r);
}
