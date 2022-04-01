#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b,t;
	printf("Enter any two number ");
	scanf("%d %d",&a,&b);
	t=b;
	b=a;
	a=t;
	printf("After swapping \n");
	printf("a=%d b=%d",a,b);
	
}