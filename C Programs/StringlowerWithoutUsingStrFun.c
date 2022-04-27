#include<stdio.h>
#include<conio.h>
#include<string.h>
void main()
{
  	char name[50];
  	int i;
 
  	printf("Enter Upper Case String : ");
  	scanf("%s",name);
  	
  	for (i=0; name[i]!='\0'; i++)
  	{
  		if(name[i] >='A' &&name[i]<='Z')
  		{
  			name[i]=name[i]+32;
		}
  	}
	printf("Upper String = %s",name);
}