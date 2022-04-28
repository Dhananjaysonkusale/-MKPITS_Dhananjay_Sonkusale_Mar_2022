//WAP to read Five Digit Integer and determine whether or not it is palindrome
#include<stdio.h>
#include<conio.h>
void main()
{
	int t,num,n1,n2,n3,n4,n5,rev;
	printf("Enter any 5 digit number : ");
	scanf("%d",&t);
	
	num=t;
	
	n1=num%10;
	num=num/10;
	n2=num%10;
	num=num/10;
	n3=num%10;
	num=num/10;
	n4=num%10;
	num=num/10;
	n5=num%10;
	
	rev=n1*10000+n2*1000+n3*100+n4*10+n5*1;
	//printf("%d\n",rev);
	if(t==rev)
	{
		printf("Enter number is palindrome number");
		
	}
	else
	{
		printf("Enter number is not palindrome");
	}
	

}