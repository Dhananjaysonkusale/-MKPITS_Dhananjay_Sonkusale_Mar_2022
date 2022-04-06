#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b,c;
	printf("Enter 1st number : ");
	scanf("%d",&a);
	printf("Enter 2nd number : ");
	scanf("%d",&b);
	printf("Enter 3rd number : ");
	scanf("%d",&c);
	
	
	if(a>b && a>c)
	{
		printf("1st Number is greater ");
	}
	else
	if(b>c && b>a)
	{
		printf("2nd Number is greater ");
	}
	else
	{
		printf("3rd Number is greater ");
	}
}