#include<stdio.h>
#include<conio.h>
void main()
{
	int a;
	a=1;
	printf("All Even Number between 1 and 50 : \n ");
	
	while(a<=50)
	{
		a++;
		
		if(a%2==0)
		{
		printf("%d ",a);
		}
	}
}
