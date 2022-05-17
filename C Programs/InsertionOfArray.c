#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
void main()
{
	int n,c,p;
	printf("Enter size of array : ");
	scanf("%d",&n);
	int a[n],k;

	printf("Enter the array element : \n");
	for(int i=0;i<n;i++)
	{
	    scanf("%d",&a[i]);
	}
	
	printf("Enter the new element you want to enter : ");
	scanf("%d",&k);
	
	int choice;
	printf("Enter Position you want : \n");
	printf("Press 1 : Insert at Top\n ");
	printf("Press 2 : Insert at Any Position\n ");
	printf("Press 3 : Insert at End\n ");
    scanf("%d",&choice);
    
    switch(choice)
    {
        case 1:
        	
            for(int i=0;i<n+1;i++)
	        {
	            int t=a[i];
	            a[i]=k;
	            k=t;
	        }
            break;

        case 2:
            printf("enter the Position : ");
            scanf("%d",&p);
            for(int i=0;i<n+1;i++)
	        {
	            if(i==p-1)
	            {
	                for(int j=p-1;j<n+1;j++)
	                {
	                    int t=a[j];
	                    a[j]=k;
	                    k=t;
	                }
	                break;
	            }
	        }
            break;

        case 3:
            a[n]=k;
            break;

        default:
            printf("Invalid Input !");
    }

    printf("New Array is : \n");
	for(int i=0;i<n+1;i++)
	{
	    printf("%d \n",a[i]);
	}


}