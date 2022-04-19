#include<stdio.h>
#include<conio.h>
void main()
{
	int num;
	int a,b,c,a1,res;
	
	printf("All Armstrong number between 1 to 1000 : \n");
	
	for(num=001;num<=1000;num++)
	{
		a1=num;
	
		a=a1%10;
		a1=a1/10;
		b=a1%10;
		a1=a1/10;
		c=a1%10;
		
		res=(a*a*a)+(b*b*b)+(c*c*c);
		
		if(num==res)
		{
			printf(" %d \n",res);
		}
	}
}
