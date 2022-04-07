#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b,t;
	printf("Enter 1st Number :");
	scanf("%d",&a);
	printf("Enter 2nd Number :");
	scanf("%d",&b);
	
	if(a>b)
	{
		t=a;
		a=b;
		b=t;
	}

	if((b%a)==0)
	{
		printf("Multiply !");		
	}
	else
	{
		printf("Not Multiply !");
	}
}