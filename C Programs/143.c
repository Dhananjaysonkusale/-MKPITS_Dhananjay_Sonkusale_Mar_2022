/*Write a c program that takes four numbers as input to calculate and print the average.*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int n1,n2,n3,n4;
	float avg;
	printf("Enter 1st Number :");
	scanf("%d",&n1);
	printf("Enter 2nd Number :");
	scanf("%d",&n2);
	printf("Enter 3rd Number :");
	scanf("%d",&n3);
	printf("Enter 4th Number :");
	scanf("%d",&n4);
	
	avg=(n1+n2+n3+n4)/4;
	printf("Average Of Number is : %.2f",avg);
}