/*Write a C program to check if a given array of integers and length 2, contains 15 or 20.*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int i,a[2],x=0;
	
	for(i=0;i<2;i++)
	{
		printf("Enter 1st Array element : ");
		scanf("%d",&a[i]);
	}
	
	printf("\n");
	
	for(int j=0;j<2;j++)
	{
		if(a[j]==15 || a[j]==20)
		{
			printf("True !");
			x=1;
			break;
		}
	}
	if(x==0)
	{
		printf("False !");
	}
	
}