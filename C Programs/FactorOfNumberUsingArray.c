#include<stdio.h>
#include<conio.h>
void main()
{
    int a[5],i,j;
    for(i=0;i<5;i++)
    {
    	printf("a[%d] : ",i);
    	scanf("%d",&a[i]);
	}
	
	for(i=0;i<5;i++)
	{
		int f=1;
		for(j=1;j<=a[i];j++)
		{
			f=f*j;
		}
		printf("Factorial of %d = %d\n",a[i],f);
	}
}