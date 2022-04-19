#include<stdio.h>
#include<conio.h>
void main() 
{
	int a,b,t,i,sum=0;
	
    printf("Input the first integer: "); 
    scanf("%d", &a);
    printf("Input the second integer: ");
    scanf("%d", &b);
		
	if(a>b) 
    {
		t=b;
		b=a;
		a=t;
	}
	for(i=a;i<=b;i=i+1)
		{
			if((i%7)==2 || (i%7)==3)
			{
				printf("%d \n",i);
			}
		}	
}