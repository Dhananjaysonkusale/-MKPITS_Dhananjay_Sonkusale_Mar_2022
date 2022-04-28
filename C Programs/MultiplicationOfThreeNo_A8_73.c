//multiplication of two number
#include<stdio.h>
#include<conio.h>
void main()
{
	int n1,n2,n3,mul;
	printf("Enter Any 1st Number : ");
	scanf("%d",&n1);
	printf("Enter Any 2nd Number : ");
	scanf("%d",&n2);
	printf("Enter Any 3rd Number : ");
	scanf("%d",&n3);
	
	mul=n1*n2*n3;
	printf("\nMultiplication Of Number %d*%d*%d = %d\n",n1,n2,n3,mul);
	
}