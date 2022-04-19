#include<stdio.h>
#include<conio.h>
void main()
{
	int n,i,d=0;
	
	printf("Enter Any Number :");
	scanf("%d",&n);
	
	for(i=2;i<n;i++)
	{
		if(n%i==0)
		{
			d=1;
			break;
		}
	}
		if(d==0)
		{
			printf("Enter Number is Prime Number !");
		}
		else
		{
			printf("Enter Number is Not Prime Number !");
		}

}