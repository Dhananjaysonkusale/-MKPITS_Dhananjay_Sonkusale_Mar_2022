#include<stdio.h>
#include<conio.h>

void fun(int i)
{
	if(i==10)
	return;
	
	printf("%d ",i);
	fun(i+1);
}
void main()
{
	fun(1);
}