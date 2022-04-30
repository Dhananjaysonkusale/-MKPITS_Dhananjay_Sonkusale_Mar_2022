/*check triple is present in an array of integer or not
when value is apprear in  three time in a row is an array it is called triple*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int i,a[5],t=0;
	printf("Enter any Five Number :\n");
	
	for(i=0;i<5;i++)
	{
		printf("Enter number :");
		scanf("%d",&a[i]);
		
	}
	for(i=0;i<5;i++)
	{
		int k=a[i];
		
		if(a[i]==k && a[i+1]==k && a[i+2]==k)
		{
			printf("Triple");
			t=1;
		}
	}
	if(t==0)
	{
		printf("Not Triple");
	}
	

	
}