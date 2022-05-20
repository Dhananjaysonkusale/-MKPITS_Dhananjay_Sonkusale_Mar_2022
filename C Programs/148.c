/*Write a C program to find whether a given year is a leap year or not*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int year;
	printf("Enter Year you want to check leap year or Not : ");
	scanf("%d",&year);
	
	if(year%400==0 || year%100==0 || year%4==0 )
	{
		printf("%d year is a Leap Year !",year);
	}
	else
	{
		printf("%d Year is Not a Leap Year !",year);
	}
}