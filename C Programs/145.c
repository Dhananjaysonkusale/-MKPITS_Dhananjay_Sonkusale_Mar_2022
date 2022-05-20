/*Write a c program that takes an age (for example 20) as input and prints something as
"You look older than 20"*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int age;
	printf("Enter Your Age : ");
	scanf("%d",&age);
	
	if(age>20)
	{
		printf("You Look Older Than 20");
	}
	else
	{
		printf("You Look Younger Than 20");		
	}
	
}