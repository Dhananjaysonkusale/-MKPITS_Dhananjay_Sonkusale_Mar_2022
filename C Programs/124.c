/*Write a C program to check if the number of 3's is greater than the number of 5's.*/
#include<stdio.h>
#include<conio.h>
void main()
{
    int n,i,s=0,t=0;
    printf("Enter the size of array : ");
    scanf("%d",&n);
    int a[n];
    printf("Enter the array element : \n");
    for(i=0;i<n;i++)
    {
        scanf("%d",&a[i]);
    }
    for (i=0;i<n;i++)
    {
        if (a[i]==5) 
        {
            s=s+1;
        }
        else 
		if(a[i]==3)
        {
            t=t+1;
        }
    }
    
    if(t>s)
    {
        printf("TRUE");
    }
    else
    {
        printf("FALSE");
    }
}