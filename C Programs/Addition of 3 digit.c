#include<stdio.h>
#include<conio.h>
void main()
{
	int num,a,b,c,res;
	printf("Enter any 3 digit number : ");
	scanf("%d",&num);
	a=num%10;
	num=num/10;
	b=num%10;
	num=num/10;
	c=num%10;
	
	res=a+b+c;
	printf("addition is %d",res);
}