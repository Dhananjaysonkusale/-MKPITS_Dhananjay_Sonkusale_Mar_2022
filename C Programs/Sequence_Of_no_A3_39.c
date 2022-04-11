#include<stdio.h>
#include<conio.h>
void main() 
{
	int a,b,i,j,k;
	printf("Number Of Column: ");
	scanf("%d",&a);
	printf("Number of Rows: ");
    scanf("%d",&b);
    
    i=1;
    k=1;
	while(i<=a)
	{
		i++;
		
		j=1;
		while(j<=b)
		{
			j++;
			printf("%d ",k);
			k++;
		}
		printf("\n");
		
	}
	
	
}