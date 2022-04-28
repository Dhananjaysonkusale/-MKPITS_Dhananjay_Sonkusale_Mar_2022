//check two integer and return true if one of them is 30 or if their sum is 30
#include<stdio.h>
#include<conio.h>
void main()
{
	int n1,n2,sum;
	
	printf("Enter 1st Number : ");
	scanf("%d",&n1);
	printf("Enter 2nd Number : ");
	scanf("%d",&n2);
	
	sum=n1+n2;
	if(n1==30 || n2==30 || sum==30)
	{
		printf(" TRUE !");
	}
}