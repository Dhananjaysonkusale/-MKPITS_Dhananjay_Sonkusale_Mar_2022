//Write a C program to reverse a given array of integers and length 5.
#include<stdio.h>
#include<conio.h>
void main()
{
	int i,j,a[5];
	
	for(i=0;i<5;i++)
	{
		printf("Enter Array Element : ");
		scanf("%d",&a[i]);	
	}
	for(i=4;i>=0;i--)
	{
		printf("%d ",a[i]);
	}
}