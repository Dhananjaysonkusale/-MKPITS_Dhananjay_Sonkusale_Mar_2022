/*Write a C program to check a given array of integers of length 1 or more and return
 true if the first element and the last element are equal in the given array.*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int n,i;
	printf("Enter Size Of Array \n");
	scanf("%d",&n);
	
	int a[n];
	for(i=0;i<n;i++)
	{
		printf("Enter Array element : ");
		scanf("%d",&a[i]);
	}
	
	if(a[0]==a[n-1])
	{
		printf("True !");
	}
	else
	{
		printf("False !");
	}
}