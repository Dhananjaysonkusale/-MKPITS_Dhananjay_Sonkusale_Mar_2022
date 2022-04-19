#include<stdio.h>
#include<conio.h>
void main()
{
	int n,sum,r;
	printf("Enter any number : ");
	scanf("%d",&n);
	
	for(sum=0;n>0;n=n/10)    
	{    
	r=n%10;    
	sum=sum+r;    
	}
	printf("addition is %d",sum);
}
