/*Write a c program to that takes three numbers (x,y,z) as input and print the output of
(x+y).z and x.y + y.z.*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int x,y,z,res1,res2;
	printf("Enter value of x :");
	scanf("%d",&x);
	printf("Enter value of y :");
	scanf("%d",&y);
	printf("Enter value of z :");
	scanf("%d",&z);
	
	res1=(x+y)*z;
	res2=x*y+y*z;
	printf("\n(x=y.z) = %d and x.y+y.z = %d",res1,res2);
}