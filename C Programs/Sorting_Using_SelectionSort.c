/*Sorting Using Selection Sort*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int i,j,n,temp;
	
	printf("Enter a size of Array : ");
	scanf("%d",&n);
	int a[n];
	for(i=0;i<n;i++)
	{
		printf("Enter a Array Element : ");
		scanf("%d",&a[i]);
	}
	
	for(i=0;i<n;i++)
	{
		for(j=i+1;j<n;j++)
		{
			if(a[i]>a[j])
			{
				temp=a[i];
				a[i]=a[j];
				a[j]=temp;
				
			}
		}
	}
	printf("\n \n Sorted array is : \n");
	for(i=0;i<n;i++)
	{
		printf("%d \n",a[i]);
	}
	
}