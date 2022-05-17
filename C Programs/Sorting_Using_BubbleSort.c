/*Sorting Using Bubble Sort*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int i,j,n,temp;
	
	printf("Enter a size of Array :  ");
	scanf("%d",&n);
	int a[n];
	
	for(i=0;i<n;i++)
	{
		printf("Enter a Array Element : ");
		scanf("%d",&a[i]);
	}
	
	for(i=0;i<n;i++)
	{
		for(j=0;j<n-1;j++)
		{
			if(a[j]>a[j+1])
			{
				temp=a[j];
				a[j]=a[j+1];
				a[j+1]=temp;
				
			}
		}
	}
	printf("\n \n Sorted array is : \n");
	for(i=0;i<n;i++)
	{
		printf("%d \n",a[i]);
	}
	
}