//print absolute Difference Between n And 51,if n is greater than 51 then return triple the absolute difference
#include<stdio.h>
#include<conio.h>
void main()
{
	int n,n1=51,res;
	printf("Enter Any Number : ");
	scanf("%d",&n);
	
	if(n>n1)
	{
		res=(n-n1)*3;
		printf("Result = %d",res);
	}
	else
	{
		res=n1-n;
		printf("Result = %d",res);
	}
}