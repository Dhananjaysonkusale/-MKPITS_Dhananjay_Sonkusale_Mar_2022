/*Write a c program that takes a number as input and print its multiplication table.*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int n,res;
	printf("Enter a Number You Want Table : ");
	scanf("%d",&n);
	
	printf("Multiplication Table Of %d is \n",n);
	
	for(int i=1;i<=10;i++)
	{
		res=n*i;
		printf(" %d \n",res);
	}
	
}