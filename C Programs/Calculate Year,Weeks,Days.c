#include<stdio.h>
#include<conio.h>
void main()
{
	int days,year,weeks,day;
	printf("Enter days :");
	scanf("%d",&days);
	
	year=days/365;
	printf("Year = %d\n",year);
	
	weeks=(days%365)/7;
	printf("Weeks = %d\n",weeks);
	
	day=days-((year*365)+(weeks*7));
	printf("days = %d\n",day);
}