#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b,c,d,e,sum=0,count=0;
	int ave,ave1,sum1=0,count1=0;
	printf("Enter 1st Number :");
	scanf("%d",&a);
	printf("Enter 2nd Number :");
	scanf("%d",&b);
	printf("Enter 3rd Number :");
	scanf("%d",&c);
	printf("Enter 4th Number :");
	scanf("%d",&d);
	printf("Enter 5th Number :");
	scanf("%d",&e);
		
	if(a>0)
	{
		sum=sum+a;
		count=count+1;
	}
	else
	{
		sum1=sum1+a;
		count1=count1+1;
	}
	
	if(b>0)
	{
		sum=sum+b;
		count=count+1;
	}
	else
	{
		sum1=sum1+b;
		count1=count1+1;
	}
	
	if(c>0)
	{
		sum=sum+c;
		count=count+1;
	}
	else
	{
		sum1=sum1+c;
		count1=count1+1;
	}
	
	if(d>0)
	{
		sum=sum+d;
		count=count+1;
	}
	else
	{
		sum1=sum1+d;
		count1=count1+1;
	}
	
	if(e>0)
	{
		sum=sum+e;
		count=count+1;
	}
	else
	{
		sum1=sum1+e;
		count1=count1+1;
	}
	
	ave=sum/count;
	printf("%d \n",ave);
	
	ave1=sum1/count1;
	printf("%d \n",ave1);
}