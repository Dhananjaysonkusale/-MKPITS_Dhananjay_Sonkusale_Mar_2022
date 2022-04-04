#include<stdio.h>
#include<conio.h>
void main()
{
	int num,a,b,c,rev,res;
	int res2,res3,resf;
	printf("Enter any 3 digit number : ");
	scanf("%d",&num);
	a=num%10;
	num=num/10;
	b=num%10;
	num=num/10;
	c=num%10;
	
	res=a*a*a;
	res2=b*b*b;
	res3=c*c*c;
	resf=res+res2+res3;
	if(num==resf);
	{
		printf("Your number is armstrong number");
	}
	if(num=!resf)
	{
		printf("your number is not armstrong ");
	}
	
}