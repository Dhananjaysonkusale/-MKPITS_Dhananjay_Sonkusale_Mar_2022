//Write a C program to check if y is greater than x, and z is greater than y from three given integers x,y,z.
#include<stdio.h>
#include<conio.h>
void main()
{
	int x,y,z;
	printf("Enter value of x ");
	scanf("%d",&x);
	printf("Enter value of y ");
	scanf("%d",&y);
	printf("Enter value of z ");
	scanf("%d",&z);
	
	if(y>x)
	{
		printf("Y is Greater Than X");
	}
	if(z>y)
	{
		printf("Z is Greater Than Y");
	}
	
}