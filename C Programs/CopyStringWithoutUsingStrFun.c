#include<stdio.h>
#include<conio.h>
#include<string.h>
void main()
{
  	char name1[20],name2[20];
  	int i;
 	printf("Enter Any Name: ");
  	scanf("%s",name1);
  	
  	for(i=0;name1[i]!='\0';i++)
  	{
  		name2[i] = name1[i];
  	}
  	

  	printf("%s \n ",name2);
  	printf("Length Of String is = %d\n", i);
}