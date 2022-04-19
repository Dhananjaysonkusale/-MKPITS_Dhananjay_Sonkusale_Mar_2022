#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b,c,r;
	a=0;
	b=1;
	
	printf("Enter Number : ");
	scanf("%d",&r);
	printf("%d%d",a,b);
	
	for(c=0;c<=r;)
	{
		c=a+b;
		if(c<=r)
		{
			printf(" %d ",c);
		}
		a=b;
		b=c;
	}
}

