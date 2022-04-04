#include<stdio.h>
#include<conio.h>
void main()
{
	int a1,num,a,b,c,rev;
	printf("Enter any 3 digit number : ");
	scanf("%d",&a1);
	num=a1;
	a=num%10;
	num=num/10;
	b=num%10;
	num=num/10;
	c=num%10;
	rev=a*100+b*10+c*1;
	if(a1==rev)
	{
		printf("Enter number is palindrome number");
		
	}
	else
	{
		printf("Enter number is not palindrome");
	}
	

}