#include<stdio.h>
#include<conio.h>

void fun()
{
	static int i=1;
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