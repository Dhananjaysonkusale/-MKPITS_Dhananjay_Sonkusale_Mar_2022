#include<stdio.h>
#include<conio.h>
int i=1;
void fun()
{
//	int i=1;
	printf("%d ",i);
	i++;
	if(i==10)
	return;
	fun();
}
void main()
{
	fun();
}