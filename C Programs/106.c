/*Write a C program to create a new array taking the first and last elements
 of a given array of integers and length one or more*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int i,a[5],b[5],c[2];
	
	for(i=0;i<5;i++)
	{
		printf("Enter 1st Array element : ");
		scanf("%d",&a[i]);
	}
	
	printf("\n");
	
	c[0]=a[0];
	c[1]=a[4];
	for(int j=0;j<2;j++)
	{
		printf("%d ",c[j]);
	}
	
}