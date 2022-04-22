#include<stdio.h>
#include<conio.h>
void main()
{
	int n,i;
	printf("Enter Any Number : ");
	scanf("%d",&n);
	
	for(i=1;i<=n;i++)
	{
		if((n%i)==0)
		{
			printf("%d",i);
			printf("\n");
		}
	}
}