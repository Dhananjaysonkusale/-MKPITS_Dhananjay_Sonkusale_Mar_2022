/*Write a C program to read the age of a candidate and determine whether it is eligible for his/her own vote.*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int age;
	printf("Enter Your Age : ");
	scanf("%d",&age);
	
	if(age>18)
	{
		printf("You Are Eligible For Own Vote ");
	}
	else
	{
		printf("You Are Not Eligible For Own Vote ");		
	}
}