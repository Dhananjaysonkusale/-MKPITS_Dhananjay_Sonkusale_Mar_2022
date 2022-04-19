#include<stdio.h>
#include<conio.h>
void main() 
{
	int a,b,temp,i,sum=0;
	
    printf("Input the first integer: "); 
    scanf("%d", &a);
    printf("Input the second integer: ");
    scanf("%d", &b);
		
	if(a>b) 
    {
		temp=b;
		b=a;
		a=temp;
	}

	for(i=a;i<=b;i=i+1)
		{
			if((i%17) != 0)
			{
				sum=sum+i;
			}
		}
	printf("Sum: %d \n", sum);
}