#include<stdio.h>
#include<conio.h>
void main()
{
	int n,t,sum=0,r;
	printf("Enter any number : ");
	scanf("%d",&n);
	
	for(t=n;n>0;)    
	{    
	r=n%10;    
	
	sum=sum*10+r;
	
	n=n/10;    
	}
	if(t==sum)
	{
		printf("Number is Palindrome : ");
		
	}
	else
	{
		printf("Number is not palindrome : ");
	}
	
	
}