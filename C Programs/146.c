/*Write a c program that takes a number as input and then displays a rectangle 
of 3 columns wide and 5 rows tall using that digit*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int n;
	printf("Enter A Number You Want to Print : ");
	scanf("%d",&n);
	printf("\n \n ");
	printf("Rectangle Of 3 Column and 5 Row : \n\n");
	printf(" %d %d %d \n",n,n,n);
	printf(" %d   %d \n",n,n);
	printf(" %d   %d \n",n,n);
	printf(" %d %d %d \n",n,n,n);
	
}