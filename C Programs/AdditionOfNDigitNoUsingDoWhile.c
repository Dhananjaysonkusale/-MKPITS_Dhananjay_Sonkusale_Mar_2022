#include<stdio.h>
#include<conio.h>
void main()
{
	int n,sum=0,r;
	printf("Enter any number : ");
	scanf("%d",&n);
	
	do
	{    
	r=n%10;    
	sum=sum+r;    
	n=n/10;    
	}	
	while(n>0);   
	
	printf("addition is %d",sum);
}

