#include<stdio.h>
#include<conio.h>
void main()
{
	int n,i,d=0;
	
	printf("Enter Any Number :");
	scanf("%d",&n);
	
	i=2;
	do
	{
		if(n%i==0)
		{
			d=1; 
			break;
		}
		i=i+1;
	}
	while(i<n);
		
		if(d==0)
		{
			printf("Enter Number is Prime Number !");
		}
		else
		{
			printf("Enter Number is Not Prime Number !");
		}

}